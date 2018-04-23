Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.Configuration
Imports System.Collections
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls
Imports DevExpress.Web.ASPxGridView

Partial Public Class Grid_Bind_RunTimeBinding
	Inherits System.Web.UI.Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) AndAlso (Not IsCallback) Then
			'Create columns on the first load.
			Dim id As New GridViewDataColumn()
			id.FieldName = "id"
			grid.Columns.Add(id)
			Dim data As New GridViewDataColumn()
			data.FieldName = "data"
			grid.Columns.Add(data)
		End If

		'Bind the grid only once
		If (Not IsPostBack) Then
			grid.DataBind()
		End If
	End Sub

	Protected Sub grid_DataBinding(ByVal sender As Object, ByVal e As EventArgs)
		' Assign the data source in grid_DataBinding
		grid.DataSource = GetTable()
	End Sub

	Private Function GetTable() As DataTable
		'You can store a DataTable in the session state
		Dim table As DataTable = TryCast(Session("Table"), DataTable)
		If table Is Nothing Then
			table = New DataTable()
			table.Columns.Add("id", GetType(Integer))
			table.Columns.Add("data", GetType(String))
			For n As Integer = 0 To 99
				table.Rows.Add(n, "row" & n.ToString())
			Next n
			Session("Table") = table
		End If

		'Otherwise you have to create a DataTable instance on every request:
		'DataTable table = new DataTable();
		'table.Columns.Add("id", typeof(int));
		'table.Columns.Add("data", typeof(String));
		'for(int n = 0; n < 100; n++) {
		'    table.Rows.Add(n, "row" + n.ToString());
		'}

		Return table
	End Function
End Class
