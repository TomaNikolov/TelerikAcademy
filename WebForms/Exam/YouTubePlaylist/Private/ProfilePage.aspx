<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProfilePage.aspx.cs" Inherits="YouTubePlaylist.Private.ProfilePage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1 class="text-center">Profile page</h1>
    <asp:FormView ID="fvProfile"
        runat="server"
        ItemType="YouTubePlaylist.Models.User"
        DataKeyNames="Id"
        SelectMethod="fvProfile_GetItem"
        UpdateMethod="fvProfile_UpdateItem">
        <HeaderTemplate>
            <div class="text-center">
                <h2>User name: <%#: Item.UserName %>
                </h2>
                <div class="row">
                    <div>
                        <img src="<%#: Item.ImageUrl %>" class="img-rounded" alt="Cinque Terre" width="304" height="236">
                    </div>

                </div>
        </HeaderTemplate>
        <ItemTemplate>
            <div class="row">
                <div class="jumbotron">
                    <p>
                        Emails : <%#: Item.UserName %>
                    </p>
                    <p>
                        Firs Name : <%#: Item.FirstName %>
                    </p>
                    <p>
                        Last Name : <%#: Item.LastName %>
                    </p>
                    <p>
                        Last Name : <%#: Item.LastName %>
                    </p>
                    <p>
                        Facebook Url : <%#: Item.FacebookUrl %>
                    </p>
                    <p>
                        You Tube Url : <%#: Item.YouTubeUrl %>
                    </p>
                    <asp:Repeater ID="rptPlaylists"
                        runat="server"
                        ItemType="YouTubePlaylist.Models.Playlist"
                        SelectMethod="rptPlaylists_GetData">
                        <HeaderTemplate>
                            <div>
                                PlayLists:
                            </div>
                        </HeaderTemplate>
                        <ItemTemplate>
                            <div>
                                <a href="/PlaylistDetails.aspx?id=<%#: Item.Id %>"><%#:Item.Title %></a>
                            </div>
                        </ItemTemplate>
                    </asp:Repeater>
                </div>
            </div>
            <asp:LinkButton ID="EditButton"
                Text="Edit"
                CommandName="Edit"
                runat="server"
                CssClass="btn btn-info" />
            </div>
        </ItemTemplate>
        <EditItemTemplate>


            <div class="row">

                <p class="text-danger">
                    <asp:Literal runat="server" ID="ErrorMessage" />
                </p>

                <div class="form-horizontal">
                    <h4>Edit</h4>
                    <hr />
                    <asp:ValidationSummary runat="server" CssClass="text-danger" />
                    <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="FirstName" CssClass="col-md-2 control-label">First Name</asp:Label>
                        <div class="col-md-10">
                            <asp:TextBox runat="server" ID="FirstName" CssClass="form-control" Text="<%#: BindItem.FirstName %>" />
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="FirstName"
                                CssClass="text-danger" ErrorMessage="The FirstName field is required." />
                        </div>
                    </div>
                    <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="LastName" CssClass="col-md-2 control-label">Last Name</asp:Label>
                        <div class="col-md-10">
                            <asp:TextBox runat="server" ID="LastName" CssClass="form-control" Text="<%#: BindItem.LastName %>" />
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="LastName"
                                CssClass="text-danger" ErrorMessage="The FirstName field is required." />
                        </div>
                    </div>
                    <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="ImageUrl" CssClass="col-md-2 control-label"> Image Url</asp:Label>
                        <div class="col-md-10">
                            <asp:TextBox runat="server" ID="ImageUrl" CssClass="form-control" Text="<%#: BindItem.ImageUrl %>" />
                        </div>
                    </div>
                    <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="FaceBookUrl" CssClass="col-md-2 control-label">FaceBook Url</asp:Label>
                        <div class="col-md-10">
                            <asp:TextBox runat="server" ID="FaceBookUrl" CssClass="form-control" Text="<%#: BindItem.FacebookUrl %>" />
                        </div>
                    </div>
                    <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="YouTubeUrl" CssClass="col-md-2 control-label">YouTube Url</asp:Label>
                        <div class="col-md-10">
                            <asp:TextBox runat="server" ID="YouTubeUrl" CssClass="form-control" Text="<%#: BindItem.YouTubeUrl %>" />
                        </div>
                    </div>
                </div>
            </div>
            <asp:LinkButton ID="EditButton"
                Text="Update"
                CommandName="Update"
                runat="server"
                CssClass="btn btn-info" />
        </EditItemTemplate>
    </asp:FormView>
</asp:Content>
