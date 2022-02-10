using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LINKTOSQL2
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            if (!Page.IsPostBack)
            {
                GridView1.DataSource = from ed in db.EmployeeDetails
                                       select new
                                       {
                                           EmployeeName = ed.EmpName,
                                           Location = ed.Location,
                                           Gender = ed.Gender
                                       };
                GridView1.DataBind();
            }


        }
    }
}