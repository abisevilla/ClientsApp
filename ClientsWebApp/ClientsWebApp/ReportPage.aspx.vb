Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports DAL
Public Class ReportPage
    Inherits System.Web.UI.Page
    Dim dal As New DAL.DML

    Dim adp As New SqlDataAdapter
    Dim ds As New DataSet
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim rc As New ReportDocument()
        rc.Load(Server.MapPath("~/Reports/ClientsReport.rpt"))
        Dim dsClients As DB = GetData()
        rc.SetDataSource(dsClients)
        CrystalReportViewer1.ReportSource = rc
        rc.Refresh()
    End Sub
    Private Function GetData() As DB
        Dim cmd As New SqlCommand("SP_GETCLIENTS")
        Using con As New SqlConnection(Connection.GetConnection)
            Using sda As New SqlDataAdapter()
                cmd.Connection = con
                cmd.CommandType = CommandType.StoredProcedure
                sda.SelectCommand = cmd

                Using dsClientS As New DB()
                    sda.Fill(dsClientS, "SP_CLIENTS")

                    Return dsClientS
                End Using
            End Using
        End Using
    End Function
End Class