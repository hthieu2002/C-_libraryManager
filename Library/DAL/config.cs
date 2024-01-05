namespace DAL
{
    internal class config
    {
        internal static string ConnectionString = "Data Source=SERVER;Initial Catalog=LibraryMino;User ID=sa;Password=;";
    }
<<<<<<< HEAD
    public class configUrl
    {
        public static string Url = "Url\\ImageStatistics\\";

       // public static string UrlImageUser = "Url\\public\\admin\\user.jpg";
        public static string uploadImage = "Url\\public\\ImageUser\\";
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
