
namespace Selenium2
{
    public static class Config
    {
        public static string BaseUrl = "https://rahulshettyacademy.com/loginpagePractise/";

        public static class Credentials
        {
            public static class Valid
            {
                public static string Username = "rahulshettyacademy";
                public static string Password = "learning";
            }

            public static class Invalid
            {
                public static string Username = "mila";
                public static string Password = "123";
                public static string Empty = "";
            }
        }


    }
}
