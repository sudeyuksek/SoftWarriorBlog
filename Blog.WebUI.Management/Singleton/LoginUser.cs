namespace Blog.WebUI.Management.Singleton
{
    public class LoginUser
    {
        private LoginUser() { }
        private static LoginUser instance = null;
        public int AuthorId { get; set; }
        public string FullName { get; set; }

        public bool IsAdmin { get; set; }
        public static LoginUser Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LoginUser();
                }
                return instance;
            }
        }

    }
}
