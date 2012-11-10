using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace bookArchive.App.Book
{
    public partial class viewBook : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) {
                drpAuthors.DataSource = Classes.Author.getAuthors();
                drpAuthors.DataValueField = "authorId";
                drpAuthors.DataTextField = "authorName";
                drpAuthors.DataBind();

                drpProducer.DataSource = Classes.Publisher.getProducers();
                drpProducer.DataValueField = "publisherId";
                drpProducer.DataTextField = "publisherName";
                drpProducer.DataBind();

                int bookId = 0;
                if (Request.QueryString["bookId"] == null) {
                    Response.Redirect("~/default.aspx");
                }
                bookId = int.Parse(Request.QueryString["bookId"].ToString());
                Session["bookId"] = bookId;
                Classes.Book b = Classes.Book.getBook(bookId);
                txtBookName.Text = b.bookName;
                drpAuthors.SelectedValue = b.authorId.ToString();
                txtIsbn.Text = b.bookIsbn;
                drpProducer.SelectedValue = b.publisherId.ToString();
                txtIndex.Text = b.bookIndex;
                txtNotes.Text = b.bookNotes;
                if (b.isDigitized == 1)
                {
                    chkIsDigitized.Checked = true;
                }
                else {
                    chkIsDigitized.Checked = false;
                }
            }
        }

        protected void btnSend_Click(object sender, EventArgs e)
        {
            Classes.Book b = new Classes.Book();
            b.bookId = int.Parse(Session["bookId"].ToString());
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
            else
            {
                b.isDigitized = 0;
            }
            b.updateBook();
            Response.Redirect("~/App/Book/listBooks.aspx");
        }
    }
}