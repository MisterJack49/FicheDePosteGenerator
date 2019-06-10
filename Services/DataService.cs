using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FicheDePosteGenerator.Services
{
    public class DataService<T> where T : class, new()
    {
        protected readonly LiteDatabase database;
        public DataService()
        {
            database = new LiteDatabase("Resources/GeneratorDatabase.db");
        }

        public T Get() => database.GetCollection<T>().FindAll().FirstOrDefault() ?? new T();

        public bool Set(T obj) => database.GetCollection<T>().Upsert(obj);
    }
}
