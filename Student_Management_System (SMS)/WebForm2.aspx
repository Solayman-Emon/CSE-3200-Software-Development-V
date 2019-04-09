<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="Student_Management_System__SMS_.WebForm2" %>

<%@ Register assembly="System.Web.Mvc" namespace="System.Web.Mvc" tagprefix="cc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Text="Student ID"></asp:Label>
&nbsp;&nbsp;
        <p>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </p>
        Student Name<p>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </p>
        <p>
            Department</p>
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <p>
            Phone No</p>
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        <p>
            Blood Group</p>
        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Insert" />
            
        </p>
    </form>
</body>
</html>
