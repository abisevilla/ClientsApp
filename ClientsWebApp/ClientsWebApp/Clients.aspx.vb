Imports System.Data
Imports System.Data.SqlClient
Imports System.Web.UI.WebControls

Public Class Clients
    Inherits System.Web.UI.Page
    Dim dal As New DAL.DML
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Not IsPostBack Then
            GridView1.DataSource = dal.GetClients()
            GridView1.DataBind()

        End If

        '   GridView1.Columns(0).Visible = False
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
            ClientName.Text = ""
            ClientLastName.Text=""
            ClientEmail.Text=""
            ClientPhone.Text=""
            ClientEmail.Text=""
            ClientAddress.Text = ""

        End If
    End Sub

    Protected Sub OnRowEditing(sender As Object, e As GridViewEditEventArgs)
        GridView1.EditIndex = e.NewEditIndex
        GridView1.DataSource = dal.GetClients()
        GridView1.DataBind()
    End Sub

    Protected Sub GridView1_RowEditing(sender As Object, e As GridViewEditEventArgs) Handles GridView1.RowEditing
        'GridView1.EditIndex = e.NewEditIndex
        'GridView1.DataSource = dal.GetClients()
        'GridView1.DataBind()

    End Sub

    Protected Sub GridView1_RowUpdating(sender As Object, e As GridViewUpdateEventArgs) Handles GridView1.RowUpdating
        Dim row As GridViewRow = GridView1.Rows(e.RowIndex)
        '  Dim ClientId As String = Convert.ToInt32(GridView1.Rows(e.RowIndex).Cells(1).Text)

        '  Dim customerId As Integer = Convert.ToInt32(GridView1.DataKeys(e.RowIndex).Values(0))
        '  Dim ClientId As String = GridView1.Rows(e.RowIndex).Cells(0).Text

        'Dim ClientId As String = e.NewValues("ClientId")
        Dim ClientId As String = TryCast(row.FindControl("HdnClientId"), Label).Text
        Dim name As String = TryCast(row.FindControl("FirstName"), TextBox).Text
        Dim lastname As String = TryCast(row.FindControl("LastName"), TextBox).Text
        Dim email As String = TryCast(row.FindControl("Email"), TextBox).Text
        Dim Phone As String = TryCast(row.FindControl("Phone"), TextBox).Text
        Dim address As String = TryCast(row.FindControl("OfficeAddress"), TextBox).Text
        Dim dal As New DAL.DML
        Dim cid As Integer
        cid = Convert.ToInt64(ClientId)
        dal.UpdateClient(cid, name, lastname, email, Phone, address)




        GridView1.EditIndex = -1
        GridView1.DataSource = dal.GetClients()
        GridView1.DataBind()

    End Sub

    Protected Sub GridView1_RowDataBound(sender As Object, e As GridViewRowEventArgs) Handles GridView1.RowDataBound


    End Sub



    Protected Sub OnUpdate2(sender As Object, e As GridViewUpdateEventArgs)
        Dim row As GridViewRow = GridView1.Rows(e.RowIndex)
        Dim name As String = TryCast(row.FindControl("FirstName"), TextBox).Text

        GridView1.EditIndex = -1
        GridView1.DataSource = dal.GetClients()
        GridView1.DataBind()
    End Sub
    Protected Sub OnUpdate(sender As Object, e As EventArgs)
        'Dim row As GridViewRow = TryCast(TryCast(sender, LinkButton).NamingContainer, GridViewRow)
        'Dim name As String = TryCast(row.Cells(4).Controls(0), TextBox).Text

        GridView1.EditIndex = -1
        GridView1.DataSource = dal.GetClients()
        GridView1.DataBind()
    End Sub

    Protected Sub OnCancel(sender As Object, e As EventArgs)
        GridView1.EditIndex = -1
        GridView1.DataSource = dal.GetClients()
        GridView1.DataBind()
    End Sub
End Class