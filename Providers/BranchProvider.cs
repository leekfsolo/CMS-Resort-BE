using CMS_Resort.Models;
using Microsoft.EntityFrameworkCore;
using Npgsql;
using System.Data;

namespace CMS_Resort.Providers
{
	public class BranchProvider : BaseProvider
	{
		public async Task<List<Branch>> GetAll()
		{
			return await db.Branches.AsNoTracking().ToListAsync();
		}

		
		public DataSet GetByFunction(NpgsqlConnection _connection, object cursorVal)
		{
			try
			{
				DataSet actualData = new DataSet();

				string strSql = "fetch all from \"" + cursorVal + "\";";
				NpgsqlCommand cmd = new NpgsqlCommand(strSql, _connection);
				NpgsqlDataAdapter ada = new NpgsqlDataAdapter(cmd);
				ada.Fill(actualData);

				return actualData;

			}
			catch (Exception Exp)
			{
				throw new Exception(Exp.Message);
			}
		}
	}
}
