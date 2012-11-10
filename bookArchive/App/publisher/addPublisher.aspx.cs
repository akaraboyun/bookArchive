using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace bookArchive.App.publisher
{
    public partial class addPublisher : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSend_Click(object sender, EventArgs e)
        {
            Classes.Publisher p = new Classes.Publisher();
            p.publisherName = txtPublisherName.Text;
            p.addPublisher();
            Response.Redirect("~/default.aspx");
        }
    }
}