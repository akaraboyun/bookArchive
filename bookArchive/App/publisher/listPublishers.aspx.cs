using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace bookArchive.App.publisher
{
    public partial class listPublishers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) {
                rptPublishers.DataSource = Classes.Publisher.getProducers();
                rptPublishers.DataBind();
            }
        }
    }
}