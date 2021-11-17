namespace server.Domain;

using Dapper;
using server.Models;
using Server.Services;
using System.Data;

public class userBusiness
{
  private readonly IDapper _dapper;

  public userBusiness(IDapper dapper)
  {
    _dapper = dapper;
  }
  public async Task<user> GetUserAsync(long id)
  {
    string sql = $"select * from ipn.user where id=@id";

    var dbparams = new DynamicParameters();
    dbparams.Add("@id", id, DbType.Int32);

    return await _dapper.Get<user>(sql, dbparams, commandType: CommandType.Text);
  }

}