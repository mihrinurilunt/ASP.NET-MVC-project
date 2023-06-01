using CupcakeMVC.Models;
namespace CupcakeMVC.ViewModel
{
    public class UserCommentViewModel
    {
        public  UserInfo ?userinfo { get; set; }
        public List< Comment>?comments {get; set; }
    }
}
