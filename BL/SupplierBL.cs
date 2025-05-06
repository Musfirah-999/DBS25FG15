using System;
using DB_finalproject.DL;
using DB_finalproject.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace DB_finalproject.BL
{
    class SupplierBL
    {
        SupplierDL dl = new SupplierDL();

        public void AddToList(string name, string email, string contact, string password)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new Exception("Name cannot be empty.");
            }

            if (string.IsNullOrWhiteSpace(email))
            {
                throw new Exception("Email cannot be empty.");
            }

            if (IsDuplicateContact(contact))
            {
                MessageBox.Show("This contact number is already in use.");
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                throw new Exception("Password cannot be empty.");
            }
            if (dl.Exists(password))
            {
                throw new Exception("Password already exists.");
            }
            if (dl.Exists(email))
            {
                throw new Exception("Email already exists.");
            }
            if (!Regex.IsMatch(contact, @"^\d{11}$"))
            {
                throw new Exception("Contact number must be exactly 11 digits.");
              
            }


            Supplier s = new Supplier { Name = name, Email = email, Contact = contact, Password = password };
            dl.AddToList(s);

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
        public bool IsDuplicateContact(string contact)
        {
            DataTable dt = new SupplierDL().GetContactByNumber(contact);
            return dt.Rows.Count > 0;
        }
        public void Update(int id, string name, string email, string contact, string password )
        {
            if (string.IsNullOrWhiteSpace(password))
            {
                throw new Exception("Password cannot be empty.");
            }
            if (dl.Exists(password))
            {
                throw new Exception("Password already exists.");
            }
            if (dl.Exists(email))
            {
                throw new Exception("Email already exists.");
            }
      
            if (!Regex.IsMatch(contact, @"^\d{11}$"))
            {
                MessageBox.Show("Contact number must be exactly 11 digits.");
               return;
            }

            if (IsDuplicateContact(contact))
            {
                MessageBox.Show("This contact number is already in use.");
            }
            dl.Update(new Supplier { SupplierId = id, Name = name, Contact = contact, Email = email, Password = password });

        }
        public void delete(int id)
        {
            dl.Delete(id);
        }
        public DataTable LoadFromDB()
        {
            return dl.GetALL();
        }
    }
}
