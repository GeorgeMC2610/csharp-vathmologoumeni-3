<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Covid_Website.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Covid case reports</title>
    <style type="text/css">
        #form1 {
            height: 773px;
        }
    </style>
</head>
<body style="min-width:1333px;" onresize="resize()">
    <script>
        function resize() {
            //document.getElementById("TextBox1").style.position = "absolute";
            //document.getElementById("TextBox1").style.left = 100 + 'px';

        }
    </script>
    <form id="form1" runat="server">
        <div style="margin-left: auto; margin-right: auto; text-align: center;">
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="XX-Large" Text="Welcome to Covid case reports website"></asp:Label>
        </div>
        <br />
        <br />
        <div style="margin-left: auto; margin-right: auto; text-align: center;">
            <asp:Label ID="Label2" runat="server" BorderColor="Black" Font-Bold="True" Font-Size="20pt" Text="Label"></asp:Label>
        </div>
        <br />
        <div style="margin-left: auto; margin-right: auto; text-align: center;">
        <asp:Label ID="Label3" runat="server" BackColor="White" Font-Size="20pt" Font-Strikeout="False" Text="The reports are being represented analytically in the table bellow:"></asp:Label>
        </div>
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server" AllowSorting="True" AutoGenerateColumns="False" BackColor="Black" BorderColor="White" BorderStyle="None" BorderWidth="2px" CellPadding="5" CellSpacing="2" DataSourceID="SqlDataSource1" EnableTheming="True" Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Size="Large" GridLines="None" Height="147px" HorizontalAlign="Center">
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
        <asp:Panel ID="Panel1" runat="server" Height="216px" HorizontalAlign="Center">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label4" runat="server" Font-Bold="True" Font-Overline="False" Font-Size="X-Large" Font-Underline="True" style="margin-left: -5%;" Text="Age reports"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label5" runat="server" Font-Bold="True" Font-Size="X-Large" Font-Underline="True" style="margin-left: 0px;" Text="Gender reports"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label6" runat="server" Font-Bold="True" Font-Size="X-Large" Font-Underline="True" style="margin-left: 0%"  Text="Date reports"></asp:Label>
            <br />
            <br />
            <asp:TextBox ID="TextBox1" runat="server" Font-Bold="True" Font-Size="Large" ForeColor="Red" Height="100px" ReadOnly="True" style=" resize: none; " TextMode="MultiLine" Width="330px"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox2" runat="server" Font-Bold="True" Font-Size="Large" ForeColor="Red" Height="100px" ReadOnly="True" style=" resize: none;" TextMode="MultiLine" Width="390px"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox3" runat="server" Font-Bold="True" Font-Size="Large" ForeColor="Red" Height="100px" ReadOnly="True" style=" resize: none; " TextMode="MultiLine" Width="370px"></asp:TextBox>
        </asp:Panel>
        <br />  
        <br />

    </form>
</body>
</html>
