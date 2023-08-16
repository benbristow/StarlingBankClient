using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using StarlingBank.Exceptions;
using StarlingBank.Utilities;

namespace StarlingBank.Services;

public class KYCServices : IKYCServices
{
    private readonly IHttpClientFactory _clientFactory;
    private readonly IBaseServices _baseServices;


    public KYCServices(IHttpClientFactory clientFactory, IBaseServices baseServices)
    {
        _clientFactory = clientFactory;
        _baseServices = baseServices;
    }

    /// <summary>
    /// Get KYC result for an account holder
    /// </summary>
    /// <return>Returns the Models.KycResult response from the API call</return>
    public async Task<Models.KycResult> GetKycResultAsync(StarlingClient starlingClient)
    {
        //prepare query string for API call
        var queryBuilder = new StringBuilder();
        queryBuilder.Append("api/v2/kyc/result");
        //validate and preprocess url
        var queryUrl = APIHelper.GetUrl(starlingClient, queryBuilder);
        //append request with appropriate headers and parameters
        var headers = APIHelper.GetRequestHeaders(starlingClient);
        var request = new HttpRequestMessage(HttpMethod.Get, queryUrl);
        foreach (var header in headers) request.Headers.Add(header.Key, header.Value);
        //prepare the API call request to fetch the response
        var client = _clientFactory.CreateClient("StarlingBank");
        //invoke request and get response
        var response = await client.SendAsync(request);
        //handle errors defined at the API level
        await _baseServices.ValidateResponse(request, response);
        try
        {
            var content = await response.Content.ReadAsStringAsync();
            return APIHelper.JsonDeserialize<Models.KycResult>(content);
        }
        catch (Exception ex)
        {
            throw new APIException("Failed to parse the response: " + ex.Message, request, response);
        }
    }
}