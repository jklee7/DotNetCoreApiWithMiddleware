An example showing how to add middleware into an ASP.net core API.

Middleware is software that's assembled into an application pipeline to handle requests and responses. Each component:
- Chooses whether to pass the request to the next component in the pipeline.
- Can perform work before and after the next component in the pipeline is invoked.


In this example, we implement Middleware which reformats query strings to lowercase.

---

# Instructions
#### Packages
No additional packages are required. This is out of the box ASP.net Core MVC.

---
#### Things to note:

- The Middleware is encapsulated in its own class (in this case, the _QueryStringsToLowercaseMiddleware_ class)
- The Middleware class must implement the following methods:
    - ```QueryStringsToLowercaseMiddleware(RequestDelegate next) // the constructor```
    - ```public async Task InvokeAsync(HttpContext context) // where the actual work is done```
- The Middleware class is then inserted into the request pipeline in the Startup class, in the _Configure_ method using the following method:
    - ```app.UseMiddleware<QueryStringsToLowercaseMiddleware>();```
- To Test:
```
curl https://localhost:5001/api/v1/messages?name=MICHAEL
```
You should see the response:
```
Here's your message, michael!
```

---

#### Useful References

- [ASP.NET Core Middleware][1]


[1]: https://docs.microsoft.com/en-us/aspnet/core/fundamentals/middleware/?view=aspnetcore-2.1&tabs=aspnetcore2x