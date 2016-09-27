using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mockup_Project.DataServices.Repository
{
    public class user_informationRepository : IRepository<user_information>
    {
        DemoDBEntities Context;

        //Constructpr
        public user_informationRepository()
        {
            Context = new DemoDBEntities();
        }

        //Get all
        public IEnumerable<user_information> List
        {
            get
            {
                try
                {
                    return Context.user_information;
                }
                catch (Exception ex)
                {
                    Debug.WriteLine("Error: " + ex);
                    throw;
                }
            }
        }
        
        //Add
        public bool Add(user_information Entity)
        {
            try
            {
                Context.user_information.Add(Entity);
                Context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error: " + ex);
                return false;
            }
        }
        
        //Delete by ID
        public bool Delete(int selectedId)
        {
            try
            {
                var item = (from r in Context.user_information where r.id == selectedId select r).FirstOrDefault();
                Context.user_information.Remove(item);
                Context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error: " + ex);
                return false;
            }
        }

        //Update
        public bool Update(user_information Entity)
        {
            try
            {
                Context.Entry(Entity).State = System.Data.Entity.EntityState.Modified;
                Context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error: " + ex);
                return false;
            }
        }

        //Find by ID
        public user_information FindById(int Id)
        {
            try
            {
                var result = (from r in Context.user_information where r.id == Id select r).FirstOrDefault();
                return result;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error: " + ex);
                throw;
            }
        }

    }
}
