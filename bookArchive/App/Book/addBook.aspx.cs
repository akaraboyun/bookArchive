using bookArchive.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace bookArchive.App.Book
{
    public partial class addBook : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) {
                
                drpAuthors.DataSource = Author.getAuthors();               
                drpAuthors.DataValueField = "authorId";
                drpAuthors.DataTextField = "authorName";
                drpAuthors.DataBind();

                drpProducer.DataSource = Publisher.getProducers();
                drpProducer.DataValueField = "publisherId";
                drpProducer.DataTextField = "publisherName";
                drpProducer.DataBind();
            }
        }

        protected void btnSend_Click(object sender, EventArgs e)
        {
            Classes.Book b = new Classes.Book();
            b.bookName = txtBookName.Text;
            b.authorId = int.Parse(drpAuthors.SelectedValue);
            b.bookIsbn = txtIsbn.Text;
            b.publisherId = int.Parse(drpProducer.SelectedValue);
            b.bookIndex = txtIndex.Text;
            b.bookNotes = txtNotes.Text;
            if (chkIsDigitized.Checked)
            {
                b.isDigitized = 1;
            }
            else {
                b.isDigitized = 0;
            }
            b.addBook();
            Response.Redirect("addBook.aspx");
        }
    }
}