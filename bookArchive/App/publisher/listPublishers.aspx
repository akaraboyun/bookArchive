<%@ Page Title="" Language="C#" MasterPageFile="~/App/MasterPages/Foundation.Master" AutoEventWireup="true" CodeBehind="listPublishers.aspx.cs" Inherits="bookArchive.App.publisher.listPublishers" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="two columns"></div>
        <div class="eight columns">
            <h5>Yayıncılar</h5>
            <table width="100%">
                <tr>
                    <td><b>Id:</b></td>
                    <td><b>Yayıncı Adı:</b></td>
                    <td><b>Detaylar:</b></td>
                    
                </tr>
                <asp:Repeater ID="rptPublishers" runat="server">
                    <ItemTemplate>
                        <tr>
                            <td><%# DataBinder.Eval(Container.DataItem, "publisherId") %></td>
                            <td><%# DataBinder.Eval(Container.DataItem, "publisherName") %></td>                            
                            <td><a href="viewPublisher.aspx?publisherId=<%# DataBinder.Eval(Container.DataItem, "publisherId") %>" class="tiny success button">Göster</a></td>
                        </tr>
                    </ItemTemplate>

                </asp:Repeater>
            </table>
        </div>
        <div class="two columns"></div>
    </div>
</asp:Content>
