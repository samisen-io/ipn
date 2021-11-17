using Dapper;
using System.Data;
using System.Data.Common;

namespace Server.Services
{
  public interface IDapper : IDisposable
  {
    DbConnection GetDbconnection();
    Task<T> Get<T>(string sp, DynamicParameters parms, CommandType commandType = CommandType.StoredProcedure);
    Task<List<T>> GetAll<T>(string sp, DynamicParameters parms, CommandType commandType = CommandType.StoredProcedure);
    Task<int> Execute(string sp, DynamicParameters parms, CommandType commandType = CommandType.StoredProcedure);
    Task<T> Insert<T>(string sp, DynamicParameters parms, CommandType commandType = CommandType.StoredProcedure);
    Task<T> Update<T>(string sp, DynamicParameters parms, CommandType commandType = CommandType.StoredProcedure);
  }
}