<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Index
</asp:Content>


<asp:Content ID="Content3" ContentPlaceHolderID="HeadContent" runat="server">

    <script src="../../Scripts/InstructorIndex.js" type="text/javascript"></script>
    <script src="../../Services/InstructorService.svc/js" type="text/javascript"></script>

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Index</h2>
    
    <select id="instructorSelect">  
        <option></option>      
    </select>

    <div id="instructorDisplay">
    </div>

</asp:Content>

