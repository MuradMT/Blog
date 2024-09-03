namespace Blog.Core.ResultMessages
{
    public static class Messages
    {
        public static class Article
        {
            public const string Succesfully_Added = "Succesfully Added!";
            public const string Succesfully_Updated = "Succesfully Updated!";
            public const string Succesfully_Deleted = "Succesfully Deleted!";    
            public static string Add(string title)
            {
                return $"Article with {title} title added succesfully!";
            }
            public static string Update(string title)
            {
                return $"Article with {title} title updated succesfully!";
            }
            public static string Delete(string title)
            {
                return $"Article with {title} title deleted succesfully!";
            }

        }
        public static class Category
        {
            public static string Add(string name)
            {
                return $"Category with {name} name added succesfully!";
            }
        }
    }
}
