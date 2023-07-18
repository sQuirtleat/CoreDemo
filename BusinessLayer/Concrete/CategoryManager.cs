﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
	public class CategoryManager : ICategoryService
	{
		ICategoryDal _categoryDal;

		public CategoryManager(ICategoryDal categoryDal)
        {
			_categoryDal = categoryDal;
        }

		public void AddCategory(Category category)
		{

			_categoryDal.Insert(category);
		}

		public Category GetById(int id)
		{
			return _categoryDal.GetByID(id);
		}

		public List<Category> GetList()
		{
			return _categoryDal.GetListAll();
		}

		public void RemoveCategory(Category category)
		{
			_categoryDal.Delete(category);
		}

		public void UpdateCategory(Category category)
		{
			_categoryDal.Update(category);
		}
	}
}
