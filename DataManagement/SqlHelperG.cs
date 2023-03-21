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
    public void ChangeStockAmount(int id, int amount)
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
    public DataTable ReadProducts()
    {
        datatable1 = new DataTable();
        query = "SELECT * FROM dbo.Product";
        try
        {
            using (SqlConnection conn = new SqlConnection(connection))
            {
                reader = new SqlDataAdapter();
                cmd = new SqlCommand(query, conn);
                conn.Open();
                reader.SelectCommand = cmd;
                reader.Fill(datatable1);
                conn.Close();
                reader.Dispose();
                return datatable1;
            }
        }
        catch (Exception)
        {

            throw;
        }
    }
    public void DeleteProduct(int id)
    {
        query = "DELETE FROM dbo.Product WHERE id = @id";
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
    public void CreateChange(int productId, DateTime dateTime, int change, int isRestock)
    {
        query = "INSERT INTO dbo.StockChange (productId, date, change, isRestock) VALUES (@productId, @date, @change, @isRestock)";
        try
        {
            using (SqlConnection conn = new SqlConnection(connection))
            {
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@productId", productId);
                cmd.Parameters.AddWithValue("@date", dateTime);
                cmd.Parameters.AddWithValue("@change", change);
                cmd.Parameters.AddWithValue("@isRestock", isRestock);
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