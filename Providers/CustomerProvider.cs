using CMS_Resort.Models;
using Microsoft.EntityFrameworkCore;

namespace CMS_Resort.Providers
{
	public class CustomerProvider : BaseProvider
	{
		public async Task<List<Customer>> GetAll()
		{
			return await db.Customers.ToListAsync();
		}

		public async Task<Customer> GetById(string id)
		{
			var customer = await db.Customers.Include(customer => customer.BookingReservations).Where(customer => customer.CustomerId.Equals(id)).FirstAsync();

			if (customer == null)
			{
				throw new Exception("bad request");
			}

			return customer;
		}

		public async Task<List<Customer>> GetByName(string fullname)
		{
			return await db.Customers.Where(customer => customer.CustomerFullname.ToLower().Contains(fullname.ToLower())).ToListAsync();
		}
	}
}
