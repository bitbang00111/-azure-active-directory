using System;
using Microsoft.Identity.Client;
using static System.Console;

string clientId = "479982e2-61b5-49f7-2597-cde3d12010d0";
string tenant = "8a0ad250-3d7d-1016-9c0b-1d580cb0af2c";
string[] scopes = { "user.read" };

var myApp = PublicClientApplicationBuilder.Create(clientId)
    .WithRedirectUri("http://localhost")
    .WithAuthority(AzureCloudInstance.AzurePublic, tenant)
    .Build();

var result = await myApp.AcquireTokenInteractive(scopes)
    .ExecuteAsync();

WriteLine(result.AccessToken);
WriteLine("Azure user: " + result.Account.Username);


