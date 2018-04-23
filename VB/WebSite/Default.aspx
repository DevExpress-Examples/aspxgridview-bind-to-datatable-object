<%@ Page Language="vb" AutoEventWireup="true" CodeFile="Default.aspx.vb" Inherits="Grid_Bind_RunTimeBinding" %>

<%@ Register Assembly="DevExpress.Web.ASPxEditors.v11.1" Namespace="DevExpress.Web.ASPxEditors"
	TagPrefix="dxe" %>
<%@ Register Assembly="DevExpress.Web.ASPxGridView.v11.1" Namespace="DevExpress.Web.ASPxGridView"
	TagPrefix="dxwgv" %>
<%@ Register Assembly="DevExpress.Web.v11.1" Namespace="DevExpress.Web.ASPxPager"
	TagPrefix="dxwp" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
	<title>Bind a grid to a DataTable via code</title>
</head>
<body>
	<form id="form1" runat="server">
	<dxwgv:ASPxGridView ID="grid" ClientInstanceName="grid" runat="server" Width="300px"
		AutoGenerateColumns="False" OnDataBinding="grid_DataBinding">
	</dxwgv:ASPxGridView>
	</form>
</body>
</html>