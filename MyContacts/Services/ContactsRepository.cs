using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace MyContacts
{
    class ContactsRepository : IContactsRepository
    {
        private string connection = "Data Source=.;Initial Catalog=Contact_DB;Integrated Security=true;";
        public bool Delete(int ContactID)
        {
            throw new NotImplementedException();
        }

        public bool Insert(string name, string family, int Mobile, int Age, string Address)
        {
            throw new NotImplementedException();
        }

        public DataTable SelectAll()
        {
            string query = "Select * from MyContacts";
            SqlConnection conn = new SqlConnection(connection);
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataTable data = new DataTable();

            adapter.Fill(data);
            return data;
        }

        public DataTable SelectRow(int ContactID)
        {
            throw new NotImplementedException();
        }

        public bool Update(int ContactID, string name, string family, int Mobile, int Age, string Address)
        {
            throw new NotImplementedException();
        }
    }
}
