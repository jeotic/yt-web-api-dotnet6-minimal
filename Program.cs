using System.Collections.Generic;
using dotnet_6_minimal_wep_api.Models;
using Microsoft.AspNetCore.Builder;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var cachedUsers = new List<User>(1000);

for (int index = 1; index < 1001; index++) {
    cachedUsers.Add(new User {
            Id = index,
            Age = 25,
            First_Name = "First_Name" + index,
            Last_Name = "Last_Name" + index,
            Framework = "dotnet6 minimala"
        }
    );
}

// Route
app.MapGet("/api/v1/users", () => cachedUsers);

// Run
app.Run();