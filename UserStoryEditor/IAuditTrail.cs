namespace UserStoryEditor
{
    public interface IAuditTrail
    {
        void AddRecord(string operation);
    }
}