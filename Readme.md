<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128536896/19.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E168)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->

# ASP.NET - Bind ASPxGridView to a DataTable object

This example handles the server-side [`DataBinding`](https://docs.microsoft.com/en-us/dotnet/api/system.web.ui.control.databinding) event to bind [`ASPxGridView`](https://docs.devexpress.com/AspNet/DevExpress.Web.ASPxGridView) to a programmatically created [`DataTable`](https://docs.microsoft.com/en-us/dotnet/api/system.data.datatable) object.

<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/e168/)**
<!-- run online end -->

## Files to Look At

* [Default.aspx](./CS/WebSite/Default.aspx) (VB: [Default.aspx](./VB/WebSite/Default.aspx))
* [Default.aspx.cs](./CS/WebSite/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/WebSite/Default.aspx.vb))

## Implementation Details

In this example, [`ASPxGridView`](https://docs.devexpress.com/AspNet/DevExpress.Web.ASPxGridView) uses a programmatically created [`DataTable`](https://docs.microsoft.com/en-us/dotnet/api/system.data.datatable) object as its data source. To bind the grid to the [`DataTable`](https://docs.microsoft.com/en-us/dotnet/api/system.data.datatable) object, the [`DataBinding`](https://docs.microsoft.com/en-us/dotnet/api/system.web.ui.control.databinding) event handler assigns this table to the grid's [`DataSource`](https://docs.devexpress.com/AspNet/DevExpress.Web.ASPxDataWebControlBase.DataSource) property. 

The example stores the initially created [`DataTable`](https://docs.microsoft.com/en-us/dotnet/api/system.data.datatable) object in [session state](https://docs.microsoft.com/en-us/previous-versions/aspnet/ms178581(v=vs.100)). This technique allows you not to recreate the table for subsequent [`DataBinding`](https://docs.microsoft.com/en-us/dotnet/api/system.web.ui.control.databinding) event triggers.

## Documentation

[Bind Grid View to Data at Runtime](https://docs.devexpress.com/AspNet/403612/components/grid-view/concepts/bind-to-data/bind-to-data-at-runtime#bind-in-the-databinding-event-handler)

## More Examples

[ASPxGridView - Editing an in-memory dataset](https://github.com/DevExpress-Examples/aspxgridview-editing-an-in-memory-dataset-e257)
