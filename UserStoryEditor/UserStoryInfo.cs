namespace UserStoryEditor
{
    using System;
    using System.Collections.Generic;

    public class UserStoryInfo
    {
        public UserStoryInfo(Guid id, string title, string description, int? estimate/*, IEnumerable<Guid> children*/)
        {
            this.Id = id;
            this.Title = title;
            this.Description = description;
            this.Estimate = estimate;
            //this.Children = new List<Guid>(children);
        }

        public Guid Id { get; private set; }

        public string Title { get; private set; }

        public string Description { get; private set; }

        public int? Estimate { get; private set; }

        //public IEnumerable<Guid> Children { get; private set; }
    }
}