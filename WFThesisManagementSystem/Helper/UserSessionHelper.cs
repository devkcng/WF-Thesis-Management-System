namespace WFThesisManagementSystem.Helper
{
    public class UserSessionHelper
    {
        private static UserSessionHelper instance;

        private UserSessionHelper()
        {
        }

        public static UserSessionHelper Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new UserSessionHelper();
                }
                return instance;
            }
        }

        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Role { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
    }
}
