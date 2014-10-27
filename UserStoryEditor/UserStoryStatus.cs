namespace UserStoryEditor
{
    public class UserStoryStatus
    {
        public readonly UserStoryStatus Done = new UserStoryStatus("done");
        public readonly UserStoryStatus Planned = new UserStoryStatus("planned");
        public readonly UserStoryStatus Blocked = new UserStoryStatus("blocked");

        public UserStoryStatus(string value)
        {
            this.Value = value;
        }

        public string Value { get; private set; }

        public static implicit operator UserStoryStatus(string absolutePath)
        {
            return new UserStoryStatus(absolutePath);
        }

        public static implicit operator string(UserStoryStatus absolutePath)
        {
            return absolutePath.Value;
        }

        public static bool operator ==(UserStoryStatus a, UserStoryStatus b)
        {
            if (ReferenceEquals(a, b))
            {
                return true;
            }

            // ReSharper disable RedundantCast.0 because otherwise it results in recursion.
            if (((object)a == null) || ((object)b == null))
            // ReSharper restore RedundantCast.0
            {
                return false;
            }

            return a.Value == b.Value;
        }

        public static bool operator !=(UserStoryStatus a, UserStoryStatus b)
        {
            return !(a == b);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            if (obj.GetType() != this.GetType())
            {
                return false;
            }

            return this.Equals((UserStoryStatus)obj);
        }

        public override int GetHashCode()
        {
            return this.Value != null ? this.Value.GetHashCode() : 0;
        }

        public override string ToString()
        {
            return this.Value;
        }

        private bool Equals(UserStoryStatus other)
        {
            return string.Equals(this.Value, other.Value);
        }
    }
}