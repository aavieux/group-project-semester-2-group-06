using System.Data;
using System.Data.SqlClient;
using System.Reflection;

namespace DataManagement;

public class SqlHelperG
{
    SqlCommand cmd;
    SqlDataAdapter reader;
    DataTable datatable1;
    DataTable datatable2;
    string connection = "Data Source=mssqlstud.fhict.local;Initial Catalog=dbi501511_bazaar;User ID=dbi501511_Bazaar;Password=Samocska";
    string query;

    public void AddProduct(string name, string category, string description)
    {
        query = "INSERT INTO dbo.Product (name, amount, category, description) VALUES (@name, @amount, @category, @description)";
        try
        {
            using (SqlConnection conn = new SqlConnection(connection))
            {
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@amount", 0);
                cmd.Parameters.AddWithValue("@category", category);
                cmd.Parameters.AddWithValue("@description", description);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }
        catch (Exception)
        {

            throw;
        }
    }
    public void RemoveProduct(int id)
    {
        query = "Delete from dbo.Product where id=@id";
        try
        {
            using (SqlConnection conn = new SqlConnection(connection))
            {
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }
        catch (Exception)
        {

            throw;
        }
    }
    public void IncreaseStock(int id, int amount)
    {
        query = "UPDATE dbo.Product SET amount = @amount WHERE id=@id";
        try
        {
            using (SqlConnection conn = new SqlConnection(connection))
            {
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@amount", amount);
                cmd.Parameters.AddWithValue("@id", id);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }
        catch (Exception)
        {

            throw;
        }
    }

}