using Newtonsoft.Json;
using RestSharp;
using RestSharp.Authenticators;
using RestSharp.Serializers.NewtonsoftJson;
using System.Text;

namespace server.Domain
{
  public class Web3StorageClient
  {
    readonly string APIUrl = "https://api.web3.storage/";
    readonly string APIKey = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiJkaWQ6ZXRocjoweGFEYzZjNWQ1Q0VjRTFBRGJDNjhiNTU5NDZDNjA2OTQ0MDkyNTBiMjgiLCJpc3MiOiJ3ZWIzLXN0b3JhZ2UiLCJpYXQiOjE2MzY3OTY5MjYwNTksIm5hbWUiOiJXZWIzSmFtIn0.BlHu2QNBPjOxDj0_UiO9puScmY5TmNddMBNK5zk3EVo";
    public string UploadFile(byte[] publishFile)
    {
      var client = new RestClient(APIUrl);

      client.UseNewtonsoftJson();

      client.AddDefaultHeader("Authorization", $"Bearer {APIKey}");

      var request = new RestRequest("/upload");

      request.RequestFormat = DataFormat.Json;
      request.Method = Method.POST;

      byte[] data = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(publishFile));
      request.AddParameter("application/octet-stream", data, ParameterType.RequestBody);

      var response = client.Execute(request);

      return response.Content;
    }

  }
}
