Public Class frmFactorial

    Dim x As Integer
    Dim y As ULong = 1

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        x = CInt(txtNumber.Text)
        Dim i As Integer
        For i = 1 To x
            y *= CULng(i)
            'formats output with commas and no decimal
            txtFactorial.Text = FormatNumber(CStr(y), 0)
        Next i

        txtNumber.Clear()
        txtNumber.Select()
        y = 1
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

End Class
