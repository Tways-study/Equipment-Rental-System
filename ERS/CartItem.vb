' Represents a single line in the customer's shopping cart.
Public Class CartItem
    Public Property Equipment As EquipmentItem  ' The equipment being rented
    Public Property Quantity As Integer          ' How many units the customer wants

    ' Calculates the cost for this line: rate × quantity × number of rental days.
    Public Function LineTotal(days As Integer) As Decimal
        Return Equipment.DailyRate * Quantity * days
    End Function
End Class
