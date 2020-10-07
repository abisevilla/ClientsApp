Imports System.Data
Imports System.Data.SqlClient

Public Class Clients
    Inherits System.Web.UI.Page
    Dim dal As New DAL.DML
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        GridView1.DataSource = dal.GetClients()
        GridView1.DataBind()


    End Sub

    Protected Sub Save_Btn_Click(sender As Object, e As EventArgs) Handles Save_Btn.Click
        Dim newClient As New DAL.ClientModel
        newClient.FirstName = ClientName.Text
        newClient.LastName = ClientLastName.Text
        newClient.Phone = ClientPhone.Text
        newClient.Email = ClientEmail.Text
        newClient.OfficeAddress = ClientAddress.Text

        If dal.InsertClient(newClient) Then
            Respuesta.Text = "Registro ingresado con exito"
            GridView1.DataSource = dal.GetClients()
            GridView1.DataBind()
        End If
    End Sub
End Class