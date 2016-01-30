<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PlaylistDetails.aspx.cs" Inherits="YouTubePlaylist.PlaylistDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:FormView ID="fvPlaylistDetails"
        runat="server"
        ItemType="YouTubePlaylist.Models.Playlist"
        SelectMethod="fvPlaylistDetails_GetItem"
        CssClass="table">
        <ItemTemplate>
            <div class="text-center">
                <h2><%#: Item.Title %></h2>
                <p>
                    <%#: Item.Description %>
                </p>
                <p>
                    Category : <a href="PlaylistByCategory.aspx?categoryName=<%#: Item.Category.Name%>"><%#:Item.Category.Name %></a>
                </p>
                <p>
                    Author : <%#: Item.User.UserName %>
                </p>
                <p>Rating: <%#:Item.Ratings.Count== 0 ? 0 : Item.Ratings.Average(x => x.Value) %></p>
                <div>

                    <asp:Repeater ID="rptVideos"
                        runat="server"
                        ItemType="YouTubePlaylist.Models.Video"
                        DataSource="<%# Item.Videos %>">
                        <HeaderTemplate>
                            <h2 class="text-center">Videos</h2>
                        </HeaderTemplate>
                        <ItemTemplate>
                            <div class="row">
                                <div class="col-md-6">
                                    <iframe id="ytplayer" type="text/html" width="400" height="300"
                                        src="https://www.youtube.com/embed/<%# this.GetUrls(Item.Url) %>"
                                        frameborder="0" />
                                </div>
                                <div class="col-md-3 text-center">
                                  <a href="<%#: Item.Url %>">Link to YouTube</a>
                              </div>
                            </div>
                              
                        </ItemTemplate>
                    </asp:Repeater>
                </div>
            </div>
        </ItemTemplate>
    </asp:FormView>

</asp:Content>
