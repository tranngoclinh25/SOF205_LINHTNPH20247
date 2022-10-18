using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1._DAL.DomainClass;

namespace _1._DAL.IRepositories
{
    public interface INsxRepository
    {
        List<Nsx> getNsxesFromDb();
        bool addNsx (Nsx nsx);
        bool updateNsx (Nsx nsx);
        bool deleteNsx (Nsx nsx);
        Nsx getNsx (Guid id);

    }
}
