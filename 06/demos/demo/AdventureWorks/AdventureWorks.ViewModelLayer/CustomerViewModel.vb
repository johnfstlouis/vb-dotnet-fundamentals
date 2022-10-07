Imports System.Collections.ObjectModel
Imports AdventureWorks.DataLayer
Imports AdventureWorks.EntityLayer
Imports Common.Library

Public Class CustomerViewModel
  Inherits ViewModelBase

  Sub New()
    LoadCustomers()
  End Sub

  Public Property Customers As ObservableCollection(Of Customer)
  Public Property Entity As Customer

  Function LoadCustomers(ByVal Optional startingFilePath As String = "") As ObservableCollection(Of Customer)
    ' Create a new instance of customer manager
    Dim mgr = New CustomerManager

    Customers = mgr.LoadCustomers(startingFilePath)

    Return Customers
  End Function

  Function LoadCustomer(ByVal customerId As Integer, ByVal Optional startingFilePath As String = "") As Customer
    ' Create a new instance of customer manager
    Dim mgr = New CustomerManager

    Entity = mgr.LoadCustomer(customerId, startingFilePath)

    ' Inform UI that the Entity property changed
    RaisePropertyChanged("Entity")

    Return Entity
  End Function
End Class
