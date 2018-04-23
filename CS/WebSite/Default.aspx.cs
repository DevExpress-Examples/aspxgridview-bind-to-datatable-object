using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using DevExpress.Web.ASPxGridView;

public partial class Grid_Bind_RunTimeBinding : System.Web.UI.Page {
    protected void Page_Init(object sender, EventArgs e) {
        // Assign the data source in Page_Init
        grid.DataSource = GetTable();
        //Bind the grid on every request.
        grid.DataBind();
    }

    protected void Page_Load(object sender, EventArgs e) {
        if(!IsPostBack && !IsCallback) {
            //Create columns on the first load.
            GridViewDataColumn id = new GridViewDataColumn();
            id.FieldName = "id";
            grid.Columns.Add(id);
            GridViewDataColumn data = new GridViewDataColumn();
            data.FieldName = "data";
            grid.Columns.Add(data);
        } 
    }

    DataTable GetTable() {
        //You can store a DataTable in the session state
        DataTable table = Session["Table"] as DataTable;
        if(table == null) {
            table = new DataTable();
            table.Columns.Add("id", typeof(int));
            table.Columns.Add("data", typeof(String));
            for(int n = 0; n < 100; n++) {
                table.Rows.Add(n, "row" + n.ToString());
            }
            Session["Table"] = table;
        }
        //Otherwise you have to create a DataTable instance on every request:
        //DataTable table = new DataTable();
        //table.Columns.Add("id", typeof(int));
        //table.Columns.Add("data", typeof(String));
        //for(int n = 0; n < 100; n++) {
        //    table.Rows.Add(n, "row" + n.ToString());
        //}
        return table;
    }
}
