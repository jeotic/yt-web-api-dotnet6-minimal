using System.Collections.Generic;
using Microsoft.AspNetCore.Builder;
using dotnet_6_minimal_wep_api.Models;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Route
app.MapGet("/api/v1/users", () => {
    var list = new List<User>(1000);
    for (int i = 1; i < 1001; i++) {
        list.Add(new User {
                Id = i,
                First_Name = "First_Name" + i,
                Last_Name = "Last_Name" + i,
                Framework = "dotnet6 minimal"
            }
        );
    }

    return list;
});

// Run
app.Run();