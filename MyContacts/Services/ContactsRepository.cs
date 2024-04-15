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
            SqlConnection conn = new SqlConnection(connection);
            try
            {
                string query = "Delete from MyContacts where ContactID=@ID";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@ID", ContactID);
                conn.Open();
                command.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                conn.Close();
            }
        }


        public bool Insert(string name, string family, string Mobile, int Age, string Address)
        {
            SqlConnection conn = new SqlConnection(connection);
            try
            {
                string query = "Insert Into MyContacts (Name, Family, Mobile, Age, Address) values (@Name, @Family, @Mobile, @Age, @Address)";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Family", family);
                command.Parameters.AddWithValue("@Mobile", Mobile);
                command.Parameters.AddWithValue("@Age", Age);
                command.Parameters.AddWithValue("@Address", Address);
                conn.Open();
                command.ExecuteNonQuery();
                

                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        public DataTable Search(string parameter)
        {
            string query = "Select * from MyContacts where Name like @parameter or Family like @parameter";
            SqlConnection conn = new SqlConnection(connection);
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            adapter.SelectCommand.Parameters.AddWithValue("@parameter", "%" + parameter + "%");
            DataTable data = new DataTable();

            adapter.Fill(data);
            return data;
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
            string query = "Select * from MyContacts where ContactID=" + ContactID;
            SqlConnection conn = new SqlConnection(connection);
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataTable data = new DataTable();

            adapter.Fill(data);
            return data;
        }

        public bool Update(int ContactID, string name, string family, string Mobile, int Age, string Address)
        {
            SqlConnection conn = new SqlConnection(connection);
            try
            {
                string query = "Update MyContacts Set Name=@Name, Family=@Family, Mobile=@Mobile, Age=@Age, Address=@Address where ContactID=@ID";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@ID", ContactID); 
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Family", family);
                command.Parameters.AddWithValue("@Mobile", Mobile);
                command.Parameters.AddWithValue("@Age", Age);
                command.Parameters.AddWithValue("@Address", Address);
                conn.Open();
                command.ExecuteNonQuery();

                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
