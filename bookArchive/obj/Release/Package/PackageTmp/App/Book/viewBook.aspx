<%@ Page Title="" Language="C#" MasterPageFile="~/App/MasterPages/Foundation.Master" AutoEventWireup="true" CodeBehind="viewBook.aspx.cs" Inherits="bookArchive.App.Book.viewBook" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div class="row">
        <div class="twelve columns">
            <table width="100%">
                <tr>
                    <td><b>Kitap Adı:</b></td>
                    <td>
                        <asp:TextBox ID="txtBookName" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td><b>Yazar Adı:</b></td>
                    <td>
                        <asp:DropDownList ID="drpAuthors" runat="server"></asp:DropDownList></td>
                </tr>
                <tr>
                    <td><b>ISBN:</b></td>
                    <td>
                        <asp:TextBox ID="txtIsbn" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td><b>Yayıncı:</b></td>
                    <td>
                        <asp:DropDownList ID="drpProducer" runat="server"></asp:DropDownList></td>
                </tr>
                <tr>
                    <td><b>Index:</b></td>
                    <td>
                        <asp:TextBox ID="txtIndex" runat="server" TextMode="MultiLine" Height="107px" ></asp:TextBox></td>
                </tr>
                <tr>
                    <td><b>Notlar:</b></td>
                    <td>
                        <asp:TextBox ID="txtNotes" runat="server" TextMode="MultiLine" Height="107px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td><b>Dijitize Edildi Mi?</b></td>
                    <td>
                        <asp:CheckBox ID="chkIsDigitized" runat="server" /></td>
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
