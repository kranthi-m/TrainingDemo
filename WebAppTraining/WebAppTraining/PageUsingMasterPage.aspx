<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PageUsingMasterPage.aspx.cs" Inherits="WebAppTraining.PageUsingMasterPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <p>
    This is page using Master Page<br />
</p>
<p>
    <asp:Label ID="lblName" runat="server" Text="Name"></asp:Label>
&nbsp;<asp:TextBox ID="txtName" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtName" ErrorMessage="Name is Required"></asp:RequiredFieldValidator>
</p><p>
    <asp:Label ID="lblAge" runat="server" Text="Age"></asp:Label>
&nbsp;<asp:TextBox ID="txtAge" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtAge" ErrorMessage="Age is Required"></asp:RequiredFieldValidator>
&nbsp;<asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txtAge" ErrorMessage="Age is not Valid" MaximumValue="40" MinimumValue="20"></asp:RangeValidator>
</p>
    <p>
        Email <asp:TextBox ID="txtAge0" runat="server"></asp:TextBox>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtAge0" ErrorMessage="Email is not in correct format" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
</p>
    <p> <asp:Label ID="lblStatus" runat="server" Text="Marital Status"></asp:Label>
        &nbsp;

        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem>Yes</asp:ListItem>
            <asp:ListItem>No</asp:ListItem>
        </asp:DropDownList>

    </p>
    <p> 
        <asp:Button ID="Button1" runat="server" Height="18px" OnClick="Button1_Click" Text="Submit" />

    </p>
    <p> &nbsp;</p>
    <p> 
        <asp:GridView ID="GridView1" runat="server" DataSourceID="SqlDataSource1">
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>

    </p>
    <p>
</p>

</asp:Content>
