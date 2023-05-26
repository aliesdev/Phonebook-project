using MyProject.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace MyProject.Services
{
    class ContactsRepository : IContactsRepository
    {
        private string conectionString = "Data Source=.;Initial Catalog=My-DB;Integrated Security=true";
        public bool Delete(int contactId)
        {
            SqlConnection connection = new SqlConnection(conectionString);
            try
            {

                string query = "Delete From MyContacts where ContactID=@ID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID", contactId);
                connection.Open();
                command.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                connection.Close();
            }
        }

        public bool Insert(string name, string family, string mobile, string email, int age, string address)
        {
            SqlConnection connection = new SqlConnection(conectionString);
            try
            {

                string query = "Insert Into MyContacts (Name,Family,Mobile,Email,Age,Address) values (@Name,@Family,@Mobile,@Email,@Age,@Address)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Family", family);
                command.Parameters.AddWithValue("@Mobile", mobile);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Age", age);
                command.Parameters.AddWithValue("@Address", address);
                connection.Open();
                command.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                connection.Close();

            }
        }


        public DataTable search(string parameter)
        {
            string query = "select * from MyContacts where Name like @parameter or Family like @parameter";
            SqlConnection connection = new SqlConnection(conectionString);
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            adapter.SelectCommand.Parameters.AddWithValue("@parameter", "%" + parameter + "%");
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;
        }


        public DataTable selectAll()
        {
            string query = "select * from MyContacts";
            SqlConnection connection = new SqlConnection(conectionString);
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;
        }

        public DataTable selectRow(int contactId)
        {
            string query = "select * from MyContacts where ContactID=" + contactId;
            SqlConnection connection = new SqlConnection(conectionString);
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;
        }

        public bool Update(int contactId, string name, string family, string mobile, string email, int age, string address)
        {
            SqlConnection connection = new SqlConnection(conectionString);
            try
            {

                string query = "Update MyContacts set Name=@Name,Family=@Family,Mobile=@Mobile,Email=@Email,Age=@Age,Address=@Address where ContactID=@ID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID", contactId);
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Family", family);
                command.Parameters.AddWithValue("@Mobile", mobile);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Age", age);
                command.Parameters.AddWithValue("@Address", address);
                connection.Open();
                command.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                connection.Close();

            }
        }
    }
}
