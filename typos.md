# Typos for *Pro ASP.NET Core 6*

This file contains smaller errors that are unlikely to prevent the code examples from working and which I will correct in the next edition of the book. See [this](errata.md) file for mistakes that prevent the code examples from working as expected.

---


**Chapter 3**

Figure 3-7 should show a value in the `Name` field, as described in the text.

(Thanks to Ian Kode for reporting this problem)

---

Figure 3-11 should show a drop-down list. The problem is caused by this element in `Listing 3-23`:

    <select asp-for="WillAttend" class="form-control">

which should be:

    <select asp-for="WillAttend" class="form-select">

(Thanks to Ian Kode and Tom Calupca for reporting this problem)

---

**Chapter 4**

The text that follows Listing 4-8 says:

> The new browser window can be displayed by setting the launchBrowser property shown

It should be:

> The new browser window can be **disabled** by setting the launchBrowser property shown

(Thanks to Abdul W Yousufzai for reporting this problem)

---

On page 68, this text:

>   If you are using Visual Studio, add a file named `MyClass.cs` to the `MyProject`

shoudl be:

> If you are using Visual Studio ***Code***, add a file named `MyClass.cs` to the `MyProject`

(Thanks to Abdul W Yousufzai for reporting this problem)


---

On page 71, the text refers to the wrong version of the package:

>   The dotnet tool install command installs version ***3.1.1*** of th

It should be version 6.0.0.

(Thanks to Abdul W Yousufzai for reporting this problem)

---

**Chapter 5**


On page 97, the description of extension methods incorrectly states they must be defined in the same namespace as the class that is being extended.

(Thanks to Abdul W Yousufzai for reporting this problem)

---

On page 110, the  text says:

> This may seem like an odd feature because an ***interfaces*** is intended...

It should be:

> This may seem like an odd feature because an ***interface*** is intended...

(Thanks to Sanjay Adlakhiya for reporting this problem)

---

**Chapter 6**

On Page 128, the Tip contains the word `Asset`, which should be `Assert`.

(Thanks to Paul Williams and Sanjay Adlakhiya for reporting this problem)

***

On page 137, this sentence:

>   This approach is that it tends to produce unit tests that focus only on the parts of the application code that were difficult to write or that needed some serious debugging, leaving some aspects of a feature only partially tested or untested altogether.

should be:

>   **The problem with this** approach is that it tends to produce unit tests that focus only on the parts of the application code that were difficult to write or that needed some serious debugging, leaving some aspects of a feature only partially tested or untested altogether.

(Thanks to Jim Becker for reporting this problem)

***


**Chapter 7**

On page 145, the first sentence should be:

>   The ***builder.Services*** property is used to set up objects, known as services, that can be used throughout the application and that are accessed through a feature called dependency injection, which I describe in Chapter 14. 

(Thanks to Paul Marangoni for reporting this problem)

***

**Chapter 8**

On page 181, the URL used to test the application is not case sensitive.

(Thanks to Abdul W Yousufzai for reporting this problem)

---

On page 182, the text that describes Listing 8-3 refers to the `Configure` method, which is no longer used to configure ASP.NET Core applications

(Thanks to Abdul W Yousufzai for reporting this problem)

---

On page 188 the following text:

> That means I can use the view component to generate the list of ***components*** and

It should be:

> That means I can use the view component to generate the list of ***categories*** and


(Thanks to Sanjay Adlakhiya for reporting this problem)

---

On page 189, the text that describes the unit test says the test data is passed to the tag helper class, but should say view component class.

(Thanks to Abdul W Yousufzai for reporting this problem)

---

One page 196, the  text that describes the unit test says:

> and then call the `List` action method

It should be:

> and then call the `Index` action method

(Thanks to Sanjay Adlakhiya for reporting this problem)

---

On page 192, the name of the test class is misspelled. It should be `NavigationMenuViewComponentTests`, rather than `NavigatioMenuViewComponentTests`.

(Thanks to Abdul W Yousufzai for reporting this problem)

---

Page 209 contains the sentence:

>   The page model class in Listing 8-25, which is named CartModel, defines an OnPost hander method, which is invoked to handle HTTP POST requests.

This should be:

>   The page model class in Listing 8-25, which is named CartModel, defines an OnPost ***handler*** method, which is invoked to handle HTTP POST requests.

(Thanks to Abdul W Yousufzai for reporting this problem)

---

**Chapter 9**

On page 233, the text that describes Listing 9-19 refers to the `ConfigureServices` method, which is no longer used to configure ASP.NET Core applications.

(Thanks to Sam Miller for reporting this problem)

---

**Chapter 10**

On page 258, the `Details` Razor Component shown in Listing 10-16 doesn't properly manage the lifecycle of the repository class, which means that changes made with the edit feature are not correctly displayed. The component should use the `OwningComponentBase<IStoreRepository>` base class, following the approach used in Listing 10-17.

(Thanks to Olivier Roger for reporting this problem)

---

On page 260, the `@if` expresson that determines whether the ID field is displayed does not properly deal with the nullable type used in the model class. This expression:

    @if(Product.ProductID != 0) {

should be:

    @if(Product.ProductID.HasValue && Product.ProductID.Value != 0) {

(Thanks to Abdul W Yousufzai for reporting this problem)

---

**Chapter 11**

On page 272, the text that describes Listing 11-8 refers to the `Configure` method, which is no longer used to configure ASP.NET Core applications.

(Thanks to Sam Miller for reporting this problem)

---

On page 268, the ***Defining the Connection String*** section contains this sentence:

> The next step is to define the connection string that will be for the database.

This should be:

>  The next step is to define the connection string for the database.

(Thanks to Abdul W Yousufzai for reporting this problem)

---

On page 273, the  sentence that starts like this:

> In Listing 11-9, I used Blazor to create the administration features

should refer to Chapter 10 and not Listing 11-9.

(Thanks to Mike Barnett for reporting this problem)

***

On page 276, this sentence:

> Since this Razor Page has been configured with a page model class, I can apply the attribute with an `@attribute` expression.

It should be:

> Since this Razor Page has been configured ***without*** a page model class, I can apply the attribute with an `@attribute` expression.

(Thanks to Abdul W Yousufzai for reporting this problem)

***

On page 278, Listing 11-14 contains `div` elements that are configured to provide field-level validation for the username and password fields. Validation will only work with `span` elements, and these validation elements are  not required anyway because there is summary validation as well. 

(Thanks to Jeff Hatch for reporting this problem)

***

On page 281, these sentences:

> I have also set the local, which is required when deploying to a Docker container. The local I have chosen is en-US, which represents the language and currency conventions of English as it is spoken in the United States.

should be:

> I have also set the ***locale***, which is required when deploying to a Docker container. The ***locale*** I have chosen is en-US, which represents the language and currency conventions of English as it is spoken in the United States.


(Thanks to Abdul W Yousufzai for reporting this problem)

***

On page 286, the URL for the repository refers to an earlier edition of the book. It should be:

https://github.com/apress/pro-asp.net-core-6

(Thanks to Abdul W Yousufzai for reporting this problem)

***

**Chapter 12**

On page 301, the description for the Cookies entry in Table `12-6` is as follows:

> This property allows cookies to be associated with the request.

This should be:

> This property allows cookies to be associated with the ***response***.


(Thanks to Abdul W Yousufzai for reporting this problem)


***

On page 308, the cast to the `IApplicationBuilder` type is not required.

(Thanks to Abdul W Yousufzai for reporting this problem)


***

**Chapter 13**

On page 323, this sentence implies that omitting the leading / character is a requirement, which is not the case:

>   URL patterns are expressed without a leading / character, which isn’t part of the URL path.

(Thanks to Abdul W Yousufzai for reporting this problem)

----

On page 345, this sentence:

>   With the addition of the route in Listing 13-23, the routing middleware with handle all requests,
including those that match none of the regular routes.

should be:

>   With the addition of the route in Listing 13-23, the routing middleware ***will*** handle all requests,
including those that match none of the regular routes.


(Thanks to Abdul W Yousufzai for reporting this problem)

----


**Chapter 14**

The examples that start on page 311 are not correctly updated for the introduction of the minimal API and do not properly explain endpoint routing.

(Thanks to Oleksandr Shuryha for reporting this problem)

***

On page 363, this sentence:

>   Defining a service and consuming in the same code file may not seem impressive, but once a service is defined, it can be used almost anywhere in an ASP.NET Core application.

should be:

>   Defining a service and consuming ***it*** in the same code file may not seem impressive, but once a service is defined, it can be used almost anywhere in an ASP.NET Core application.

(Thanks to Abdul W Yousufzai for reporting this problem)

***

On page 363, the description for Listing `14-14` gives the location of the file as the `Services` folder. It should be the `Platform` folder.

(Thanks to Abdul W Yousufzai for reporting this problem)

***

On page 369, the text that follows Table 14-4 is awkwardly phrased and should make it obvious that the benefit of using the methods described in the table is the ability to instantiate classes that declare constructor dependencies.

(Thanks to Abdul W Yousufzai for reporting this problem)


***

On page 378, Listing 14-30 should comment out this statement, which is made redundant by the other changes:

    T endpointInstance = ActivatorUtilities.CreateInstance<T>(app.ServiceProvider);

(Thanks to Abdul W Yousufzai for reporting this problem)


***

On page 384, this sentence should make it clear that the IsDevelopment method is an extension method:

> This example uses the Environment property to get an implementation of the IWebHostEnvironment interface and uses its IsDevelopment method to decide which services are set up for the application.

(Thanks to Abdul W Yousufzai for reporting this problem)

***

On page 389, this sentence:

> This feature relies on the versions of the AddSIngleton, AddScoped, and AddTransient methods that accept types as conventional arguments and cannot be performed using generic type arguments.

should be:

> This feature relies on the versions of the ***AddSingleton***, AddScoped, and AddTransient methods that accept types as conventional arguments and cannot be performed using generic type arguments.

(Thanks to Abdul W Yousufzai for reporting this problem)

***

**Chapter 15**

Throughout this chapter, you may see warnings like this when you build the example project:

    CSC : warning AD0001: Analyzer 'Microsoft.AspNetCore.Analyzers.RouteHandlers.RouteHandlerAnalyzer' threw an exception of type 'System.ArgumentException' with message 'Syntax node is not within syntax tree'.

This messasge is the result of an error in the Microsoft code analyzer and can be ignored.

(Thanks to Abdul W Yousufzai for reporting this problem)

---

On page 394, Figure 15-2 and the text that describes it refers to `Microsoft.Hosting.Lifetime`, which refers to a configuration setting from an earlier version of ASP.NET Core.

(Thanks to Paul Williams for reporting this problem)

---

On page 404, the paragraph that follows Table 15-3 misspells Environment. Twice.

(Thanks to Abdul W Yousufzai for reporting this problem)

---

On page 405, the package installed by Listing 15-13 has been deprecated. The command is included in the .NET SDK and a separate package is no longer required.

(Thanks to Abdul W Yousufzai for reporting this problem)

---

On page 409, the statements that create log messages in `Listing 15-20`cause code anlysis warnings because the ILogger<T> methods expect to receve a static string template and a set of values.

(Thanks to Abdul W Yousufzai for reporting this problem)

---

On page 410, Table 15-4 omits the methods for the `warning` level.

(Thanks to Abdul W Yousufzai for reporting this problem)

---

On page 415, this sentence should include the `warning` level:

>   You can tailor the logging levels to focus the log on those parts of the application that are of interest by setting a level to Trace, Debug, Information, Error, or Critical. Logging messages can be disabled for a category using the None value.

(Thanks to Abdul W Yousufzai for reporting this problem)

---

On page 414, the first sentence in the ***Configuring Minimum Logging Levels*** section incorrectly refers to Chapter 14, but should refer the reader to a previous section in the same chapter.

(Thanks to Abdul W Yousufzai for reporting this problem)

---

On page 433, the sentence that follows Table 16-4 refers to the `Configure` method. This method is no longer used following the introduction of the top-level configuration statements for ASP.NET Core.

(Thanks to Abdul W Yousufzai for reporting this problem)

---

On page 438, this sentence specifies the wrong table:

>   This simple data structure allows session data to be stored easily by each of the caches listed in `Table 16-6`. 

This should be Table 16-5.

(Thanks to Abdul W Yousufzai for reporting this problem)

---

On page 441, this command in `Listing 16-10`:

    dotnet dev-certs https –clean

should have two hyphens for the argument, like this:

    dotnet dev-certs https -–clean

(Thanks to Abdul W Yousufzai for reporting this problem)

---

**Chapter 16**

On page 438, the paragraph following the table contains a sentence that gives the wrong table reference. The sentence should be:

> This simple data structure allows session data to be stored easily by each of the caches listed in ***Table 16-8***. 

(Thanks to Paul Marangoni for reporting this problem)

---

**Chapter 17**

On page 458, the instructions following Listing 17-4 incorrectly specify the HTTPS scheme in the request URL. This should be HTTP.

(Thanks to Uzoma Inyama for reporting this problem)

---

On page 461, this sentence specifies the wrong type for configuration with the `AddDistributedMemoryCache` method :

>   This cache is configured using the `MemoryCacheOptions` class, whose most useful properties are described in Table 17-6. 

The configuration type is `MemoryDistributedCacheOptions`.

(Thanks to Abdul W Yousufzai for reporting this problem)

---

**Chapter 19**

On page 493, Figure 19-1 shows the wrong number of items.

(Thanks to Abdul W Yousufzai for reporting this problem)

---

On page 503, the log message generated by the `GetProduct` method won't be displayed at the command prompt because the severity level is lower than the minimum specified by the application settings file. This statement:

    logger.LogDebug("GetProduct Action Invoked");

should be:

    logger.LogInformation("GetProduct Action Invoked");

(Thanks to Abdul W Yousufzai for reporting this problem)

---

On page 509, the first sentence in the ***Improving the Web Service*** section is:

>   The controller in `Listing 19-13` re-creates the functionality provided by the separate endpoints, but there are 
still improvements that can be made, as described in the following sections

This should refer to `Listing 19-11`.

(Thanks to Abdul W Yousufzai for reporting this problem)

---

On page 509, the sidebar specifies a URL for an earlier version of ASP.NET Core. The URL should be:

https://docs.microsoft.com/en-gb/aspnet/core/security/cors


(Thanks to Abdul W Yousufzai for reporting this problem)

---

On page 511, the `UpdateProduct` method at the top of the page contains this statement:

    context.Update(product);

This statement works because the DataContext class inherits an `Update` method that accepts any object. The statement should have been:

    context.Products.Update(product)

The revised statement calls a method that is defined with a generic type parameter, which allows the compiler to highlight problems with argument types.

(Thanks to Jiong hui Luo for reporting this problem)

---

On page 511, both statements in the `UpdateProduct` method have changed and should be marked in bold.

(Thanks to Abdul W Yousufzai for reporting this problem)

---

On page 517, the output from `Listing 19-22` should show a value of `Green Kayak` for the `name` field and not `GreenKayak`.

(Thanks to Abdul W Yousufzai for reporting this problem)

---

On page 518, the description for `Listing 19-23` should be:

> Redirecting to an Action ***in*** the ProductsController.cs File in the Controllers Folder

(Thanks to Abdul W Yousufzai for reporting this problem)

---

On page 518, the output from `Listing 19-23` should show a value of `Green Kayak` for the `name` field and not `GreenKayak`.

(Thanks to Abdul W Yousufzai for reporting this problem)

---

On page 519, the text before `Listing 19-25` should read:

> Listing 19-25 updates the SaveProduct action to perform validation before storing the object that is created 
> by the model binding process, ensuring that only objects that contain values for all four properties decorated 
> with the validation attributes are accepted. 

(Thanks to Abdul W Yousufzai for reporting this problem)

---

**Chapter 20**

On page 527, the introduction includes the phrase:

>   how to use content negations

This should be:

> how to use content ***negotiations*** 


(Thanks to Jiong hui Luo for reporting this problem)

---


On page 536, this sentence: 

>   The action method is decorated with the HttpPatch attribute, which denotes that it will handle 
HTTP requests. 

should be:

>   The action method is decorated with the HttpPatch attribute, which denotes that it will handle 
HTTP **PATCH** requests. 

(Thanks to Abdul W Yousufzai for reporting this problem)

---

**Chapter 21**

The first sentence on page p569 says:

> When the Razor view engine locates a view, it looks in the `View/[controller]`

It should be:

> When the Razor view engine locates a view, it looks in the `Views/[controller]`

(Thanks to Randy Nies for reporting this problem)

---

**Chapter 22**

The text following Listing 22-13 is:

> The file contains sets the `Layout` property

but should be

> The file sets the `Layout` property

(Thanks to Paul Williams for reporting this problem)

---

The text before  Listing 22-14 doesn't correctly describe the purpose of the listing.

(Thanks to Paul Williams for reporting this problem)

---

On page 617, the paragraph that follows the figure contains this sentence:

>   There are two ways to solve this problem. The first is...

The following text doesn't make it clear that the second way to solve this problem is to use the `IsSectionDefined` method, which is desribed in the Testing for Layout Sections section.

(Thanks to Jiong Hui Luo for reporting this problem)


---

**Chapter 23**

The text before Listing 23-6 should make it clear that the routing pattern must be used in conjunction with the parameters defined by the `OnGet` method.

(Thanks to Paul Williams for reporting this problem)

---


The text that follows Listing 23-27 incorrectly states that the `@page` directive has been removed from the listing.

(Thanks to Paul Williams for reporting this problem)

---

Listing 23-18 contains the following fragment of markup, which incorrectly displays the value of the Name property, when the Price property should have been used:

    <tr><th>Price</th><td>@Model.Product?.Name</td></tr>

(Thanks to Paul Williams for reporting this problem)

---

**Chapter 24**

On page 669, the caption for `Listing 24-9` and the paragraph before the listing wrongly use the `.json` file extension. The file should be created using the `.cshtml` file extension.

(Thanks to Stuart Willows for reporting this problem)

---

On pages 682, 683, and 684, the bold statements in the listings contain additional or incorrect characters. The bold statement in Listing 24-22 should be:

    <vc:city-summary theme-name="secondary" />

The bold statement in Listing 24-23 should be:

    <vc:city-summary theme-name="danger" />

The bold statement in Listing 24-24 should be:

    public IViewComponentResult Invoke(string themeName="success") {

(Thanks to Jiong Hui Luo for reporting this problem)

---

**Chapter 25**

On page 697, the introductory text for tag helpers shows the wrong srt of attributes for the untransformed element. The fragment of markup should be:

    <tr bg-color="primary">
        <th colspan="2">Product Summary</th>
    </tr>

(Thanks to Jiong Hui Luo for reporting this problem)

---

**Chapter 26**

On page 743, Listing 26-10 contains this element:

    <script asp-src-include="lib/jquery**/*.min.js"></script>

which should be:

    <script asp-src-include="lib/jquery/**/*.min.js"></script>

(Thanks to Jiong Hui Luo for reporting this problem)

---

**Chapter 30**

On page 929, this sentence:

>    URL segment and throws an ArgumentOutOfRangeException if its value is greater than 50. If there is a value and it is in range, then the action method returns a ViewResult.

which should be:

> URL segment and throws an ArgumentOutOfRangeException if its value is greater than **10**. If there is a value 
and it is in range, then the action method returns a ViewResult.

(Thanks to Jiong Hui Luo for reporting this problem)

---

**Chapter 31**

On page 944, the sentence before Listing 31-2 should be:

> Create the **Views/Home/Index.cshtml** files, as shown in Listing 31-2.

(Thanks to Jiong Hui Luo for reporting this problem)

--- 

**Chapter 39**

On page 1208, the text before Listing 39-7 includes this sentence:

>   ASP.NET Core Identity provides a middleware component that detects the cookie created by the 
SignInManager<T> class and populates the HttpContex object with details of the authenticated user. 

which should be:

> ASP.NET Core Identity provides a middleware component that detects the cookie created by the 
SignInManager<T> class and populates the **HttpContext** object with details of the authenticated user. 

(Thanks to Jiong Hui Luo for reporting this problem)

---

On page 1236, the first sentence following the listing should have been removed. 

(Thanks to Jiong Hui Luo for reporting this problem)