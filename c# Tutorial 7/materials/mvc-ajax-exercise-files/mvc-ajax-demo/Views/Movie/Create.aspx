<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<MovieTheaterDomain.Movie>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Create
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="HeadContent" runat="server">

    <script src="../../Scripts/jquery.validate.min.js" type="text/javascript"></script>

    <script src="../../Scripts/jquery-ui-1.7.1.custom.min.js" type="text/javascript"></script>

    <script src="../../Scripts/MovieCreate.js" type="text/javascript"></script>

    <link href="../../Content/jquery-ui-1.7.1.custom.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>
        Create</h2>
    <%= Html.ValidationSummary("Create  was unsuccessful. Please correct the errors and try again.") %>
    <div class="create">
        <% using (Html.BeginForm())
           {%>
        <fieldset>
            <legend>Fields</legend>
            <p>
                <label for="Title">
                    Title:</label>
                <%= Html.TextBox("Title") %>
                <%= Html.ValidationMessage("Title", "*") %>
            </p>
            <p>
                <label for="ReleaseDate">
                    ReleaseDate:</label>
                <%= Html.TextBox("ReleaseDate") %>
                <%= Html.ValidationMessage("ReleaseDate", "*") %>
            </p>
            <p>
                <input type="submit" value="Create" />
            </p>
        </fieldset>
        <% } %>
    </div>
    <div>
        <%=Html.ActionLink("Back to List", "Index") %>
    </div>
</asp:Content>
