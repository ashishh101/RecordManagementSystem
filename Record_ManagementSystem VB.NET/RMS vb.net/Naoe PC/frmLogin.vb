Imports MySql.Data.MySqlClient
Public Class frmLogin

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim conn As New MySqlConnection("Server=localhost;User Id=root;Password='';Database=naoepc")
        Try

            Dim sqlquery As String = "SELECT * From tblpassword WHERE username ='" & txtUser.Text & "';"
            Dim data As MySqlDataReader
            Dim adapter As New MySqlDataAdapter
            Dim command As MySqlCommand = New MySqlCommand


            conn.Open()

            command.CommandText = sqlquery
            command.Connection = conn
            adapter.SelectCommand = command
            data = command.ExecuteReader



            While data.Read()
                If data.HasRows() = True Then
                    If data(2).ToString = txtPassword.Text Then
                        Me.Hide()
                        frmNavigator.Show()

                    Else

                        Dim aw As String
                        aw = MsgBox("Wrong Username/Password, Try again?", vbOKCancel + vbCritical, "Failed!")

                        If aw = vbOK Then

                            conn.Open()

                        ElseIf aw = vbCancel Then

                            Application.Exit()

                        End If

                    End If

                End If

            End While
            conn.Close()
        Catch ex As Exception

        Finally
            conn.Dispose()

        End Try
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
