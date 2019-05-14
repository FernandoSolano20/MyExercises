<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<MovieTheaterDomain.Movie>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Index
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="HeadContent" runat="server">
    
    <link href="../../Content/jquery.autocomplete.css" rel="stylesheet" type="text/css" />
    <script src="../../Scripts/jquery.autocomplete.min.js" type="text/javascript"></script>
    <script src="../../Scripts/MovieIndex.js" type="text/javascript"></script>
    
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Index</h2>
     <% using (Ajax.BeginForm("Index", "Movie", 
                            new AjaxOptions {
                               OnFailure="searchFailed", 
                               HttpMethod="GET",
                               UpdateTargetId="movieTable",                                
                            }))
                       
       { %>
            <input id="searchBox" type="text" name="query" />
            <input type="submit" value="Search" />            
    <% } %>
    
    <div id="movieTable">
        <% Html.RenderPartial("_MovieTable", Model); %>
   </div>

    <p>
        <%= Html.ActionLink("Create New", "Create") %>
    </p>

</asp:Content>

