using DB_finalproject.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_finalproject.DL
{
    class SupplierDL
    {
        private static List<Supplier> supplierList = new List<Supplier>();
        public void AddToList(Supplier s)
        {
            supplierList.Add(s);
        }
        public DataTable GetContactByNumber(string contact)
        {
            string query = $"SELECT * FROM suppliers WHERE contact = '{contact}'";
            return DatabaseHelper.Instance.GetDataTable(query);
        }
        public List<Supplier> GetList()
        {
            return supplierList;
        }
        public int Insert(Supplier s)
        {
            string query = $"INSERT INTO suppliers(name, email,contact, password_hash, role_id) VALUES('{s.Name}',' {s.Email}', '{s.Contact}', '{s.Password}' , {2} )";
            return DatabaseHelper.Instance.Update(query);
        }
        public int Update(Supplier s)
        {
            string query = $"Update suppliers SET name = '{s.Name}' , email = '{s.Email}' ,contact = '{s.Contact}' , password_hash = '{s.Password}' WHERE supplier_id = {s.SupplierId}";
            return DatabaseHelper.Instance.Update(query);
        }
        public int Delete(int id)
        {
            string query = $"DELETE FROM suppliers WHERE supplier_id = {id}";
            return DatabaseHelper.Instance.Update(query);
        }

        public DataTable GetALL()
        {

            return DatabaseHelper.Instance.GetDataTable("SELECT * FROM suppliers");

        }
        public void ClearList()
        {
            supplierList.Clear();
        }

        public bool Exists(string email)
        {
            string query = $"SELECT * FROM suppliers WHERE email = '{email}'";
            DataTable dt = DatabaseHelper.Instance.GetDataTable(query);
            return dt.Rows.Count > 0;
        }

    }
}
