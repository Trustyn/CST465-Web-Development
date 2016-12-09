using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace CST465_Project.ExtensionMethods
{
    public static class BlogRepositoryExtensions
    {
        public static List<BlogPost> GetListByContent(this IDataEntityRepository<BlogPost> lst, string a)
        {
            return lst.GetList().Where(p => p.Title.ToUpper().Contains(a.ToUpper()) || p.Content.ToUpper().Contains(a.ToUpper())).ToList();
        }
    }
}