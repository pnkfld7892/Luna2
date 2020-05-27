using Luna2.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luna2.DataAccess.DataAccess
{
    public class AnimalData
    {
        public List<AnimalModel> GetAllAnimals()
        {
            SqlDataAccess sql = new SqlDataAccess();
            var output = sql.LoadData<AnimalModel, dynamic>("dbo.spGetAllAnimals", new { });
            return output;
        }

        public List<AnimalPersonModel> GetAllAnimalPersons()
        {
            SqlDataAccess sql = new SqlDataAccess();
            var output = sql.LoadData<AnimalPersonModel, dynamic>("dbo.spGetAllAnimalPersons", new { });
            return output;
        }

        public AnimalModel GetAnimalById(int id)
        {
            SqlDataAccess sql = new SqlDataAccess();
            return sql.LoadData<AnimalModel, dynamic>("dbo.spGetAnimalById", new { Id = id }).FirstOrDefault();
        }
    }
}
