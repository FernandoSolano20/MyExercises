<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<mvc_infrastructure.Models.TimeModel>" %>

<asp:Content ID="indexTitle" ContentPlaceHolderID="TitleContent" runat="server">
    Home Page
</asp:Content>

<asp:Content ID="indexContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%= Html.Encode(ViewData["Message"]) %></h2>
    <p>
        To learn more about ASP.NET MVC visit <a href="http://asp.net/mvc" title="ASP.NET MVC Website">http://asp.net/mvc</a>.
    </p>
    <p>
        <%= Html.Encode(Model.ControllerTime.ToLongTimeString()) %>
    </p>
    <p>
        <%= Html.Encode(DateTime.Now.ToLongTimeString()) %>
    </p>
    <p>
        <% Response.WriteSubstitution(ctx => DateTime.Now.ToLongTimeString()); %>
    </p>

    
    <% using (Html.BeginForm()) { %>
    
        <input type="text" name="parameter" />
        <input type="submit" />
    
    <%} %>
    
    
</asp:Content>
