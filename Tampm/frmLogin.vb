Imports System.Data.SqlClient
Public Class frmLogin

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim chuoiketnoi As String = "workstation id=PS02054.mssql.somee.com;packet size=4096;user id=tampm;pwd=T@M789852;data source=PS02054.mssql.somee.com;persist security info=False;initial catalog=PS02054"

        Dim KetNoi As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim sqlAdapter As New SqlDataAdapter("select * from Nhan_Vien where MSNV='" & txtUsername.Text & "' and Password='" & txtPassword.Text & "' ", KetNoi)
        Dim tb As New DataTable

        Try
            KetNoi.Open()
            sqlAdapter.Fill(tb)
            If tb.Rows.Count > 0 Then
                MessageBox.Show("Kết nối thành công")
                frmMain.Show()
                Me.Hide()
            Else
                MessageBox.Show("Sai Tai Khoan hoac Mat Khau")
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

    End Sub
End Class
