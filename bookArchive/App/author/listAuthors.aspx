<%@ Page Title="" Language="C#" MasterPageFile="~/App/MasterPages/Foundation.Master" AutoEventWireup="true" CodeBehind="listAuthors.aspx.cs" Inherits="bookArchive.App.author.listAuthors" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div class="row">
        <div class="two columns"></div>
        <div class="eight columns">
            <h5>Yazarlar</h5>
            <table width="100%">
                <tr>
                    <td><b>Id:</b></td>
                    <td><b>Yazar Adı:</b></td>
                    <td><b>Detaylar:</b></td>
                    
                </tr>
                <asp:Repeater ID="rptAuthors" runat="server">
                    <ItemTemplate>
                        <tr>
                            <td><%# DataBinder.Eval(Container.DataItem, "authorId") %></td>
                            <td><%# DataBinder.Eval(Container.DataItem, "authorName") %></td>                            
                            <td><a href="viewAuthor.aspx?authorId=<%# DataBinder.Eval(Container.DataItem, "authorId") %>" class="tiny success button">Göster</a></td>
                        </tr>
                    </ItemTemplate>

                </asp:Repeater>
            </table>
        </div>
        <div class="two columns"></div>
    </div>

</asp:Content>
