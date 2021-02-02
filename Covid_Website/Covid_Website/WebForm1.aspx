<%@ Page Async="true" Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Covid_Website.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Covid case reports</title>
    <style type="text/css">
        #form1 {
            height: 923px;
        }
    </style>
</head>
<body style="min-width:1333px; background-image: url('covid.jpg'); background-repeat: no-repeat; background-attachment: fixed; background-size: 100% 100%">
    <form id="form1" runat="server">
        <asp:Panel ID="Panel2" runat="server" BackColor="#6666FF" Height="244px" HorizontalAlign="Center" BorderStyle="Ridge" Width="100%">            
            <asp:Label ID="Label1" runat="server" BackColor="#FF6666" Font-Bold="True" Font-Size="XX-Large" style="text-align:center;" Text="Welcome to Covid case reports website" Width="100%"></asp:Label>
            <br />
            <br />
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" BorderColor="Black" Font-Bold="True" Font-Size="20pt" Text="Label" Font-Names="Sitka Banner"></asp:Label>
            <br />
            <br />
            <br />
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Font-Size="20pt" Font-Strikeout="False" Text="The reports are being represented analytically in the table bellow:" Font-Names="Sitka Banner"></asp:Label>
        </asp:Panel>
        <br />
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server" AllowSorting="True" AutoGenerateColumns="False" BackColor="Black" BorderColor="White" BorderStyle="None" BorderWidth="2px" CellPadding="5" CellSpacing="2" DataSourceID="SqlDataSource1" EnableTheming="True" Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Size="15pt" GridLines="None" Height="147px" HorizontalAlign="Center" Font-Names="Sitka Banner">
            <AlternatingRowStyle Font-Bold="False" HorizontalAlign="Left" />
            <Columns>
                <asp:BoundField DataField="Full_name" HeaderText="Full_name" SortExpression="Full_name" />
                <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
                <asp:BoundField DataField="Underlying_diseases" HeaderText="Underlying_diseases" SortExpression="Underlying_diseases" />
                <asp:BoundField DataField="Date_of_record" HeaderText="Date_of_record" SortExpression="Date_of_record" />
                <asp:BoundField DataField="Time_of_record" HeaderText="Time_of_record" SortExpression="Time_of_record" />
                <asp:BoundField DataField="Phone_number" HeaderText="Phone_number" SortExpression="Phone_number" />
                <asp:BoundField DataField="Home_address" HeaderText="Home_address" SortExpression="Home_address" />
                <asp:BoundField DataField="Gender" HeaderText="Gender" SortExpression="Gender" />
                <asp:BoundField DataField="Age" HeaderText="Age" SortExpression="Age" />
            </Columns>
            <EditRowStyle Wrap="True" />
            <FooterStyle BackColor="#C6C3C6" ForeColor="Black" />
            <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#E7E7FF" />
            <PagerStyle BackColor="#C6C3C6" ForeColor="Black" HorizontalAlign="Right" />
            <RowStyle BackColor="#DEDFDE" BorderColor="Black" ForeColor="Black" />
            <SelectedRowStyle BackColor="#9471DE" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#594B9C" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#33276A" />
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Covid_casesConnectionString %>" ProviderName="<%$ ConnectionStrings:Covid_casesConnectionString.ProviderName %>" SelectCommand="SELECT * FROM [Covid_cases]"></asp:SqlDataSource>
        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:Panel ID="Panel1" runat="server" Height="236px" HorizontalAlign="Center">            
            <asp:Label ID="Label4" runat="server" Font-Bold="True" Font-Overline="False" Font-Size="X-Large" Font-Underline="False" style="margin-left: -1%" Text="Age reports" BackColor="#6666FF" ForeColor="Black" BorderStyle="Ridge" Font-Names="Sitka Banner"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label5" runat="server" Font-Bold="True" Font-Size="X-Large" Font-Underline="False" Text="Gender reports" BackColor="#6666FF" ForeColor="Black" BorderStyle="Ridge" Font-Names="Sitka Banner"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label6" runat="server" Font-Bold="True" Font-Size="X-Large" Font-Underline="False" Text="Date reports" BackColor="#6666FF" ForeColor="Black" BorderStyle="Ridge" Font-Names="Sitka Banner"></asp:Label>
            <br />
            <br />
            <asp:TextBox ID="TextBox1" runat="server" Font-Bold="True" Font-Size="Large" ForeColor="Red" Height="100px" ReadOnly="True" style=" resize: none; " TextMode="MultiLine" Width="330px" BackColor="#CCCCFF"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox2" runat="server" Font-Bold="True" Font-Size="Large" ForeColor="Red" Height="100px" ReadOnly="True" style=" resize: none;" TextMode="MultiLine" Width="390px" BackColor="#CCCCFF"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox3" runat="server" Font-Bold="True" Font-Size="Large" ForeColor="Red" Height="100px" ReadOnly="True" style=" resize: none; " TextMode="MultiLine" Width="370px" BackColor="#CCCCFF"></asp:TextBox>
            <br />
            <br />
        </asp:Panel>
        <br />  
        <br />

    </form>
</body>
</html>
