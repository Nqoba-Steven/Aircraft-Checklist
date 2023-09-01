using Microsoft.EntityFrameworkCore;
using NAC_Aircraft_Checklist.Models.Email;
using static NAC_Aircraft_Checklist.Util.Names.Tables;

namespace NAC_Aircraft_Checklist.Data.Services.Email
{
    public class EmailService : IEmailService
    {
        private readonly AppDbContext _context;
        public EmailService(AppDbContext dbContext)
        {
            _context = dbContext;
        }




        public void AddAllToUploadWaitList(List<BaseManagerRecipient> baseManagers)
        {
            try
            {
                List<UploadWaitList> uploadWaitList = new List<UploadWaitList>();
                foreach (BaseManagerRecipient recipient in baseManagers)
                {
                    UploadWaitList u = new UploadWaitList(recipient);
                    uploadWaitList.Add(u);
                }
                _context.UploadWaitList.AddRange(uploadWaitList);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine("Add to UploadWaitlist Failed");
                System.Diagnostics.Debug.WriteLine(e);
            }
        }

        public void AddBaseManagerRecipient(BaseManagerRecipient recipient)
        {
            try
            {
                _context.BaseManagerRecipients.Add(recipient);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e);
            }
        }

        public void AddEscalationRecipient(EscalationRecipient recipient)
        {
            try
            {
                _context.EscalationRecipients.Add(recipient);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e);
            }
        }

        public void AddPlannerRecipient(PlannerRecipient recipient)
        {
            try
            {
                _context.PlannerRecipients.Add(recipient);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e);
            }
        }

        public void AddToUploadWaitList(BaseManagerRecipient baseManager)
        {
            try
            {
                _context.UploadWaitList.Add(new UploadWaitList(baseManager));
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e);
            }
        }

        public bool BaseManagerRecipientExists(string emailAddress)
        {
            return _context.BaseManagerRecipients.Any(r => r.EmailAddress.ToLower() == emailAddress);
        }

        public bool EscalationRecipientExists(string emailAddress)
        {
            return _context.EscalationRecipients.Any(r => r.EmailAddress.ToLower() == emailAddress);
        }

        public async Task<IEnumerable<BaseManagerRecipient>> GetAllBaseManagerRecipients()
        {
            try
            {
                var result = await _context.BaseManagerRecipients.ToListAsync();
                return result;
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e);
            }
            return null;
        }

        public async Task<IEnumerable<EscalationRecipient>> GetAllEscalationRecipients()
        {
            try
            {
                var result = await _context.EscalationRecipients.ToListAsync();
                return result;

            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e);
            }
            return null;
        }

        public async Task<IEnumerable<PlannerRecipient>> GetAllPlannerRecipients()
        {
            try
            {
                var result = await _context.PlannerRecipients.ToListAsync();
                return result;
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e);
            }
            return null;
        }

        public BaseManagerRecipient GetBaseManagerRecipientById(int id)
        {
            try
            {
                BaseManagerRecipient result = _context.BaseManagerRecipients.Where(r => r.Id == id).FirstOrDefault();
                if (result != null)
                    return result;
                System.Diagnostics.Debug.WriteLine("No BaseManagerRecipient found");
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e);
            }
            return new BaseManagerRecipient();

        }



        public EscalationRecipient GetEscalationRecipientById(int id)
        {
            try
            {
                EscalationRecipient result = _context.EscalationRecipients.Where(r => r.Id == id).FirstOrDefault();
                if (result != null)
                    return result;
                System.Diagnostics.Debug.WriteLine("No EscalationRecipient found");
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e);
            }
            return new EscalationRecipient();
        }

        public PlannerRecipient GetRecipientPlannerById(int id)
        {
            try
            {
                PlannerRecipient result = _context.PlannerRecipients.Where(r => r.Id == id).FirstOrDefault();
                if (result != null)
                    return result;
                System.Diagnostics.Debug.WriteLine("No PlannerRecipient found");
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e);
            }
            return new PlannerRecipient();
        }

        public async Task<IEnumerable<UploadWaitList>> GetUploadWaitList()
        {
            try
            {
                var result = await _context.UploadWaitList.ToListAsync();
                return result;
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e);
            }
            return null;
        }

        public bool PlannerRecipientExists(string emailAddress)
        {
            return _context.PlannerRecipients.Any(r => r.EmailAddress.ToLower() == emailAddress);
        }

        public void RemoveBaseManagerRecipient(BaseManagerRecipient recipient)
        {
            try
            {
                this.RemoveBaseManagerRecipient(recipient.Id);
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e);
            }
        }

        public void RemoveBaseManagerRecipient(int id)
        {
            try
            {
                BaseManagerRecipient r = _context.BaseManagerRecipients.FirstOrDefault(rec => rec.Id == id);
                if (r != null)
                {
                    _context.BaseManagerRecipients.Attach(r);
                    _context.BaseManagerRecipients.Remove(r);
                    _context.SaveChanges();
                    System.Diagnostics.Debug.WriteLine("BaseManagerRecipient Recipient deleted");
                }
                else
                {
                    System.Diagnostics.Debug.WriteLine($"BaseManagerRecipient Recipient Failed to deleted {id}");
                }
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e);
            }
        }

        public void RemoveEscalationRecipient(EscalationRecipient recipient)
        {
            try
            {
                RemoveEscalationRecipient(recipient.Id);
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e);
            }
        }

        public void RemoveEscalationRecipient(int id)
        {
            try
            {
                EscalationRecipient r = _context.EscalationRecipients.FirstOrDefault(rec => rec.Id == id);
                if (r != null)
                {
                    _context.EscalationRecipients.Attach(r);
                    _context.EscalationRecipients.Remove(r);
                    _context.SaveChanges();
                    System.Diagnostics.Debug.WriteLine("EscalationRecipient Recipient deleted");
                }
                else
                {
                    System.Diagnostics.Debug.WriteLine($"EscalationRecipient Recipient Failed to deleted {id}");
                }
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e);
            }
        }

        public void RemoveFromUploadWaitList(BaseManagerRecipient baseManager)
        {
            try
            {
                RemoveFromUploadWaitList(baseManager.EmailAddress);
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e);
            }
        }

        public void RemoveFromUploadWaitList(string email)
        {
            try
            {
                UploadWaitList r = _context.UploadWaitList.FirstOrDefault(rec => rec.EmailAddress == email);
                if (r != null)
                {
                    _context.UploadWaitList.Attach(r);
                    _context.UploadWaitList.Remove(r);
                    _context.SaveChanges();
                    System.Diagnostics.Debug.WriteLine("UploadWaitList Recipient deleted");
                }
                else
                {
                    System.Diagnostics.Debug.WriteLine($"UploadWaitList Recipient Failed to deleted {email}");
                }
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e);
            }
        }

        public void RemovePlannerRecipient(PlannerRecipient recipient)
        {
            try
            {
                RemovePlannerRecipient(recipient.Id);
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e);
            }
        }

        public void RemovePlannerRecipient(int id)
        {
            try
            {
                PlannerRecipient r = _context.PlannerRecipients.FirstOrDefault(rec => rec.Id == id);
                if (r != null)
                {
                    _context.PlannerRecipients.Attach(r);
                    _context.PlannerRecipients.Remove(r);
                    _context.SaveChanges();
                    System.Diagnostics.Debug.WriteLine("PlannerRecipients Recipient deleted");
                }
                else
                {
                    System.Diagnostics.Debug.WriteLine($"PlannerRecipients Recipient Failed to deleted {id}");
                }
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e);
            }
        }



        public void UpdateBaseManagerRecipient(BaseManagerRecipient recipientUpdate)
        {
            try
            {
                var result = _context.BaseManagerRecipients.SingleOrDefault(r => r.Id == recipientUpdate.Id);

                if (result == null)
                {
                    System.Diagnostics.Debug.WriteLine("Failed to Update: No EmailRecipient found");

                    return;
                }
                _context.Entry(result).CurrentValues.SetValues(recipientUpdate);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e);
            }
        }

        public void UpdateEscalationRecipient(EscalationRecipient recipientUpdate)
        {
            try
            {
                var result = _context.EscalationRecipients.SingleOrDefault(r => r.Id == recipientUpdate.Id);

                if (result == null)
                {
                    System.Diagnostics.Debug.WriteLine("Failed to Update: No EmailRecipient found");

                    return;
                }
                _context.Entry(result).CurrentValues.SetValues(recipientUpdate);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e);
            }
        }

        public void UpdatePlannerRecipient(PlannerRecipient recipientUpdate)
        {
            try
            {
                var result = _context.PlannerRecipients.SingleOrDefault(r => r.Id == recipientUpdate.Id);

                if (result == null)
                {
                    System.Diagnostics.Debug.WriteLine("Failed to Update: No EmailRecipient found");

                    return;
                }
                _context.Entry(result).CurrentValues.SetValues(recipientUpdate);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e);
            }
        }
    }
}
