using CupcakeMVC.Models;
using Microsoft.AspNetCore.Mvc;
namespace CupcakeMVC.ViewComponents
{
    //yapı olarak partial viewa benziyor en büyük farkı şu partial viewda biz veritabanı işlemlerinde(yani temel crud işlemlerinde)controller tarafında bağlıyız
    //yani partial viewda modele ulaşmak için önce controllera gitmem lazım ordan modela ulaşabilirm.
    // view componentle birlikte bu durum ortadan kalkıyor.!!view componentle ben direkt modele(arada contoleer olmadan)ulaşabiliyorum.

    public class CommentList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var commentValues = new List<UserComment>
            {
                new UserComment
                {
                    ID=1,
                    UserName="Sabrina"
                },
                new UserComment
                {
                    ID=2,
                    UserName="Elena"
                },
                 new UserComment
                {
                    ID=3,
                    UserName="Jack"
                }

            };
            return View(commentValues);
        }
    }
}
