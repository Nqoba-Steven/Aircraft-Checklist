using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using NAC_Aircraft_Checklist.Data.Services;
using PdfSharpCore;
using PdfSharpCore.Pdf;
using SelectPdf;
using System.Net;
using TheArtOfDev.HtmlRenderer.PdfSharp;
using PuppeteerSharp;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.AspNetCore.Http.Extensions;

namespace NAC_Aircraft_Checklist.Controllers
{
    public class PDFController : Controller
    {
        IAircraftService _aircraftService;
        ICompositeViewEngine _viewEngine;
        public PDFController(ICompositeViewEngine viewEngine, IAircraftService aircraftService)
        {
            _aircraftService = aircraftService;
            _viewEngine = viewEngine;
        }
        public async Task<IActionResult> Index()
        {
            ViewData["Aircraft"] = await _aircraftService.GetAll();
            return View();
        }
        /*
        public async Task<IActionResult> Invoice()
        {

            using (var sw = new StringWriter())
            {
                var viewResult = _viewEngine.FindView(ControllerContext, "Index", false);

                if (viewResult == null)
                {
                    throw new ArgumentException("View cannot be found");
                }

                var viewDic = new ViewDataDictionary(new EmptyModelMetadataProvider(), new ModelStateDictionary());

                var viewContext = new ViewContext(
                    ControllerContext,
                    viewResult.View,
                    viewDic,
                    TempData,
                    sw,
                    new HtmlHelperOptions()
                    );
                await viewResult.View.RenderAsync(viewContext);
                var htmlToPdf = new HtmlToPdf(768, 1024);
                htmlToPdf.Options.DrawBackground = true;

                var pdf = htmlToPdf.ConvertHtmlString(sw.ToString());
                var bytes = pdf.Save();
                return File(bytes, "application/pdf");
            }

        }*/
        const string PrintServer = "http://172.21.37.156:8561/PrintPDF";
        //const string PrintServer = "http://172.21.37.156:8461/PrintPDF";
        [HttpGet]
        public async Task<IActionResult> Print(string type, int id)
        {
            try
            {
                //Send the url to the print sever
                //type gets the document type
                //id identifies the document
                //url is a view with populated fields
                //
                string ServerIp = $"{HttpContext.Connection.LocalIpAddress.ToString()}:{HttpContext.Connection.LocalPort}";

                //This should be a print document controller which offers populated view documents
                System.Diagnostics.Debug.WriteLine("Printing ");
               
                var browserFetcher = new BrowserFetcher();
                await browserFetcher.DownloadAsync(BrowserFetcher.DefaultChromiumRevision);
                var browser = await Puppeteer.LaunchAsync(new LaunchOptions
                {
                    Headless = true
                });
                //var page = await browser.NewPageAsync();
                string url =  $"https://acform.nac.co.za/B1900/Print?id={id}";

                var authCookie = HttpContext.Request.Cookies.FirstOrDefault(c => c.Key == ".AspNetCore.Identity.Application");
                System.Diagnostics.Debug.WriteLine(authCookie);
                System.Diagnostics.Debug.WriteLine(url);
                using (var page = await browser.NewPageAsync())
                {
                    await page.SetViewportAsync(new ViewPortOptions
                    {
                        Width = 595,
                        Height = 842
                    });
                    await page.GoToAsync("https://acform.nac.co.za/");
                   
                    foreach (var cookie  in Request.Cookies)
                    {
                        await page.SetCookieAsync(new CookieParam
                        {

                            Name = cookie.Key,
                            Value = cookie.Value,
                            Secure = true,
                        });
                        System.Diagnostics.Debug.WriteLine(cookie);
                        System.Diagnostics.Debug.WriteLine(await page.GetCookiesAsync(url));
                    }
                    await page.GoToAsync(url);
                    await page.EmulateMediaTypeAsync(PuppeteerSharp.Media.MediaType.Print);
                    var pdfData = await page.PdfDataAsync();
                    var cookies = await page.GetCookiesAsync(url);
                    foreach (var cookie in cookies)
                    {
                        System.Diagnostics.Debug.WriteLine(cookie.Name);
                        System.Diagnostics.Debug.WriteLine(cookie.Value);

                    }
                    return File(pdfData, "application/pdf");

                }

                //return File(pdfData, "application/pdf");
            }
            catch (Exception err)
            {
                System.Diagnostics.Debug.WriteLine(err);
                //Add code to catche the error
                return View();
            }
        }
        public IActionResult Result(string data)
        {

            return Redirect("/");
        }

    }
}
