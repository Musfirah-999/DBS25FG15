using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using DB_finalproject.DL;
using DB_finalproject.Models;

namespace DB_finalproject.BL
{
    public class CustomerBL
    {
        CustomerDL dl = new CustomerDL();

        public void AddToList(string name, string email, string address, string contact, string password)
        {
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(contact) || string.IsNullOrWhiteSpace(password))
            {
                throw new Exception("Name, Email, Contact, and Password are required.");
            }

            if (dl.Exists(email, contact))
            {
                throw new Exception("Email or Contact already exists.");
            }

            string hashedPassword = HashPassword(password);

            Customer c = new Customer
            {
                Name = name,
                Email = email,
                Address = address,
                Contact = contact,
                Password = hashedPassword
            };

            dl.AddToList(c);
        }

        public void SaveAll()
        {
            foreach (var c in dl.GetList())
            {
                if (!dl.Exists(c.Email, c.Contact))
                {
                    dl.Insert(c);
                }
            }
            dl.ClearList();
        }

        public void Update(int id, string name, string email, string address, string contact, string password)
        {
            string hashedPassword = HashPassword(password);
            Customer c = new Customer
            {
                CustomerId = id,
                Name = name,
                Email = email,
                Address = address,
                Contact = contact,
                Password = hashedPassword
            };
            dl.Update(c);
        }

        public void Delete(int id)
        {
            dl.Delete(id);
        }

        public DataTable LoadFromDB()
        {
            return dl.GetAll();
        }

        private string HashPassword(string password)
        {
            using (SHA256 sha = SHA256.Create())
            {
                byte[] bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach (var b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}
