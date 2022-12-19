using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IPersonelService
    {
        int AddPersonel(Personel pers);
        int UpdatePersonel(Personel pers);   
        int DeletePersonel(Personel pers);
        Personel getPersonelByID(int id);
        List<Personel> GetAll(); 
    }
}
