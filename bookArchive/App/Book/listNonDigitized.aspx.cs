using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace bookArchive.App.Book
{
    public partial class listNonDigitized : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) {
                rptBooks.DataSource = Classes.Book.listNonDigitizedBooks();
                rptBooks.DataBind();
            }
        }
    }
}