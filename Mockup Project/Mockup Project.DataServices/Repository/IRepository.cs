using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mockup_Project.DataServices.Repository
{
    public interface IRepository<Entity>
    {
        IEnumerable<Entity> List { get; }
        bool Add(Entity entity);
        bool Delete(int id);
        bool Update(Entity entity);
        Entity FindById(int Id);
    }
}
