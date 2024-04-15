using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace MyContacts
{
    interface IContactsRepository
    {
        DataTable SelectAll();
        DataTable SelectRow(int ContactID);
        DataTable Search(string parameter);
        bool Insert(string name, string family, string Mobile, int Age, string Address);
        bool Update(int ContactID, string name, string family, string Mobile, int Age, string Address);
        bool Delete(int ContactID);
    }
}
