<%@ Page Title="" Language="C#" MasterPageFile="~/App/MasterPages/Foundation.Master" AutoEventWireup="true" CodeBehind="listBooks.aspx.cs" Inherits="bookArchive.App.Book.listBooks" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        
        <div class="two columns"></div>
        <div class="eight columns">
            <h5>Tüm Kitaplar</h5>
            <table>
                <tr>
                    <td><b>#:</b></td>
                    <td><b>Kitap Adı:</b></td>
                    <td><b>Yazar Adı:</b></td>
                    <td><b>ISBN:</b></td>
                    <td><b>Yayıncı:</b></td>
                    <td><b>Detay:</b></td>
                </tr>
                <asp:Repeater ID="rptBooks" runat="server">
                    <ItemTemplate>
                        <tr>
                            <td><%# DataBinder.Eval(Container.DataItem, "orderNumber") %></td>
                            <td><%# DataBinder.Eval(Container.DataItem, "bookName") %></td>
                            <td><%# DataBinder.Eval(Container.DataItem, "authorName") %></td>
                            <td><%# DataBinder.Eval(Container.DataItem, "bookIsbn") %></td>
                            <td><%# DataBinder.Eval(Container.DataItem, "publisherName") %></td>
                            <td><a href="viewBook.aspx?bookId=<%# DataBinder.Eval(Container.DataItem, "bookId") %>" class="tiny success button" >Göster</a></td>
                        </tr>
                    </ItemTemplate>

                </asp:Repeater>
            </table>
        </div>
        <div class="two columns"></div>
    </div>

</asp:Content>
