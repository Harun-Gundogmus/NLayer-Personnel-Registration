using DataAccessLayer.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        Context c = new Context();
        DbSet<T> obj;
        public Repository()
        {
            obj = c.Set<T>();
        }
        public int Ekle(T p)
        {
            obj.Add(p);
            return c.SaveChanges();
        }

        public int Guncelle(T p)
        {
            obj.Update(p);
            return c.SaveChanges();
        }

        public T IDyeGoreGetir(int id)
        {
            return obj.Find(id);
        }

        public List<T> Listele()
        {
            return obj.ToList();
        }

        public int Sil(T p)
        {
            obj.Remove(p);
            return c.SaveChanges();
        }
    }
}
