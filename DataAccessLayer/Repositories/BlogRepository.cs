using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
	public class BlogRepository : IBLogDal
	{
		Context c = new Context();
		public void AddBlog(Blog blog)
		{
			c.Blogs.Add(blog);
			c.SaveChanges();
		}

		public void DeleteBlog(Blog blog)
		{
			c.Blogs.Remove(blog);
			c.SaveChanges();
		}

		public Blog GetById(int id)
		{
			return c.Blogs.Find(id);
		}

		public List<Blog> ListAllBlog()
		{
			return c.Blogs.ToList();
		}

		public void UpdateBlog(Blog blog)
		{
			c.Blogs.Update(blog);
			c.SaveChanges();
		}
	}
}
