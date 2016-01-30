<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CreatePlaylist.aspx.cs" Inherits="YouTubePlaylist.Private.CreatePlaylist" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="form-group">
        <asp:Label runat="server" AssociatedControlID="tbTitle" CssClass="col-md-2 control-label">Title</asp:Label>
        <div class="col-md-10">
            <asp:TextBox runat="server" ID="tbTitle" CssClass="form-control" />
            <asp:RequiredFieldValidator runat="server" ControlToValidate="tbTitle"
                CssClass="text-danger" ErrorMessage="The Title field is required." />
        </div>
    </div>
    <div class="form-group">
        <asp:Label runat="server" AssociatedControlID="tbDescription" CssClass="col-md-2 control-label">Description</asp:Label>
        <div class="col-md-10">
            <asp:TextBox runat="server" ID="tbDescription" CssClass="form-control" />
            <asp:RequiredFieldValidator runat="server" ControlToValidate="tbDescription"
                CssClass="text-danger" ErrorMessage="The Description field is required." />
        </div>
    </div>
    <div class="form-group">
        <asp:Label runat="server" AssociatedControlID="tbVideo" CssClass="col-md-2 control-label">Video</asp:Label>
        <div class="col-md-10">
            <asp:TextBox runat="server" ID="tbVideo" CssClass="form-control" />
        </div>
    </div>
     <div class="form-group">
        <asp:Label runat="server" AssociatedControlID="tbVideo" CssClass="col-md-2 control-label">Video</asp:Label>
        <div class="col-md-10">
            <asp:DropDownList runat="server" ID="ddlCategories"
                    ItemType="YouTubePlaylist.Models.Category"
                    DataValueField="Id"
                    DataTextField="Name"
                    SelectMethod="ddlCategories_GetData"/>
        </div>
    </div>
    <div class="form-group">
        <div class="col-md-offset-2 col-md-10">
            <asp:Button ID="btnCreatePlaylist" runat="server" OnClick="btnCreatePlaylist_Click" Text="Register" CssClass="btn btn-default" />
        </div>
    </div>
</asp:Content>
