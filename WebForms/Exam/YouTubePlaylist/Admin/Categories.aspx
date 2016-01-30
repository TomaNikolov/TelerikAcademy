<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Categories.aspx.cs" Inherits="YouTubePlaylist.Admin.Categories" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <asp:GridView ID="gvCategories"
        runat="server"
        ItemType="YouTubePlaylist.Models.Category"
        SelectMethod="gvCategories_GetData"
        DataKeyNames="Id"
        AllowSorting="true"
        AllowPaging="true"
        PageSize="5"
        AutoGenerateColumns="false"
        UpdateMethod="gvCategories_UpdateItem"
        DeleteMethod="gvCategories_DeleteItem"
         CssClass="table">
        <Columns>
            <asp:BoundField SortExpression="Id" readonly="true" HeaderText="Id" DataField="Id" />
            <asp:BoundField SortExpression="Name" HeaderText="Name" DataField="Name" />
            <asp:BoundField SortExpression="Playlists.Count" readonly="true" HeaderText="Count" DataField="Playlists.Count" />
            <asp:CommandField ShowEditButton="true" ControlStyle-CssClass="btn btn-info" />
            <asp:CommandField ShowDeleteButton="true" ControlStyle-CssClass="btn btn-danger" />
        </Columns>
    </asp:GridView>
    <div class="row">
       
        <asp:TextBox ID="tbCategoryInsert" runat="server"></asp:TextBox>
        <asp:Button ID="btnInsert" runat="server" Text="Create" OnClick="btnInsert_Click" CssClass="btn btn-info" />
        <asp:Button ID="tbnCancel" runat="server" Text="Cancel" OnClick="tbnCancel_Click" CssClass="btn btn-danger" />
    </div>
</asp:Content>
