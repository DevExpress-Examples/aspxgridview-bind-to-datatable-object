<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128536896/21.2.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E168)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
<!-- default file list -->

# Grid View for ASP.NET Web Forms - Bind ASPxGridView to a DataTable object

This example handles the [DataBinding](https://docs.microsoft.com/en-us/dotnet/api/system.web.ui.control.databinding) event to bind [ASPxGridView](https://docs.devexpress.com/AspNet/DevExpress.Web.ASPxGridView) to a programmatically created [DataTable](https://docs.microsoft.com/en-us/dotnet/api/system.data.datatable) object.


## Implementation Details

In this example, the grid's [DataBinding](https://docs.microsoft.com/en-us/dotnet/api/system.web.ui.control.databinding) event handler assigns a programmatically created [DataTable](https://docs.microsoft.com/en-us/dotnet/api/system.data.datatable) object to the grid's [DataSource](https://docs.devexpress.com/AspNet/DevExpress.Web.ASPxDataWebControlBase.DataSource) property. To persist the object between [DataBinding](https://docs.microsoft.com/en-us/dotnet/api/system.web.ui.control.databinding) event occurrences, the example stores it in [session state](https://docs.microsoft.com/en-us/previous-versions/aspnet/ms178581(v=vs.100)). With this technique, you do not have to recreate the object each time the [DataBinding](https://docs.microsoft.com/en-us/dotnet/api/system.web.ui.control.databinding) event fires.

## Files to Look At

* [Default.aspx](./CS/WebSite/Default.aspx) (VB: [Default.aspx](./VB/WebSite/Default.aspx))
* [Default.aspx.cs](./CS/WebSite/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/WebSite/Default.aspx.vb))

## Documentation

[Bind Grid View to Data at Runtime](https://docs.devexpress.com/AspNet/403612/components/grid-view/concepts/bind-to-data/bind-to-data-at-runtime#bind-in-the-databinding-event-handler)

## More Examples

[ASPxGridView - Editing an in-memory dataset](https://github.com/DevExpress-Examples/aspxgridview-editing-an-in-memory-dataset-e257)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=aspxgridview-bind-to-datatable-object&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=aspxgridview-bind-to-datatable-object&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
