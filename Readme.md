<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128536896/19.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E168)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->

# ASP.NET - Bind ASPxGridView to a DataTable at runtime

This example handles the server-side [`DataBinding`](https://docs.microsoft.com/en-us/dotnet/api/system.web.ui.control.databinding) event to bind [ASPxGridView](https://docs.devexpress.com/AspNet/DevExpress.Web.ASPxGridView) to a programmatically created [`DataTable`](https://docs.microsoft.com/en-us/dotnet/api/system.data.datatable).

<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/e168/)**
<!-- run online end -->

## Files to Look At

* [Default.aspx](./CS/WebSite/Default.aspx) (VB: [Default.aspx](./VB/WebSite/Default.aspx))
* [Default.aspx.cs](./CS/WebSite/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/WebSite/Default.aspx.vb))

## Implementation Details

In this example, [`ASPxGridView`](https://docs.devexpress.com/AspNet/DevExpress.Web.ASPxGridView) uses the programmatically created [`DataTable`](https://docs.microsoft.com/en-us/dotnet/api/system.data.datatable) as its data source. The [`DataBinding`](https://docs.microsoft.com/en-us/dotnet/api/system.web.ui.control.databinding) event handler code assigns the created table to the grid's [DataSource](https://docs.devexpress.com/AspNet/DevExpress.Web.ASPxDataWebControlBase.DataSource) property. The example stores this [`DataTable`](https://docs.microsoft.com/en-us/dotnet/api/system.data.datatable) in the [session state](https://docs.microsoft.com/en-us/previous-versions/aspnet/ms178581(v=vs.100)) to use the initially created table for subsequent [`DataBinding`](https://docs.microsoft.com/en-us/dotnet/api/system.web.ui.control.databinding) event triggers.

## More Examples

[ASPxGridView - Editing an in-memory dataset](https://github.com/DevExpress-Examples/aspxgridview-editing-an-in-memory-dataset-e257)