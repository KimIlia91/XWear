# Domain Models

- [Domain Models](#domain-models)
	- [Catalog](#catalog)
		- [Register](#register)
			- [Register Request](#register-request)
			- [Register Response](#register-response)
		- [Login](#login)
			- [Login Request](#login-request)
			- [Login Response](#login-response)
	- [Account](#account)
		- [Get Account](#get-account)
			- [Get Account Request](#get-account-request)
			- [Get Account Response](#get-account-response)
		- [Update Account](#get-account)
			- [Update Account Request](#update-account-request)
			- [Update Account Response](#update-account-response)


## Catalog

```csharp
class Catalog
{
    
}
```

```json
[
  {
    "id": "3fa85f64-5717-4562-b3fc-2c963f66afa6",
    "name": "string",
    "categories": [
      {
        "name": "string",
        "product": {
          "id": "3fa85f64-5717-4562-b3fc-2c963f66afa6",
          "name": "string",
          "productSize": {
            "id": "3fa85f64-5717-4562-b3fc-2c963f66afa6",
            "price": 0
          },
          "imgUrl": "string",
          "isFavorit": true
        }
      }
    ]
  }
]
```
