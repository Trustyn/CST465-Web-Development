using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CST465_Project
{
    
    public class BlogController : Controller
    {
        private IDataEntityRepository<BlogPost> _Repo;
        
        public BlogController()
        {
            _Repo = new BlogDBRepository();
        }

        public ActionResult Index()
        {
            List<BlogPost> posts = _Repo.GetList();
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
                BlogPost b = new BlogPost();
                b.ID = model.ID;
                b.Title = model.Title;
                b.Author = model.Author;
                b.Content = model.Content;
                _Repo.Save(b);
            }
            else
            {
                return View(model);
            }

            return RedirectToAction("Index");
        }

        
        public ActionResult Edit(int id)
        {
            
            return View(new BlogPostModel(_Repo.Get(id)));
        }

        [HttpPost]
        public ActionResult Edit(BlogPostModel model)
        {
            if(ModelState.IsValid)
            {
                BlogPost bp = _Repo.Get(model.ID);
                bp.Title = model.Title;
                bp.Content = model.Content;
                bp.Author = model.Author;
                _Repo.Save(bp);
            }
            return RedirectToAction("Index");
        }

        public ActionResult Show(int id)
        {
            return View(_Repo.Get(id));
        }
    }
}