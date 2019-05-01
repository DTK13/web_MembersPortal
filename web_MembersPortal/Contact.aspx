<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="web_MembersPortal.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <script src="Scripts/UserPage.js"></script>
    <br /><br />
    <h2>Hours of Operation</h2>
   
    <fieldset>
        <address>
        5000 Louise Drive, PO Box 40<br />
        Mechanicsburg, Pennsylvania 17055<br />
            </address>
     <strong>Call Our Support Line: </strong>  <a href="tel: (800) 237-7288"> (800) 237-7288</a>
        

    <br />
    <br />

        <strong>Support:</strong>   <a href="mailto:members1stsupport@example.com">Send Email To Support Team</a><br />
       <br />
        <br />
<table style="width:100%" class="redTable">
<thead>
<tr>
<th>Day</th>
<th>Hours</th>
</tr>
</thead>
<tfoot>
<tr>
<td colspan="2">
</td>
</tr>
</tfoot>
<tbody>
<tr>
<td>Monday-Wednesday</td>
<td>7:30 am - 5 pm</td>
</tr>
<tr>
<td>Thursday</td>
<td>7:30 am - 6 pm</td>
</tr>
<tr>
<td>Friday</td>
<td>7:30 am - 7 pm</td>
</tr>
<tr>
<td>Saturday</td>
<td>8:30 am - 2 pm</td>
</tr>
<tr>
<td>Sunday</td>
<td>Closed</td>
</tr>
</tbody>
</table>
    </fieldset>
</asp:Content>
