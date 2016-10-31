using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CST465_Project.Controllers
{
    
    public class BlogController : Controller
    {
        private IDataEntityRepository<BlogPost> _Repo;
        
        public BlogController()
        {
            BlogDBRepository _Repo = new BlogDBRepository();
        }

        public ActionResult Index()
        {
            List<BlogPost> posts = new List<BlogPost>();
            return View(posts);
        }
        
        public ActionResult Add()
        {
            BlogPostModel model = new BlogPostModel();
            return View(model);
        }

        [HttpPost]
        public ActionResult Add(BlogPostModel model)
        {
            if(ModelState.IsValid)
            {
                
            }
            else
            {
                return View(model);
            }

            return RedirectToAction("Index");
        }

        //public ActionResult Edit(int id)
        //{

        //}

        //public ActionResult Edit(BlogPostModel model)
        //{

        //}
    }
}