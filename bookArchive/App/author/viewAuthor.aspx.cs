using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace bookArchive.App.author
{
    public partial class viewAuthor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) {
                int authorId = 0;
                if (Request.QueryString["authorId"] != null)
                {
                    authorId = int.Parse(Request.QueryString["authorId"]);
                    Session["authorId"] = authorId;
                    txtAuthorName.Text = Classes.Author.getAuthorName(authorId);
                    
                }
                else {
                    Response.Redirect("~/default.aspx");
                }
                
            }
        }

        protected void btnSend_Click(object sender, EventArgs e)
        {
            int authorId = int.Parse(Session["authorId"].ToString());
            Classes.Author a = new Classes.Author();
            a.authorId = authorId;
            a.authorName = txtAuthorName.Text;
            a.updateAuthor();
            Response.Redirect("~/App/author/listAuthors.aspx");
        }
    }
}