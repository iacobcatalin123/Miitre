using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace client_manager_maui.Models
{
    public class Repository
    {
        string _dbPath;
        private SQLiteConnection conn;

        public Repository(string dbPath)
        {
            _dbPath= dbPath;

        }

        public void Init()
        {
            conn = new SQLiteConnection(_dbPath );
            //if table doesnt exist
            if (!conn.TableMappings.Any(m => m.MappedType.Name == typeof(ProgramareModel).Name))
            {
                conn.CreateTable<ProgramareModel>();
            }
                
        }

        public List<ProgramareModel> GetAll()
        {
            Init();
            return conn.Table<ProgramareModel>().ToList();
        }

        public void Add(ProgramareModel model)
        {
            conn = new SQLiteConnection(_dbPath);
            conn.Insert(model);
        }

        public void Delete(ProgramareModel model)
        {
            conn = new SQLiteConnection(_dbPath);
            conn.Delete(model);
        }
    }
}
