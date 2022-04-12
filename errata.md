# Errata for *Pro ASP.NET Core 6*

**Chapter 15**

On Page 83, when describing null state analysis, I wrote:

>But if a variable’s type is string, then it can be assigned null values, which means you can confidently access the features it provides without needing to guard against null references.

This should be:

>But if a variable’s type is string, then it <b>cannot</b> be assigned null values, which means you can confidently access the features it provides without needing to guard against null references.

(Thanks to Aidan Plunkitt for reporting this problem)
***