using System.IO;
namespace NAC_Aircraft_Checklist.Util
{
    public static class DocumentBuilder
    {
        /** 
         * B1900 Headers
         * Get the header
         * Create Objects
         * 
         * **/
        public static Dictionary<string, List<string>> Build(char plane, int revision)
        {
            string inputString = "";
            Dictionary<string, List<string>> tables = new Dictionary<string, List<string>>();
            try
            {
                switch (plane)
                {
                    case 'b':
                    case 'B':
                        inputString = File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "Util/Documents/B1900/" + revision));
                        break;
                    case 'j':
                    case 'l':
                    case 'J':
                    case 'L':
                        inputString = File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "Util/Documents/Learjet/" + revision));
                        break;
                    default: break;
                }
                if (inputString.Length <= 0)
                    throw new Exception($"No contents found for {plane} : {revision}");
                string[] revSplit = inputString.Split(new char[] { '$' }, StringSplitOptions.RemoveEmptyEntries);
                string revObj = revSplit[0].Trim();
                
                string[] rev = revObj.Split(new char[] { '@' }, StringSplitOptions.RemoveEmptyEntries);

                tables.Add("Revision", new List<string>());
                tables.Add("Date", new List<string>());
                tables["Revision"].Add(rev[0].Trim());
                tables["Date"].Add(rev[1].Trim());

                string[] split = revSplit[1].Split(new char[] { '#' }, StringSplitOptions.RemoveEmptyEntries);

                System.Diagnostics.Debug.WriteLine(split.Length);
                string curKey = "";

                foreach (string s in split)
                {
                    string[] table = s.Split(new char[] { '*' }, StringSplitOptions.RemoveEmptyEntries);
                    string header = table[0].Trim();
                    tables.Add(header, new List<string>());
                    for (int i = 1; i < table.Length; i++)
                    {
                        tables[header].Add(table[i].Trim());
                        System.Diagnostics.Debug.WriteLine(header);
                    }
                }
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e);
            }
            return tables;
        }
    }
}
