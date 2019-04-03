<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Student_Management_System__SMS_.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
               
        <div>

            <h1>Student's Information</h1>
            <asp:Label ID="Label1" runat="server" Text="Student Name :"></asp:Label>
     <asp:GridView ID="GridView3" runat="server" AutoGenerateColumns="False" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2">
         <Columns>
              <asp:BoundField DataField="student_ID" HeaderText="student_ID" />
              <asp:BoundField DataField="student_Name" HeaderText="student_Name" />
              <asp:BoundField DataField="department" HeaderText="department" />
              <asp:BoundField DataField="phone_NO" HeaderText="phone_NO" />
              <asp:BoundField DataField="blood_Group" HeaderText="blood_Group" />
         </Columns>

         <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
         <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
         <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
         <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
         <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
         <SortedAscendingCellStyle BackColor="#FFF1D4" />
         <SortedAscendingHeaderStyle BackColor="#B95C30" />
         <SortedDescendingCellStyle BackColor="#F1E5CE" />
         <SortedDescendingHeaderStyle BackColor="#93451F" />

     </asp:GridView>

            <asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>
            
        </div>
    </form>
</body>
</html>
