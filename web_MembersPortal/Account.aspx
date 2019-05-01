<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master"  CodeBehind="Account.aspx.cs" Inherits="web_MembersPortal.Account" %>

<asp:Content runat="server" ContentPlaceHolderID="MainContent">

    <p>Account Page</p>
     <div class="banner">
         <br />
          <h1>Main Account</h1>
          <asp:Button ID="Button1" CssClass="btnLogin" runat="server" Text="My Profile" OnClick="btnProfile_Click" />
     </div>
    <asp:HiddenField ID="Hidden1" runat="server" />
    <fieldset class="identification">
    <h2>Savings Account</h2>
         <asp:Label ID="Label2" runat="server" Text="Record Id: "/><asp:Label ID="txtRecordId" runat="server" Text="" ></asp:Label><br /><br />
          <asp:Label ID="lblUsername" runat="server" Text="UserName: "/><asp:Label ID="txtUsername" runat="server" Text="" ></asp:Label><br /><br />
        <asp:Label ID="lblMemberName" runat="server" Text="Description: "/><asp:Label ID="txtDescription" runat="server" Text="" ></asp:Label><br /><br />
             <asp:Label ID="Label7" runat="server" Text="Current Balance: "/><asp:Label ID="txtbalance" runat="server" Text="" ></asp:Label><br /><br />
          <asp:Label ID="Label8" runat="server" Text="Last Activity Date: "/><asp:Label ID="txtDate" runat="server" Text="" ></asp:Label><br /><br />
        
      
    </fieldset>
     <br />

    <br />
    <fieldset class="ainformation">
        <h2>Checking</h2>
             <asp:Label ID="Label3" runat="server" Text="Record Id: "/><asp:Label ID="txtCheckingId" runat="server" Text="" ></asp:Label><br /><br />
          <asp:Label ID="Label6" runat="server" Text="UserName: "/><asp:Label ID="txtCheckingUsername" runat="server" Text="" ></asp:Label><br /><br />
        <asp:Label ID="Label10" runat="server" Text="Description: "/><asp:Label ID="txtCheckingDesc" runat="server" Text="" ></asp:Label><br /><br />
          <asp:Label ID="Label1" runat="server" Text="Current Balance: "/><asp:Label ID="txtCheckingBalance" runat="server" Text="" ></asp:Label><br /><br />
          <asp:Label ID="Label4" runat="server" Text="Last Activity Date: "/><asp:Label ID="txtCheckingDate" runat="server" Text="" ></asp:Label><br /><br />
        </fieldset>
    <br />
       <fieldset class="ainformation">
        <h2>Loans</h2>
             <asp:Label ID="Label5" runat="server" Text="Record Id: "/><asp:Label ID="txtLoanId" runat="server" Text="" ></asp:Label><br /><br />
          <asp:Label ID="Label11" runat="server" Text="UserName: "/><asp:Label ID="txtLoanUser" runat="server" Text="" ></asp:Label><br /><br />
        <asp:Label ID="Label13" runat="server" Text="Description: "/><asp:Label ID="txtLoanDesc" runat="server" Text="" ></asp:Label><br /><br />
          <asp:Label ID="Label15" runat="server" Text="Current Balance: "/><asp:Label ID="txtLoanBalance" runat="server" Text="" ></asp:Label><br /><br />
          <asp:Label ID="Label17" runat="server" Text="Last Activity Date: "/><asp:Label ID="txtLastActivity" runat="server" Text="" ></asp:Label><br /><br />
           <asp:Label ID="Label9" runat="server" Text="Payment Due Date: "/><asp:Label ID="txtDueDate" runat="server" Text="" ></asp:Label><br /><br />
           <asp:Label ID="Label12" runat="server" Text="Minimum Payment Due: "/><asp:Label ID="txtPayment" runat="server" Text="" ></asp:Label><br /><br />
        </fieldset>
    <br />
      <fieldset class="ainformation">
        <h2>Certificate</h2>
             <asp:Label ID="Label14" runat="server" Text="Record Id: "/><asp:Label ID="txtcId" runat="server" Text="" ></asp:Label><br /><br />
          <asp:Label ID="Label18" runat="server" Text="UserName: "/><asp:Label ID="txtcUsername" runat="server" Text="" ></asp:Label><br /><br />
        <asp:Label ID="Label20" runat="server" Text="Description: "/><asp:Label ID="txtcDesc" runat="server" Text="" ></asp:Label><br /><br />
          <asp:Label ID="Label22" runat="server" Text="Current Balance: "/><asp:Label ID="txtcBalance" runat="server" Text="" ></asp:Label><br /><br />
          <asp:Label ID="Label24" runat="server" Text="Last Activity Date: "/><asp:Label ID="txtcActivityDate" runat="server" Text="" ></asp:Label><br /><br />
           <asp:Label ID="Label26" runat="server" Text="Interest Rate: "/><asp:Label ID="txtInterest" runat="server" Text="" ></asp:Label><br /><br />
           <asp:Label ID="Label28" runat="server" Text="Maturity Date: "/><asp:Label ID="txtMaturityDate" runat="server" Text="" ></asp:Label><br /><br />
        </fieldset>
</asp:Content>