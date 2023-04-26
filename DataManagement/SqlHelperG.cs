using System;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;

namespace DataManagement;

public class SqlHelperG
{
    SqlCommand cmd;
    SqlDataAdapter reader;
    DataTable datatable1;
    DataTable datatable2;
    string connection = "Data Source=mssqlstud.fhict.local;Initial Catalog=dbi501511_bazaar;User ID=dbi501511_Bazaar;Password=Samocska";
    string query;

    public void AddProductToDB(string name, string category, string description, int threshold)
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
                cmd.Parameters.AddWithValue("@threshold", threshold);

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
    public void ChangeStockAmountFromDB(int id, int amount){

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
    public DataTable ReadProductsFromDB()
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
    public void DeleteProductFromDB(int id)
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
    public void CreateChangeToDB(int productId, DateTime dateTime, int change, int isRestock)
    {
        query = "INSERT INTO dbo.StockChange (productId, date, change, isRestock) VALUES (@productId, @date, @change, @isRestock)";
        try
        {
            using (SqlConnection conn = new SqlConnection(connection))
            {
                reader = new SqlDataAdapter();
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
    public DataTable ReadStockChangesFromDB()
    {
        query = "SELECT * FROM dbo.StockChange";
        try
        {
            using (SqlConnection conn = new SqlConnection(connection))
            {
                datatable1 = new DataTable();
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
    public DataTable ReadPeopleFromDB()
    {
        query = "SELECT * FROM dbo.Person";
        try
        {
            using (SqlConnection conn = new SqlConnection(connection))
            {

                datatable1 = new DataTable();
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
    public void UpdateEmployeePassword(int id, string password)
    {
        string query = "UPDATE Employee SET password = @password WHERE id = @id";
        try
        {
            using (SqlConnection conn = new SqlConnection(connection))
            {
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@password", password);
                command.Parameters.AddWithValue("@id", id);
                conn.Open();
                command.ExecuteNonQuery();
                conn.Close();
                command.Dispose();
            }
        }
        catch (Exception)
        {

            throw;
        }
    }
}