namespace NAC_Aircraft_Checklist.Services.Jobs
{
    public interface IJobService
    {
        void FireAndForgetJob();
        void RecurringJob();
        void DelayedJob();
        void ContinuationJob();
    }
}
