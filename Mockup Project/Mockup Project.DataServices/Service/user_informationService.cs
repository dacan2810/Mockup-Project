using Mockup_Project.DataServices.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mockup_Project.DataServices.Service
{
    public class user_informationService
    {
        user_informationRepository user_informationRepository;

        //Constructor
        public user_informationService()
        {
            user_informationRepository = new user_informationRepository();
        }

        //List all
        public List<user_information> GetAll()
        {
            return user_informationRepository.List.ToList();
        }


        //Add
        public bool Add(user_information item)
        {
            bool result =  user_informationRepository.Add(item);
            if (result)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Update
        public bool Update(user_information item)
        {
            bool result = user_informationRepository.Update(item);
            if (result)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Delete
        public bool Delete(int id)
        {
            bool result = user_informationRepository.Delete(id);
            if (result)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Find by ID
        public user_information FindByID(int id)
        {
            user_information result = user_informationRepository.FindById(id);
            return result;
        }

    }
}
