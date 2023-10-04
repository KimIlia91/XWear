# XWaer API

- [Xwear API](#xwear-api)
	- [Auth](#auth)
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

## Auth

### Register

```js
POST {{host}}/api/auth/register
```

#### Register Request

```json
{
	"firstName": "Daniyar",
	"lastName": "Daniyarov",
	"email": "testuser@test.com",
	"phone": "+996709123123",
	"password": "TestUser123!",
	"confirmPassword": "TestUser123!"
}
```

#### Register Response

```json
{
	"email": "testuser@test.com",
	"accessToken": "eyJhd...z9dqcnXoY",
	"refreshToken": "eyJhd...z9dqcnXoY"
}
```

### Login

```js
POST {{host}}/api/auth/login
```

#### Login Request

```json
{
	"email": "testuser@test.com",
	"password": "TestUser123!"
}
```

#### Login Response

```json
{
	"email": "testuser@test.com",
	"accessToken": "eyJhbG...lel5kikgo",
	"refreshToken": "eyJhbG...lel5kikgo",
}
```

## Account

### Get Account

```js
GET {{host}}/api/account
```

#### Get Account Request

#### Get Account Response

```json
{
	"firstName": "Daniyar",
	"lastName": "Daniyarov",
	"email": "testuser@test.com",
	"phone": "+996709123123"
}
```

### Update Account

```js
PUT {{host}}/api/account
```

#### Update Account Request

```json
{
	"firstName": "Daniyar",
	"lastName": "Daniyarov",
	"email": "testuser@test.com",
	"phone": "+996709123123"
}
```

#### Update Account Response

```json
200 Ok
```

