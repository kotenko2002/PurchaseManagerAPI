### Required for app to work
Installed [.NET 5.0](https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/sdk-5.0.408-windows-x64-installer)  
Installed [ASP.NET Core 5.0 Runtime](https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/runtime-aspnetcore-5.0.17-windows-x64-installer)

### How to download and run the app
Video instruction(1min): https://youtu.be/LasMPDeCI34
Write these 3 commands in a directory convenient for you:
```
git clone https://github.com/kotenko2002/PurchaseManagerAPI.git
cd PurchaseManagerAPI\PurchaseManagerAPI
dotnet run
```

### Endpoints
* Video explanation how I implemented JWT: https://youtu.be/t1S35S4ngns
* How to use JWT in postman: https://youtu.be/CzVR7uPl8Nk

You can use 2 domains:
* local: `localhost:5001`
* deployed: `purchase-manager-api.herokuapp.com` (if it doesn't work, wait 1-2m for the app to wake up😴)
<br/>

* AuthController
    * Registration: `{domain}/api/auth/register`
    * Login: `{domain}/api/auth/login`
* UserController
    * Get All Currencies: `{domain}/api/user/currencies`
    * Change Default Сurrency: `{domain}/api/user/changeCurrency`
* CategoryController
    * Add new category: `{domain}/api/category`
    * Get list of all categories: `{domain}/api/category/items`
* RecordController
    * Add new record: `{domain}/api/record`
    * Get list of user's records: `{domain}/api/record/items`
    * Get list of user's records by categoryId: `{domain}/api/record/items/{id}`

Example of GET request that does not require registration(you can try typing it in your browser right now):
`https://purchase-manager-api.herokuapp.com/api/user/currencies`
