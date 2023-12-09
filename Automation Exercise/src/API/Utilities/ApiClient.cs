using TestAutomationPractice.src.API.Model;
using TestAutomationPractice.src.API.Utilities;
using RestSharp;

public class ApiClient
{
    private RestClient restClient;
    public ApiClient()
    {
        restClient = new RestClient(ConfigurationHelper.BaseUrl); 
    }

    private ApiResponse<TResponse> SendRequest<TRequest, TResponse>(ApiRequest<TRequest> request)
    {
        var restRequest = CreateRestRequest(request);
        var response = restClient.Execute<TResponse>(restRequest);
        return new ApiResponse<TResponse>
        {
            StatusCode = (int)response.StatusCode,
            Data = response.Data,
            Message = response.Content
        };
    }
    private RestRequest CreateRestRequest<TRequest>(ApiRequest<TRequest> apiRequest)
    {
        var restRequest = new RestRequest(apiRequest.Endpoint, apiRequest.Method);
        if (apiRequest.Method != Method.Get)
        {
            if (apiRequest.Data != null)
            {
                restRequest.AddJsonBody((object)apiRequest.Data);
            }
        }
        if (apiRequest.Method == Method.Delete && apiRequest.Parameter != null)
        {
            foreach (var parameter in apiRequest.Parameter)
            {
                restRequest.AddParameter(parameter.Key, parameter.Value);
            }
        }
        else if (apiRequest.Method == Method.Get && apiRequest.Parameter != null)
        {
            foreach (var parameter in apiRequest.Parameter)
            {
                restRequest.AddQueryParameter(parameter.Key, parameter.Value);
            }
        }
        else if (apiRequest.Parameter != null)
        {
            foreach (var parameter in apiRequest.Parameter)
            {
                restRequest.AddParameter(parameter.Key, parameter.Value);
            }
        }
        return restRequest;
    }
    public ApiResponse<TResponse> Get<TResponse>(string endpoint, Dictionary<string, string> parameters = null)
    {
        var request = new ApiRequest<object>
        {
            Endpoint = endpoint,
            Method = Method.Get,
            Parameter = parameters
        };
        return SendRequest<object, TResponse>(request);
    }
    public ApiResponse<TResponse> Post<TRequest, TResponse>(string endpoint, TRequest data, Dictionary<string, string> parameters = null)
    {
        var request = new ApiRequest<TRequest>
        {
            Endpoint = endpoint,
            Method = Method.Post,
            Data = data,
            Parameter = parameters
        };
        return SendRequest<TRequest, TResponse>(request);
    }

    public ApiResponse<TResponse> Put<TRequest, TResponse>(string endpoint, TRequest data, Dictionary<string, string> parameters = null)
    {
        var request = new ApiRequest<TRequest>
        {
            Endpoint = endpoint,
            Method = Method.Put,
            Data = data,
            Parameter = parameters
        };
        return SendRequest<TRequest, TResponse>(request);
    }

    public ApiResponse<TResponse> Delete<TResponse>(string endpoint, Dictionary<string, string> parameters = null)
    {
        var request = new ApiRequest<object>
        {
            Endpoint = endpoint,
            Method = Method.Delete,
            Parameter = parameters
        };
        return SendRequest<object, TResponse>(request);
    } 
}