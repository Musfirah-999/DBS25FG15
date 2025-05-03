using DB_finalproject.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_finalproject.DL
{
    class MedicineDL
    {
        private static List<Medicine> medicineList = new List<Medicine>();

        public void AddToList(Medicine m)
        {
            medicineList.Add(m);
        }
        public List<Medicine> GetList()
        {
            return medicineList;
        }
        public void ClearList()
        {
            medicineList.Clear();
        }

        public int Insert(Medicine m)
        {
            string query = $"INSERT INTO medicines(name, price) VALUES('{m.Name}', {m.Price})";
            return DatabaseHelper.Instance.Update(query);
        }

        public int Update(Medicine m)
        {
            string query = $"UPDATE medicines SET name = '{m.Name}',price = {m.Price} WHERE medicine_id = {m.MedicineId}";
            return DatabaseHelper.Instance.Update(query);
        }

        public int Delete(int id)
        {
            string query = $"DELETE FROM medicines WHERE medicine_id = {id}";
            return DatabaseHelper.Instance.Update(query);
        }
        public DataTable GetALL()
        {
            return DatabaseHelper.Instance.GetDataTable("SELECT * FROM medicines");

        }
        public bool Exists(string name)
        {
            string query = $"SELECT * FROM medicines WHERE name = '{name}'";
            DataTable dt = DatabaseHelper.Instance.GetDataTable(query);
            return dt.Rows.Count > 0;
        }
    }
}
