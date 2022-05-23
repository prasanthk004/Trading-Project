
Imports Microsoft.Data.SqlClient
Imports System.Windows
Public Class SqlServer


    Private Function appsetting(ByVal x As String) As String
        Dim db As String
        db = System.Configuration.ConfigurationManager.AppSettings(x)
        Return System.Configuration.ConfigurationManager.AppSettings(x)
    End Function
    Function connections() As String
        Return appsetting("Connectionstring")
        ' Return My.Settings.Test
    End Function


    Public Function GetDataTable(ByVal q As String) As DataTable

        Dim con As SqlConnection = Nothing
        Dim cmd As SqlCommand = Nothing
        Dim dt As New DataTable
        Dim da As SqlDataAdapter = Nothing
        Dim query As String
        Try
            query = "Server=DESKTOP-8MQO0E0\SQLEXPRESS;Database=Trading Project;uid=trade;pwd=kp;TrustServerCertificate=True"
            con = New SqlConnection(connections)

            cmd = New SqlCommand(q, con)
            da = New SqlDataAdapter(cmd)

            da.Fill(dt)

            Return dt

        Catch ex As Exception
            Debug.Print(ex.Message)
            Throw

        Finally
            con.Dispose()
            cmd.Dispose()
            da.Dispose()


        End Try


    End Function

    Public Function GetDataTable(ByVal cmd As SqlCommand) As DataTable

        Dim con As SqlConnection
        Dim dt As New DataTable
        Dim da As SqlDataAdapter

        Try

            con = New SqlConnection(connections)

            cmd.Connection = con
            da = New SqlDataAdapter(cmd)
            con.Open()

            da.Fill(dt)

            Return dt
        Catch ex As Exception
            Throw

        Finally
            con.Dispose()
            cmd.Dispose()
            da.Dispose()

        End Try



    End Function
    Public Function ExecuteNonQuery(ByVal query As String) As Long
        Dim con As SqlConnection
        Dim cmd As SqlCommand

        Try
            con = New SqlConnection(connections)
            cmd = New SqlCommand(query, con)

            Return cmd.ExecuteNonQuery

        Catch ex As Exception
            Throw
        Finally
            con.Dispose()
            cmd.Dispose()
        End Try
    End Function




    Public Function ExecuteNonQuery(ByVal cmd As SqlCommand, Optional ByRef keyvalue As Long = Nothing) As Long
        Dim con As SqlConnection
        Dim laffectedrec As Long


        Try
            con = New SqlConnection(connections)
            cmd.Connection = con
            con.Open()
            laffectedrec = cmd.ExecuteNonQuery

            If keyvalue <> Nothing Then
                If keyvalue <= -1 Then
                    keyvalue = GetKeyValue(con)
                End If
            End If

            Return laffectedrec


        Catch ex As Exception
            Throw
        Finally
            con.Dispose()
            cmd.Dispose()
        End Try
    End Function

    Public Function ExecuteScaler(ByVal query As String) As Long
        Dim con As SqlConnection
        Dim cmd As SqlCommand

        Try
            con = New SqlConnection(connections)
            cmd = New SqlCommand(query, con)


            con.Open()
            Return cmd.ExecuteScalar

        Catch ex As Exception
            Throw
        Finally
            con.Dispose()
            cmd.Dispose()
        End Try
    End Function


    Public Function ExecuteScaler(ByVal cmd As SqlCommand) As Long
        Dim con As SqlConnection


        Try
            con = New SqlConnection(connections)
            cmd.Connection = con

            con.Open()
            Return cmd.ExecuteScalar

        Catch ex As Exception
            Throw
        Finally
            con.Dispose()
            cmd = Nothing
        End Try
    End Function

    Private Function GetKeyValue(con) As Long
        Dim cmd As SqlCommand
        Dim query As String
        Try

            query = "Select @@Identity"
            cmd = New SqlCommand(query, con)
            Return cmd.ExecuteScalar()
        Catch ex As Exception
            Throw
        End Try


    End Function

    Public Function UpdateDataTable(ByVal dt As DataTable, ByVal tablename As String)
        Dim con As SqlConnection
        Dim cmd As SqlCommand
        Dim query As String
        Dim cb As SqlCommandBuilder
        Dim da As SqlDataAdapter


        Try
            con = New SqlConnection(connections)
            query = "select * from " & tablename
            cmd = New SqlCommand(query, con)
            da = New SqlDataAdapter(cmd)
            cb = New SqlCommandBuilder(da)

            da.Update(dt)

        Catch ex As Exception
            Throw
        End Try

    End Function


End Class
