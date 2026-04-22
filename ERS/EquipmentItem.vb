' Data model that mirrors a row in the `equipment` table.
Public Class EquipmentItem
    Public Property EquipmentId As Integer
    Public Property Name As String
    Public Property Category As String
    Public Property DailyRate As Decimal
    Public Property TotalStock As Integer   ' Overall units owned by the business
    Public Property AvailStock As Integer   ' Units not currently out on active rentals
    Public Property IconTag As String       ' Emoji character used as the card icon in the kiosk UI
    Public Property IsActive As Boolean     ' Soft-delete flag – False hides the item from customers

    ' Convenience property: an item is rentable only when stock is on hand AND it hasn't been deactivated.
    Public ReadOnly Property IsAvailable As Boolean
        Get
            Return AvailStock > 0 AndAlso IsActive
        End Get
    End Property
End Class
