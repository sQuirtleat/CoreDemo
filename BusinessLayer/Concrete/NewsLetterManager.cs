using BusinessLayer.Abstract;
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
	public class NewsLetterManager : INewsLetterService
	{
		INewsLetterDal _newsLetterDal;
		private EfNewsLetterRepository efNewsLetterRepository;

		public NewsLetterManager(EfNewsLetterRepository efNewsLetterRepository)
		{
			this.efNewsLetterRepository = efNewsLetterRepository;
		}

		public void AddNewsLetter(NewsLetter newsLetter)
		{
			_newsLetterDal.Insert(newsLetter);
		}
	}
}
