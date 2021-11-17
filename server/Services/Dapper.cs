using Dapper;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace Server.Services
{
  public class Dapper : IDapper
  {
    private readonly IConfiguration _config;
    private string Connectionstring = "DefaultConnection";

    public Dapper(IConfiguration config)
    {
      _config = config;
    }
    public void Dispose()
    {

    }

    public Task<int> Execute(string sp, DynamicParameters parms, CommandType commandType = CommandType.StoredProcedure)
    {
      throw new NotImplementedException();
    }

    public async Task<T> Get<T>(string sp, DynamicParameters parms, CommandType commandType = CommandType.Text)
    {
      using IDbConnection db = new SqlConnection(_config.GetConnectionString(Connectionstring));
      var result = await db.QueryAsync<T>(sp, parms, commandType: commandType);
      return result != null ? result.FirstOrDefault() : default;
    }

    public async Task<List<T>> GetAll<T>(string sp, DynamicParameters parms, CommandType commandType = CommandType.StoredProcedure)
    {
      using IDbConnection db = new SqlConnection(_config.GetConnectionString(Connectionstring));
      var result = await db.QueryAsync<T>(sp, parms, commandType: commandType);
      return result.ToList();
    }

    public DbConnection GetDbconnection()
    {
      return new SqlConnection(_config.GetConnectionString(Connectionstring));
    }

    public async Task<T> Insert<T>(string sp, DynamicParameters parms, CommandType commandType = CommandType.StoredProcedure)
    {
      T result;
      using IDbConnection db = new SqlConnection(_config.GetConnectionString(Connectionstring));
      try
      {
        if (db.State == ConnectionState.Closed)
          db.Open();

        using var tran = db.BeginTransaction();
        try
        {
          var dbResult = await db.QueryAsync<T>(sp, parms, commandType: commandType, transaction: tran);
          result = dbResult.FirstOrDefault();
          tran.Commit();
        }
        catch (Exception)
        {
          tran.Rollback();
          throw;
        }
      }
      catch (Exception)
      {
        throw;
      }
      finally
      {
        if (db.State == ConnectionState.Open)
          db.Close();
      }

      return result;
    }

    public async Task<T> Update<T>(string sp, DynamicParameters parms, CommandType commandType = CommandType.StoredProcedure)
    {
      T result;
      using IDbConnection db = new SqlConnection(_config.GetConnectionString(Connectionstring));
      try
      {
        if (db.State == ConnectionState.Closed)
          db.Open();

        using var tran = db.BeginTransaction();
        try
        {
          var dbResult = await db.QueryAsync<T>(sp, parms, commandType: commandType, transaction: tran);
          result = dbResult.FirstOrDefault();
          tran.Commit();
        }
        catch (Exception)
        {
          tran.Rollback();
          throw;
        }
      }
      catch (Exception)
      {
        throw;
      }
      finally
      {
        if (db.State == ConnectionState.Open)
          db.Close();
      }

      return result;
    }
  }
}