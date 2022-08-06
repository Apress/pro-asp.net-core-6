# Errata for *Pro ASP.NET Core 6*

This file contains errors that are likely to prevent the code examples from working as described in ths book. See [this](typos.md) file for small mistakes that I intend to correct in the next edition.

---

**Chapter 5**

On Page 83, when describing null state analysis, I wrote:

>But if a variable’s type is string, then it can be assigned null values, which means you can confidently access the features it provides without needing to guard against null references.

This should be:

>But if a variable’s type is string, then it <b>cannot</b> be assigned null values, which means you can confidently access the features it provides without needing to guard against null references.

(Thanks to Aidan Plunkitt for reporting this problem)

---

**Chapter 17**

On page 463, the `dotnet sql-cache` command is used, which relies on a command package for which I omitted installation instructions. Run this command to install the required package:

    dotnet tool install --global dotnet-sql-cache --version 6.0.0

(Thanks to Abdul W Yousufzai for reporting this problem)

---