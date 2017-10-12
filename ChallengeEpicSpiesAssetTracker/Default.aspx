<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengeEpicSpiesAssetTracker.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style2 {
            font-family: Arial, Helvetica, sans-serif;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Image ID="Image1" runat="server" Height="191px" ImageUrl="~/epic-spies-logo.jpg" Width="173px" />
            <br />
            <h1 class="auto-style2">Asset Performance Tracker</h1>
            <p class="auto-style2">
                Asset Name: <asp:TextBox ID="nameTextBox" runat="server"></asp:TextBox>
            </p>
            <p class="auto-style2">
                Elections Rigged:
                <asp:TextBox ID="riggedTextBox" runat="server"></asp:TextBox>
            </p>
            <p class="auto-style2">
                Acts of Subterfuge Performed:
                <asp:TextBox ID="subterfugeTextBox" runat="server"></asp:TextBox>
            </p>
            <p class="auto-style2">
                &nbsp;</p>
            <p class="auto-style2">
                <asp:Button ID="addAssetBtn" runat="server" OnClick="addAssetBtn_Click" Text="Add Asset" />
            </p>
            <p class="auto-style2">
                &nbsp;</p>
            <p class="auto-style2">
                <asp:Label ID="resultLabel" runat="server"></asp:Label>
            </p>
        </div>
    </form>
</body>
</html>
