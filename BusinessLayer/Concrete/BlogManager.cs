using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
	public class BlogManager : IBlogService
	{
		IBLogDal _blogdal;

		public BlogManager(IBLogDal blogdal)
		{
			_blogdal = blogdal;
		}

		public void AddBlog(Blog blog)
		{
			throw new NotImplementedException();
		}

		public List<Blog> GetBlogListWithCategory()
		{
			return _blogdal.GetListWithCategory();
		}

		public Blog GetById(int id)
		{
			throw new NotImplementedException();
		}

		public List<Blog> GetBlogByID(int id) 
		{
			return _blogdal.GetListAll(x => x.BlogID == id);
		}

		public List<Blog> GetList()
		{
			return _blogdal.GetListAll();
		}

		public List<Blog> GetLast3Blog()
		{
			return _blogdal.GetListAll().Take(3).ToList();
		}

		public void RemoveBlog(Blog blog)
		{
			throw new NotImplementedException();
		}

		public void UpdateBlog(Blog blog)
		{
			throw new NotImplementedException();
		}

		public List<Blog> GetBlogListByWriter(int id)
		{
			return _blogdal.GetListAll(x=>x.WriterID == id);
		}
	}
}
