using CupcakeMVC.Models;
using CupcakeMVC.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace CupcakeMVC.Controllers
{
    public class CommentController : Controller
    {
        public IActionResult Index()
        {
            var userinfo = new UserInfo { Id = 1, Name = "Sabrina", Surname = "Carpenter" };
     
            var comment = new List<Comment>()
            { 
                new Comment() {Comments="What a delicious cake!  "},
                new Comment(){Comments="Your coffees are incredible!"}
            };

            var vm = new UserCommentViewModel();
            vm.userinfo = userinfo;
            vm.comments = comment;

            return View(vm);
        }
    }
}
