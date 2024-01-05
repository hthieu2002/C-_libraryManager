namespace DAL
{
    internal class config
    {
        internal static string ConnectionString = "Data Source=SERVER;Initial Catalog=LibraryMino;User ID=sa;Password=;";
    }
<<<<<<< HEAD
    public class configUrl
    {
        public static string Url = "D:\\2023-2024 (2)\\C#\\Library\\Library_WindowsForms\\public\\ImageStatistics\\";

       // public static string UrlImageUser = "D:\\2023-2024 (2)\\C#\\Library\\Library_WindowsForms\\public\\admin\\user.jpg";
        public static string uploadImage = "D:\\2023-2024 (2)\\C#\\Library\\Library_WindowsForms\\public\\ImageUser\\";
        public string GetImagePath(string imageName)
        {
            return Path.Combine(Url, imageName);
        }

        public string GetImage(string imageName)
        {
            return Path.Combine(uploadImage, imageName);
        }
    }
}
=======
}
>>>>>>> 47a306889b63ae7f486a153ecb276e689ac2d0ed
