using bookArchive.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace bookArchive.App.author
{
    public partial class addAuthor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) { }
        }

        protected void btnSend_Click(object sender, EventArgs e)
        {
            Author a = new Author();
            a.authorName = txtAuthorName.Text;
            a.addAuthor();
            Response.Redirect("~/default.aspx");
        }
    }
}