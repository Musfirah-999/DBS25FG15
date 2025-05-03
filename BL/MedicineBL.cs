using DB_finalproject.DL;
using DB_finalproject.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_finalproject.BL
{
    class MedicineBL
    {
        MedicineDL dl = new MedicineDL();
        public void AddToList(string name, string pricestr)
        {
            if(string.IsNullOrWhiteSpace(name))
            {
                throw new Exception("Name cannot be empty.");
            } 
            if(!decimal.TryParse(pricestr, out decimal price))
            {
                throw new Exception("Price must be a number.");
            }
            if (dl.Exists(name))
            {
                throw new Exception("Medicine already exists.");
            }

            Medicine m = new Medicine { Name = name, Price = price };
            dl.AddToList(m);

        }
        public List<Medicine> GetList()
        {
            return dl.GetList();
        }
        public void SaveAll()
        {
            foreach (var m in dl.GetList())
            {
                if (!dl.Exists(m.Name))
                {
                    dl.Insert(m);
                }
            
            }
            dl.ClearList();
        }
        public void Update(int id, string name, string priceStr)
        {
            if (!decimal.TryParse(priceStr, out decimal price))
                throw new Exception("Invalid price.");

            dl.Update(new Medicine { MedicineId = id, Name = name, Price = price });
        }
        public void Delete(int id)
        {
            dl.Delete(id);
        }

        public DataTable LoadFromDB()
        {
            return dl.GetALL();
        }

    }
}
