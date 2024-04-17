using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyContacts.Services
{
    class EFContactRepository : IContactsRepository
    {
        Contact_DBEntities db = new Contact_DBEntities();
        public bool Delete(int ContactID)
        {
            throw new NotImplementedException();
        }

        public bool Insert(string name, string family, string Mobile, int Age, string Address)
        {
            throw new NotImplementedException();
        }

        public DataTable Search(string parameter)
        {
            throw new NotImplementedException();
        }

        public DataTable SelectAll()
        {
            throw new NotImplementedException();
        }

        public DataTable SelectRow(int ContactID)
        {
            throw new NotImplementedException();
        }

        public bool Update(int ContactID, string name, string family, string Mobile, int Age, string Address)
        {
            throw new NotImplementedException();
        }
    }
}
