Imports DecisionSamples.Common

Public Class OtherSamples
#Const conLANGUAGE = "ENGLISH"
  ' #Const conLANGUAGE = "GERMAN"

  Sub Sample01()
#If DEBUG Then
    Console.WriteLine("In DEBUG mode")
#Else
  Console.WriteLine("In RELEASE mode")
#End If
  End Sub

  Sub Sample02()
#If conLANGUAGE = "ENGLISH" Then
    Console.WriteLine("Good Morning Mr. Jones")
#Else
  Console.WriteLine("Guten Morgen Herr Jones")
#End If
  End Sub

#Region "Sample03 - With End With"
  Sub Sample03()
    Dim prod As New Product

    With prod
      .ProductID = 1
      .Name = "A new product"
      .ProductNumber = "A101"
      .StandardCost = 50
      .ListPrice = 100
    End With
  End Sub
#End Region
End Class
