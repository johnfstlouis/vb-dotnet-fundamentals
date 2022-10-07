@ModelType AdventureWorks.ViewModelLayer.CustomerViewModel

@Code
  Layout = "~/Views/Shared/_Layout.vbhtml"
  ViewBag.Title = "Customers"
End Code

<table class="table table-bordered table-striped">
  <thead>
    <tr>
      <th>Customer ID</th>
      <th>Company Name</th>
      <th>First Name</th>
      <th>Last Name</th>
    </tr>
  </thead>

  @For Each customer In Model.Customers
    @<tbody>
      <tr>
        <td>@customer.CustomerID</td>
        <td>@Html.ActionLink(customer.CompanyName, "CustomerDetail", New With {.id = customer.CustomerID})</td>
        <td>@customer.FirstName</td>
        <td>@customer.LastName</td>
      </tr>
    </tbody>
  Next
</table>