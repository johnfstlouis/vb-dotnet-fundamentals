AdventureWorks Web Sample
=========================================
Create a new MVC application
- Add AdventureWorks.EntityLayer
- Add AdventureWorks.DataLayer
- Add AdventureWorks.ViewModelLayer
- Add Common.Library

In web project
  Add \Xml folder from WPF application
  Add references to EntityLayer and ViewModelLayer and Common.Library
  Add to Web.Config
    <add key="ProductsFile" value="\Xml\Products.xml"/>
    <add key="CustomersFile" value="\Xml\Customers.xml"/>
  Remove About and Contact pages
  Remove About/Contact methods from HomeController.cs
  Fix up _layout.cshtml page
  Fix up Home.cshtml page
  Open \Content\Site.css and modify body-content style
    body {
      padding-top: 100px;
      padding-bottom: 20px;
    }

Add ProductList Page
---------------------------
Add \Views\Products Folder
Add | MVC 5 View Page with Layout (Razor)
