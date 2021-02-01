<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Covid_Website.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Covid case reports</title>
    <style type="text/css">
        #form1 {
            height: 653px;
        }
    </style>
</head>
<body>
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

     <!--   <div style="margin-left: auto; margin-right: auto; text-align: left;"> -->
        <asp:Label ID="Label4" runat="server" Text="Age reports" style="margin-left: 10.5%;" Font-Size="X-Large" Font-Bold="True" Font-Overline="False" Font-Underline="True" ></asp:Label>            
   <!--    </div> -->

       <!-- <div style="margin-left: auto; margin-right: auto; text-align: center;"> -->
        <asp:Label ID="Label5" runat="server" Text="Gender reports" style="margin-left: 24%;" Font-Size="X-Large" Font-Bold="True" Font-Underline="True"></asp:Label>
       <!-- </div> -->

      <!--  <div style="margin-left: auto; margin-right: auto; text-align: right;"> -->
        <asp:Label ID="Label6" runat="server" Text="Date reports" style="margin-left: 23.5%;" Font-Size="X-Large" Font-Bold="True" Font-Underline="True"></asp:Label>
      <!--  </div> -->

        <br />

        <asp:TextBox ID="TextBox1" runat="server" TextMode="MultiLine" ReadOnly="True" style="margin-left: 3.5%; resize: none;" Width="310px" Font-Bold="True" Font-Size="Large" ForeColor="Red" Height="100px"></asp:TextBox>
        <asp:TextBox ID="TextBox2" runat="server" TextMode="MultiLine" ReadOnly="True" style="margin-left: 10%; resize: none;" Width="310px" Font-Bold="True" Font-Size="Large" ForeColor="Red" Height="100px"></asp:TextBox>
        <asp:TextBox ID="TextBox3" runat="server" ReadOnly="True" style="margin-left: 7.5%; resize: none;" Width="390px" Font-Bold="True" Font-Size="Large" ForeColor="Red" TextMode="MultiLine" Height="100px"></asp:TextBox>        

    </form>
</body>
</html>
