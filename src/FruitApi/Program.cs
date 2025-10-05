using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Prometheus;
using System;
using System.Threading.Tasks;

var builder = WebApplication.CreateBuilder(args);

builder.Services.UseHttpClientMetrics();

var app = builder.Build();

app.UseMetricServer();
app.UseHttpMetrics();

app.MapGet("/GetFruit", async () => await Result());
app.MapPost("/PostFruit", async () => await Result());

app.Run();

static async Task<IResult> Result()
{
    var delay = Random.Shared.Next(1000);
    await Task.Delay(delay);
    return delay < 200 ? Results.Unauthorized() : Results.Ok();
}
