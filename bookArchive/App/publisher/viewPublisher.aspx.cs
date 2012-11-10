using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace bookArchive.App.publisher
{
    public partial class viewPublisher : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) {
                int publisherId = 0;
                if (Request.QueryString["publisherId"] != null)
                {
                    publisherId = int.Parse(Request.QueryString["publisherId"].ToString());
                    Session["publisherId"] = publisherId;
                    txtPublisherName.Text = Classes.Publisher.getPublisherName(publisherId);
                }
                else {
                    Response.Redirect("~/default.aspx");
                }

            }
        }

        protected void btnSend_Click(object sender, EventArgs e)
        {
            int publisherId = int.Parse(Session["publisherId"].ToString());
            Classes.Publisher p = new Classes.Publisher();
            p.publisherName = txtPublisherName.Text;
            p.updatePublisher(publisherId);
            Response.Redirect("~/App/publisher/listPublishers.aspx");
        }
    }
}