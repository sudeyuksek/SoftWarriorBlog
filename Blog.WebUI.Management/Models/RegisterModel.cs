namespace Blog.WebUI.Management.Models
{
    using Blog.Model;

    public class RegisterModel
    {
        public int RoleId = 2;
        public string Fullname { get; set; }
        public string Mail { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }

        public Author ToAuthor()
        {
            return new Author
            {
                RoleId = 2,
                Fullname = this.Fullname,
                Mail = this.Mail,
                Username = this.Username,
                Password = this.Password,
                IsActive = true,
                IsDeleted = false,
            };
        }

    }
}
