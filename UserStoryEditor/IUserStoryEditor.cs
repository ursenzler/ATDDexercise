namespace UserStoryEditor
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IUserStoryEditor
    {
        Guid AddUserStory(string title, string description);
        
        int SumEstimates();
    }

    /* note: this is the requested interface, but during development, you may simplify it and build it incrementally.
    public interface IUserStoryEditor
    {
        Guid AddUserStory(Guid? parentUserStoryId, string title, string description);

        void RemoveUserStory(Guid userStoryId);

        void MoveUserStory(Guid userStoryId, Guid? newParentUserStoryId);

        IEnumerable<UserStoryInfo> GetUserStories(Guid? parentUserStoryId);

        void SetEstimate(Guid userStoryId, int? estimate);

        void SetStatus(Guid userStoryId, UserStoryStatus status);

        Task<int> SumEstimates(IEnumerable<UserStoryStatus> statusFilter, SumMode mode);
    }
    */
}