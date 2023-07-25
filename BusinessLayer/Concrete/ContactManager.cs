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
	public class ContactManager:IContactService
	{
		IContactDal _contactdal;
		private EfContactRepository efContactRepository;

		public ContactManager(EfContactRepository efContactRepository)
		{
			this.efContactRepository = efContactRepository;
		}

		public void ContactAdd(Contact contact)
		{
			_contactdal.Insert(contact);
		}
	}
}
