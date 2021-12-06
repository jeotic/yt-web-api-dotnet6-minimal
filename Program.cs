using dotnet_6_minimal_wep_api.Models;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var data = new List<User>(1000);

for (int index = 1; index < 1001; index++)
{
    data.Add(new User
    {
        Id = index,
        Age = 25,
        First_Name = "First_Name" + index,
        Last_Name = "Last_Name" + index,
        Framework = "dotnet6 minimala"
    }
    );
}

// Route
app.MapGet("/api/v1/users", () => data);

// Run
app.Run();