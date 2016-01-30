<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListPlaylist.aspx.cs" Inherits="YouTubePlaylist.Private.ListPlaylist" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:ListView ID="lvArticles"
        runat="server"
        ItemType="YouTubePlaylist.Models.Playlist"
        DataKeyNames="Id"
        SelectMethod="lvArticles_GetData"
        DeleteMethod="lvArticles_DeleteItem"
        UpdateMethod="lvArticles_UpdateItem"
        InsertMethod="lvArticles_InsertItem"
        InsertItemPosition="None">
        <LayoutTemplate>
            <div class="jumbotron">
                <div class="text-center">
                    <asp:HyperLink NavigateUrl="?orderBy=Name" Text="Sort by Name" runat="server" CssClass="btn btn-md-2 btn-default" />
                    <asp:HyperLink NavigateUrl="?orderBy=Date" Text="Sort by Date" runat="server" CssClass="btn btn-md-2 btn-default" />
                    <asp:HyperLink NavigateUrl="?orderBy=Rating" Text="Sort by Rating" runat="server" CssClass="btn btn-md-2 btn-default" />

                    <div class="input-group">
                        <asp:TextBox ID="tbSearch" runat="server" CssClass="form-control"></asp:TextBox>
                        <span class="input-group-btn">
                            <asp:Button ID="btnSearch" runat="server" OnClick="btnSearch_Click" Text="Serach" CssClass="btn btn-default" />
                        </span>
                    </div>
                </div>
                <table class="table table-bordered">
                    <tr>
                        <th>Name
                        </th>
                        <th>Category Name
                        </th>
                        <th>Author Name
                        </th>
                        <th>Number of Video
                        </th>
                    </tr>
                    <div runat="server" id="itemPlaceHolder" class="row"></div>
                </table>

                <div class="row">
                    <asp:DataPager ID="dataPagerArticles"
                        runat="server"
                        PageSize="5">
                        <Fields>
                            <asp:NextPreviousPagerField ShowPreviousPageButton="true" ShowLastPageButton="false" ShowNextPageButton="false" />
                            <asp:NumericPagerField />
                            <asp:NextPreviousPagerField ShowPreviousPageButton="false" ShowLastPageButton="false" ShowNextPageButton="true" />
                        </Fields>
                    </asp:DataPager>
                </div>
            </div>
        </LayoutTemplate>
        <ItemTemplate>
            <tr>
                <td>
                  <a href="/PlaylistDetails.aspx?id=<%#: Item.Id %>"> <%#: Item.Title %></a>
                </td>
                <td>
                    <a href="PlaylistByCategory.aspx?categoryName=<%#: Item.Category.Name %>"><%#:Item.Category.Name %></a>
                </td>
                <td>
                    <%#: Item.User.UserName %>
                </td>
                <td>
                    <%#: Item.Videos.Count %>
                </td>
            </tr>
        </ItemTemplate>
    </asp:ListView>

</asp:Content>
