using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1._DAL.DomainClass;

namespace _1._DAL.IRepositories
{
    public interface IMauSacRepository
    {
        List<MauSac> getMauSacsFromDb();
        bool addMauSac (MauSac mauSac);
        bool updateMauSac (MauSac mauSac);
        bool deleteMauSac (MauSac mauSac);
        MauSac getMauSac (Guid id);

    }
}
