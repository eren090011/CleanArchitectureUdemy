using Microsoft.AspNetCore.Diagnostics;

namespace CleanArchitecturte.Api.Middleware;

public class ExceptionHandlingMiddleware{

    private readonly RequestDelegate _next;
    private readonly ILogger<ExceptionHandlingMiddleware> _logger;

    public ExceptionHandlingMiddleware(RequestDelegate next, ILogger<ExceptionHandlingMiddleware> logger)
    {
        _next=next;
        _logger= logger;
    }
    
    public async Task InvokeAsync(HttpContext context)
    {
        try{
            await _next(context);
        }catch(Exception exception){
            _logger.LogError(exception ,"Ocurrio una exception: {Messae}",exception.Message);

        }
    }

}