
using server.Domain;

var fullPath = $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}/article.html";
var content = File.ReadAllBytes(fullPath);

var ipfsClient = new Web3StorageClient();
var response = ipfsClient.UploadFile(content);

Console.WriteLine(response);