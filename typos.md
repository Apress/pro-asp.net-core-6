# Typos for *Pro ASP.NET Core 6*

This file contains smaller errors that are unlikely to prevent the code examples from working and which I will correct in the next edition of the book. See [this](errata.md) file for mistakes that prevent the code examples from working as expected.

---


**Chapter 3**

Figure 3-7 should show a value in the `Name` field, as described in the text.

(Thanks to Ian Kode for reporting this problem)

---

Figure 3-11 should show a drop-down list.

(Thanks to Ian Kode for reporting this problem)

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

**Chapter 14**

The examples that start on page 311 are not correctly updated for the introduction of the minimal API and do not properly explain endpoint routing.

(Thanks to Oleksandr Shuryha for reporting this problem)

***

**Chapter 15**

Figure 15-2 and the text that describes it refers to `Microsoft.Hosting.Lifetime`, which refers to a configuration setting from an earlier version of ASP.NET Core.

(Thanks to Paul Williams for reporting this problem)

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

