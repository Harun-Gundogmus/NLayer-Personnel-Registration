using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IRepository <T> 
    {
        public int Ekle(T p);
        public int Sil(T p);
        public int Guncelle(T p);
        public List<T> Listele();
        T IDyeGoreGetir(int id);
    }
}
