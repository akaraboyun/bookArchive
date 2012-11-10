<%@ Page Title="" Language="C#" MasterPageFile="~/App/MasterPages/Foundation.Master" AutoEventWireup="true" CodeBehind="viewAuthor.aspx.cs" Inherits="bookArchive.App.author.viewAuthor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="twelve columns">
            <table width="100%">
                <tr>
                    <td><b>Yazar Adı:</b></td>
                    <td>
                        <asp:TextBox ID="txtAuthorName" runat="server"></asp:TextBox></td>
                </tr>

                <tr><td></td>
                    <td style="text-align:right">
                        <asp:Button ID="btnSend" runat="server" Text="Kaydet" class="success button" OnClick="btnSend_Click" />
                    </td>
                </tr>
                
            </table>
        </div>
    </div>
</asp:Content>
