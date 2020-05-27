using Luna2.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luna2.DataAccess.DataAccess
{
    public class PersonData
    {
        public List<PersonModel> GetAllPersons()
        {
            SqlDataAccess sql = new SqlDataAccess();
            var output = sql.LoadData<PersonModel, dynamic>("dbo.spGetAllPersons", new { });
            return output;
        }
    }
}
