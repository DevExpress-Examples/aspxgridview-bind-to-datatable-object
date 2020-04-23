<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Grid_Bind_RunTimeBinding" %>

<%@ Register Assembly="DevExpress.Web.v19.2" Namespace="DevExpress.Web"
    TagPrefix="dxe" %>
<%@ Register Assembly="DevExpress.Web.v19.2" Namespace="DevExpress.Web"
    TagPrefix="dxwgv" %>
<%@ Register Assembly="DevExpress.Web.v19.2" Namespace="DevExpress.Web"
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
