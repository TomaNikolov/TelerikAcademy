<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="YouTubePlaylist.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
 <h1 class="text-center">Most popular playlists</h1>
    <asp:Repeater ID="rptPopularPlaylists" 
        runat="server"
        ItemType="YouTubePlaylist.Models.Playlist"
        SelectMethod="rptPopularPlaylists_GetData">
        <ItemTemplate>
            <div class="col-md-6">
            <h2><a href="/PlaylistDetails.aspx?id=<%#: Item.Id %>"> <%#: Item.Title %></a></h2>
                <p>
                    Category : <a href="PlaylistByCategory.aspx?categoryName=<%#: Item.Category.Name %>"> <%#:Item.Category.Name %></a>
                </p>
                <p>
                    Authot : <%#: Item.User.UserName %>
                </p>
                <p>Rating: <%#:Item.Ratings.Count== 0 ? 0 : Item.Ratings.Average(x => x.Value) %></p>
                </div>
        </ItemTemplate>
    </asp:Repeater>
</asp:Content>
