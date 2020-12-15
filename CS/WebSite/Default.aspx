<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Grid_Bind_RunTimeBinding" %>

<%@ Register Assembly="DevExpress.Web.v19.2, Version=19.2.11.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>


<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Bind a grid to a DataTable via code</title>
</head>
<body>
    <form id="form1" runat="server">
        <dx:ASPxGridView ID="grid" ClientInstanceName="grid" runat="server" Width="300px"
            AutoGenerateColumns="False" OnDataBinding="grid_DataBinding">
        </dx:ASPxGridView>
    </form>
</body>
</html>
