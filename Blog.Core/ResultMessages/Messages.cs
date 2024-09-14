namespace Blog.Core.ResultMessages
{
    public static class Messages
    {
        public const string Succesfully_Added = "Succesfully Added!";
        public const string Succesfully_Updated = "Succesfully Updated!";
        public const string Succesfully_Deleted = "Succesfully Deleted!";
        public const string Failed_Operation = "Failed Operation!";
        public static class Article
        {
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
            public static string Update(string name)
            {
                return $"Category with {name} name updated succesfully!";
            }
            public static string Delete(string name)
            {
                return $"Category with {name} name deleted succesfully!";
            }
        }

        public static class User
        {
            public static string Add(string email)
            {
                return $"User with {email} email added succesfully!";
            }
            public static string Update(string email)
            {
                return $"User with {email} email updated succesfully!";
            }
            public static string Delete(string email)
            {
                return $"User with {email} email deleted succesfully!";

            }
        }
    }
}
