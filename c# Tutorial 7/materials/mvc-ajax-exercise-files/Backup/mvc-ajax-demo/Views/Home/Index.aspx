<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="indexTitle" ContentPlaceHolderID="TitleContent" runat="server">
    Home Page
</asp:Content>

<asp:Content runat="server" ContentPlaceHolderID="HeadContent">
    <script src="../../Scripts/serverTime.js" type="text/javascript"></script>
</asp:Content>

<asp:Content ID="indexContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%= Html.Encode(ViewData["Message"]) %></h2>
    <p>
        To learn more about ASP.NET MVC visit <a href="http://asp.net/mvc" title="ASP.NET MVC Website">http://asp.net/mvc</a>.
    </p>
            
    <div id="timeDisplay">  
        <%= Ajax.ActionLink("Click here to show the server time!",
                            "ServerTime", 
                             new AjaxOptions {
                                   LoadingElementId="loadingDisplay",
                                   Confirm="Are you really sure?", 
                                  HttpMethod="GET",
                                  UpdateTargetId="timeDisplay"                                 
                                 })%>             
    </div>
    <div id="loadingDisplay" style="display:none">
        <img src="../../Content/spinner.gif" />
    </div>
    
    
</asp:Content>
