Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim strPrint As String
        strPrint = "Nosware Store & Coffe Shop" & vbCrLf
        strPrint = strPrint & "------------------------------" & vbCrLf
        strPrint = strPrint & "No     : TN1254389" & vbCrLf
        strPrint = strPrint & "Cashier: Soni" & vbCrLf
        strPrint = strPrint & " " & vbCrLf
        strPrint = strPrint & "Nama   Qty. Costs SubTotal" & vbCrLf
        strPrint = strPrint & "------------------------------" & vbCrLf
        strPrint = strPrint & "Sauce    2   5000    10000" & vbCrLf
        strPrint = strPrint & "Coffe    3   1000     3000" & vbCrLf
        strPrint = strPrint & "Sugar    1   8000     3000" & vbCrLf
        strPrint = strPrint & "------------------------------" & vbCrLf
        strPrint = strPrint & "Total                13000" & vbCrLf
        Printer.Print(strPrint)
    End Sub
End Class
