using System.Collections.Generic;
using Microsoft.AspNetCore.Builder;
using dotnet_6_minimal_wep_api.Models;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Route
app.MapGet("/api/v1/users", () => {
    async IAsyncEnumerable<User> StreamUserAsync()
    {
        for (var index = 1; index < 1001; index++)
        {
            yield return new User {
                    Id = index,
                    Age = 25,
                    First_Name = "First_Name" + index,
                    Last_Name = "Last_Name" + index,
                    Framework = "dotnet6 minimal"
                 }
            ;
        }
    }

    return StreamUserAsync();
});

// Run
app.Run();