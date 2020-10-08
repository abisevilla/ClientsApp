Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Web

Public Class DML


    Public Function InsertClient(MiCliente As ClientModel) As Boolean
        Dim cnn As New SqlConnection(Connection.GetConnection)
        Dim cmd As New SqlCommand("SP_INSERT", cnn)

        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add("FirstName", SqlDbType.VarChar, 255).Value = MiCliente.FirstName

        cmd.Parameters.Add("LastName", SqlDbType.VarChar, 255).Value = MiCliente.LastName

        cmd.Parameters.Add("Email", SqlDbType.VarChar, 255).Value = MiCliente.Email

        cmd.Parameters.Add("Phone", SqlDbType.VarChar, 255).Value = MiCliente.Phone
        cmd.Parameters.Add("OfficeAddress", SqlDbType.VarChar, 355).Value = MiCliente.OfficeAddress


        Try
            If cnn.State = ConnectionState.Closed Then
                cnn.Open()
            End If
            cmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            Return False
        End Try
        cnn.Close()
    End Function
    Public Sub UpdateClient(ByVal Clientid As Integer, ByRef FirstName As String, ByRef LastName As String, ByRef Email As String, ByRef Phone As String, ByRef OfficeAddress As String)
        Dim cnn As New SqlClient.SqlConnection(Connection.GetConnection)
        Dim cmd As New SqlClient.SqlCommand("SP_UPDATE", cnn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("Clientid", SqlDbType.Int).Value = Clientid

        cmd.Parameters.Add("FirstName", SqlDbType.VarChar, 255).Value = FirstName

        cmd.Parameters.Add("LastName", SqlDbType.VarChar, 255).Value = LastName

        cmd.Parameters.Add("Email", SqlDbType.VarChar, 255).Value = Email

        cmd.Parameters.Add("Phone", SqlDbType.VarChar, 255).Value = Phone
        cmd.Parameters.Add("OfficeAddress", SqlDbType.VarChar, 355).Value = OfficeAddress

        Try
            cnn.Open()
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try
        cnn.Close()
    End Sub

    Public Sub SearchClient(ByVal Clientid As Integer, ByRef FirstName As String, ByRef LastName As String, ByRef Email As Integer, ByRef Phone As String, ByRef OfficeAddress As String)
        Dim cnn As New SqlClient.SqlConnection(Connection.GetConnection)
        Dim cmd As New SqlClient.SqlCommand("SP_SEARCH", cnn)
        cmd.Parameters.Add("Clientid", SqlDbType.Int).Value = Clientid
        cmd.CommandType = CommandType.StoredProcedure
        Try
            cnn.Open()
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                dr.Read()
                FirstName = dr(0).ToString
                LastName = dr(1).ToString
                Email = dr(2).ToString
                Phone = dr(3).ToString
                OfficeAddress = dr(4).ToString
            End If
            cmd.ExecuteNonQuery()
            dr.Close()

        Catch ex As Exception
        End Try
        cnn.Close()
    End Sub


    Public Function GetClients() As Object
        Dim cnn As New SqlClient.SqlConnection(Connection.GetConnection)
        Dim cmd As New SqlClient.SqlCommand("SP_GETCLIENTS", cnn)
        cmd.CommandType = CommandType.StoredProcedure
        Dim info As Object
        Try
            cnn.Open()
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader
            Return dr

            dr.Close()

        Catch ex As Exception
        End Try
        cnn.Close()
    End Function


    Public Sub DeleteClient(ByVal Clientid As Integer, ByRef FirstName As String, ByRef LastName As String, ByRef Email As Integer, ByRef Phone As String, ByRef OfficeAddress As String)
        Dim cnn As New SqlClient.SqlConnection(Connection.GetConnection)
        Dim cmd As New SqlClient.SqlCommand("SP_DELETE", cnn)
        cmd.Parameters.Add("Clientid", SqlDbType.Int).Value = Clientid
        cmd.CommandType = CommandType.StoredProcedure
        Try
            cnn.Open()
            cmd.ExecuteNonQuery()

        Catch ex As Exception

        End Try
        cnn.Close()
    End Sub


End Class
