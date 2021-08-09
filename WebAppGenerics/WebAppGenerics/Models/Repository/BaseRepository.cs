using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppGenerics.Models.Repository
{
    public class BaseRepository<T> where T: BaseModel
    {
        static List<T> lista = new List<T>();
        static int id = 1;
        public void Create(T model) 
        {
            model.Id = id;
            lista.Add(model);
            id++;
        }

        public List<T> Read() 
        {
            return lista;
        }
        public T Read(int id) 
        {
            return lista.Find(e => e.Id == id);
        }
        public void Update(T model) 
        {
            int index = lista.FindIndex(e => e.Id == model.Id);
            if (index != -1) 
            { 
                lista[index] = model;
            }
        }
        public void Delete(int id) 
        {
            T model = Read(id);
            if (model != null) 
            {
                lista.Remove(model);
            }
        }
    }
}