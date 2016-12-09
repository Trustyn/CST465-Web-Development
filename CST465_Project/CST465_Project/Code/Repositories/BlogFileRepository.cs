using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Web.Script.Serialization;
using System.Web;
using System.Linq;

namespace CST465_Project
{
    public class BlogFileRepository : IDataEntityRepository<BlogPost>
    {
        public BlogPost Get(int id)
        {
            BlogPost post = GetList().Find(f => f.ID == id);
 
            return post;
        }

        public void Save(BlogPost entity)
        {
            List<BlogPost> blogPosts = GetList();
            if(entity.ID == 0)
            {
                if (blogPosts.Count == 0)
                {
                    entity.ID = 1;
                }
                else
                {
                    entity.ID = blogPosts.Max(m => m.ID) + 1;
                }
                    blogPosts.Add(entity);
            }
            else
            {
                BlogPost post = GetList().Find(f => f.ID == entity.ID);
                post.Author = entity.Author;
                post.Content = entity.Content;
                post.Title = entity.Title;
                post.Timestamp = entity.Timestamp;       
            }
            string json = "";
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            json = serializer.Serialize(blogPosts);
            using (StreamWriter writer = new StreamWriter(HttpContext.Current.Server.MapPath("/App_Data/Blog.txt")))
            {
                writer.Write(json);
            }
        }

        public List<BlogPost> GetList()
        {
            List<BlogPost> posts = new List<BlogPost>();

            string json = "";
            using (StreamReader reader = new StreamReader(HttpContext.Current.Server.MapPath("/App_Data/Blog.txt")))
            {
                json = reader.ReadToEnd();
            }
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            posts = serializer.Deserialize<List<BlogPost>>(json);
            return posts;
        }
    }
}