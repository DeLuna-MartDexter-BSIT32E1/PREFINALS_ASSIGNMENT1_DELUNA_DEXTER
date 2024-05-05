//namespace AuthServer.Core
//{
//    public class User
//    {
//        public string Username { get; set; }
//        public string PasswordHash { get; set; }
//        // Other user properties
//    }
//}
using AuthServer.Core;

namespace AuthServer.Core
{
    public class User
    {
        public string? Username { get; set; }
        public string? Password { get; set; }

    }
}