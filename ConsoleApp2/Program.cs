


using System.ComponentModel.DataAnnotations;
using System.Net.Http;

[HttpPost("Invoice")]
public async Task<IActionResult> LoadInvoiceAsync(LoadDeliveriesRequest request, CancellationToken token)
{
    var requestLogId = await _requestLogService.CreateRequestLogAsync(request, HttpContext.Request.Body, token);
    var validation = await _validator.ValidateAsync(new Request { RequestMessage = request }, token);
    if (!validation.IsValid)
    {
        var validationResponse = ValidationResponse(validation);
        return GetResult(new[] { validationResponse });
    }
    var response = await _client.LoadDeliveriesAsync(request, token);
    var result = GetResult(new[] { response });
    await _requestLogService.AddInfoToRequestLogAsync(requestLogId, (int)response.StatusCode, response.Data, token);
    return result;
}


[HttpPost("CancelInvoice")]
public async Task<IActionResult> CancelInvoiceAsync(CancelDeliveriesRequest request, CancellationToken token)
{
    var requestLogId = await _requestLogService.CreateRequestLogAsync(request, HttpContext.Request.Body, token);
    var validation = await _validator.ValidateAsync(new Request { RequestMessage = request }, token);
    if (!validation.IsValid)
    {
        var validationResponse = ValidationResponse(validation);
        return GetResult(new[] { validationResponse });
    }
    var response = await _client.CancelDeliveriesAsync(request, token);
    var result = GetResult(new[] { response });
    await _requestLogService.AddInfoToRequestLogAsync(requestLogId, (int)response.StatusCode, response.Data, token);
    return result;
}
