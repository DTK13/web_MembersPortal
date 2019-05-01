
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="web_MembersPortal.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
        <link rel="stylesheet" href="Content/Site.css"/>
 

    <title>Login</title>
       <meta name="viewport" content="width=device-width, initial-scale=1.0" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <fieldset class="fieldsetlogin">
                <br />
            <label for="textbox" class="labels" >User Name:</label>
                <asp:TextBox ID="txtUsername" CssClass="textboxLogin" runat="server"></asp:TextBox>
           <br />
                <br />
              <label for="textbox" class="labels"> Password:&nbsp;&nbsp; </label>
                <asp:TextBox ID="txtPassword" CssClass="textboxLogin" runat="server" TextMode="Password"></asp:TextBox>
            <br />
                <br />
                <div style="margin-left: auto; margin-right: auto; text-align: center;">
                 <asp:Button ID="btnLogin" CssClass="btnLogin" runat="server" Text="Login" OnClick="Login_Click" /> <asp:Button ID="btnReset" CssClass="btnLogin" runat="server" Text="Reset" OnClick="btnReset_Click" />
                </div>
                    </fieldset>
            <br />
            <div style="margin-left: auto; margin-right: auto; text-align: center;">
                         <asp:Label ID="txtResponse" runat="server" CssClass="txtResponse" Visible="False"></asp:Label> 
            </div>
            <br />
            <br />
  
                
        </div>
    </form>
     <footer>
                <img src="\images\logo.png" width="214" height="66" />
                <br />
                <br />
                <b>&copy; <%: DateTime.Now.Year %> Members 1st FCU. All Rights Reserved.</b>
         <br />
         Learn More: <a href="About.aspx">About</a><br />
         Contact Us:<a href="Contact.aspx">Contact</a>
            </footer>
    
</body>

</html>
