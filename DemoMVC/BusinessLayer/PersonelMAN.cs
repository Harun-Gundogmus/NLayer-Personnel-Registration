using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class PersonelMAN : IPersonelService
    {
        IPersonelDAL persdal;

        public PersonelMAN(IPersonelDAL persdal)
        {
            this.persdal = persdal;
        }
        public int AddPersonel(Personel pers)
        {
            return persdal.Ekle(pers);
        }

        public int DeletePersonel(Personel pers)
        {
           return persdal.Sil(pers);
        }

        public List<Personel> GetAll()
        {
            return persdal.Listele();
        }

        public Personel getPersonelByID(int id)
        {
            return persdal.IDyeGoreGetir(id);
        }

        public int UpdatePersonel(Personel pers)
        {
            return persdal.Guncelle(pers);
        }
    }
}
