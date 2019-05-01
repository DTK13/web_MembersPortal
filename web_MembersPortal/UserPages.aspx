<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="UserPages.aspx.cs" Inherits="web_MembersPortal.UserPages" %>


<asp:Content runat="server" ContentPlaceHolderID="MainContent">
   <script src="Scripts/Logout.js"></script>
    <p>UserPage</p>
     <div class="banner">
         <br />
          <h1>Welcome to your user profile <asp:Label ID="txtactiveuser" runat="server" Text=""></asp:Label>!</h1>
     </div>

    <fieldset class="identification">
        <h2>Identification</h2>
         <asp:Label ID="Label2" runat="server" Text="Record Id: "/><asp:Label ID="txtRecordId" runat="server" Text="" ></asp:Label><br /><br />
          <asp:Label ID="lblUsername" runat="server" Text="UserName: "/><asp:Label ID="txtUsername" runat="server" Text="" ></asp:Label><br /><br />
        <asp:Label ID="lblMemberName" runat="server" Text="Member Name: "/><asp:Label ID="txtName" runat="server" Text="" ></asp:Label><br /><br />
        <asp:Button ID="btnAccount" CssClass="btnLogin" runat="server" Text="View Accounts" onclick="btnAccount_Click" Width="119px"/>
        <br />
        <br />
        <div style="margin-left: auto; margin-right: auto; text-align: center;">
                         <asp:Label ID="txtResponse" runat="server" CssClass="txtResponse" Visible="False"></asp:Label> 
            </div>
      <br />
        <br />
    </fieldset>
    <asp:HiddenField ID="hidden1" runat="server" />
    <asp:HiddenField ID="hidden2" runat="server" />
    <asp:HiddenField ID="hidden3" runat="server" />
 <div class="container1">
     <br />
    <fieldset class="address">
        <h2>Information</h2>
          
        <asp:Label ID="Label4" runat="server" Text="Street Address: "></asp:Label><br />
        <asp:TextBox ID="txtstreetAddress" CssClass="addresstext"  runat="server" ToolTip="Required"></asp:TextBox><br />
         <asp:Label ID="Label5" runat="server" Text="City: "></asp:Label><br />
        <asp:TextBox ID="txtcity" CssClass="addresstext"  runat="server" ToolTip="Required"></asp:TextBox><br />
         <asp:Label ID="Label6" runat="server" Text="State: "></asp:Label><br />
        <asp:TextBox ID="txtState" CssClass="addresstext"  runat="server" ToolTip="Required"></asp:TextBox><br />
         <asp:Label ID="Label7" runat="server" Text="Zip Code: "></asp:Label><br />
        <asp:TextBox ID="txtzipcode"  CssClass="addresstext" runat="server" ToolTip="Required"></asp:TextBox><br />
    </fieldset>

      <fieldset class="cinformation">
            <h2>Contact Info</h2>

        <asp:Label ID="Label8" runat="server" Text="Home Phone Number: "></asp:Label><br />
        <asp:TextBox ID="txtHomePhone" CssClass="addresstext"  runat="server" ToolTip="Please add  &quot;-&quot; "></asp:TextBox><br />

         <asp:Label ID="Label9" runat="server" Text="Mobile Phone Number: "></asp:Label><br />
        <asp:TextBox ID="txtMobilePhone" CssClass="addresstext"  runat="server" ToolTip="Please Add &quot;-&quot;"></asp:TextBox><br />

         <asp:Label ID="Label10" runat="server" Text="Email Address: "></asp:Label><br />
        <asp:TextBox ID="txtEmailAddress" CssClass="addresstext"  runat="server" ToolTip="Must be a valid email addresss"></asp:TextBox><br />
        </fieldset>
     <fieldset class="update">
         <asp:Button ID="Button1" CssClass="btnLogin" runat="server" Text="Update" onclick="btnUpdate_Click" />
     </fieldset>
    </div>
        <script>
        document.onload= function setuser() {
            var user = document.getElementById("<%=hidden1.ClientID%>").value;
            console.log(user);

            if (user !== "DTK13") {
                window.location.href = "/Login";
            }
          
        }
    </script>
</asp:Content>
