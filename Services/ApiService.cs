
namespace BlazorApi2.Services;

public class ApiService{
  private readonly string _apiKey;
  public ApiService(string apiKey){
    _apiKey = apiKey;
  }

  public string GetApiKey(){
    return _apiKey;
  }
}