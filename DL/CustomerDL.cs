using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DB_finalproject.Models;

namespace DB_finalproject.DL
{
    public class CustomerDL
    {
            private static List<Customer> customerList = new List<Customer>();

            public void AddToList(Customer c)
            {
                customerList.Add(c);
            }

            public List<Customer> GetList()
            {
                return customerList;
            }

            public void ClearList()
            {
                customerList.Clear();
            }

            public int Insert(Customer c)
            {
                string query = $"INSERT INTO customers(name, email, address, contact, password_hash, role_id) " +
                               $"VALUES('{c.Name}', '{c.Email}', '{c.Address}', '{c.Contact}', '{c.Password}', {3})";
                return DatabaseHelper.Instance.Update(query);
            }

            public int Update(Customer c)
            {
                string query = $"UPDATE customers SET name = '{c.Name}', email = '{c.Email}', address = '{c.Address}', " +
                               $"contact = '{c.Contact}', password_hash = '{c.Password}',role_id='{3}' WHERE customer_id = {c.CustomerId}";
                return DatabaseHelper.Instance.Update(query);
            }

            public int Delete(int id)
            {
                string query = $"DELETE FROM customers WHERE customer_id = {id}";
                return DatabaseHelper.Instance.Update(query);
            }

            public DataTable GetAll()
            {
                return DatabaseHelper.Instance.GetDataTable("SELECT * FROM customers");
            }

            public bool Exists(string email, string contact)
            {
                string query = $"SELECT * FROM customers WHERE email = '{email}' OR contact = '{contact}'";
                DataTable dt = DatabaseHelper.Instance.GetDataTable(query);
                return dt.Rows.Count > 0;
            }
        
    }
    
}

