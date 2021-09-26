namespace GeekSeven.GeekUI
{
    public enum ESplitButtonDirection
    {
        Dropdown,
        Dropup,
        Dropright,
        Dropleft
    }

    public static class ESplitButtonDirectionExtensions 
    {
        public static string ToESplitButtonDirectionString(this ESplitButtonDirection direction)
        {
            switch (direction)
            {
                case ESplitButtonDirection.Dropdown : return "";
                case ESplitButtonDirection.Dropleft : return "dropleft";
                case ESplitButtonDirection.Dropright : return "dropright";
                case ESplitButtonDirection.Dropup : return "dropup";
                default: return "";
            }
        }
    }
}