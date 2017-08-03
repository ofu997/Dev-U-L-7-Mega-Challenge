<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Casino.aspx.cs" Inherits="DevUL7CasinoChallenge.Casino" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Image ID="Image1" runat="server" Height="150px" Width="150px" />
            <asp:Image ID="Image2" runat="server" Height="150px" Width="150px" />
            <asp:Image ID="Image3" runat="server" Height="150px" Width="150px" />
        </div>
        <p>
            Your bet here<asp:TextBox ID="betTextBox" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="pull the lever ~!*" />
        </p>
        <p>
            <asp:Label ID="resultLabel" runat="server"></asp:Label>
        </p>
        <p>
            <asp:Label ID="moneyLabel" runat="server"></asp:Label>
        </p>
        <p>
            1 CHERRY: DOUBLE YOUR BET</p>
        <p>
            2 CHERRIES: TRIPLE YOUR BET</p>
        <p>
            3&nbsp; CHERRIES: X4 YOUR BET</p>
        <p>
            3 7&#39;S: JACKPOT: X 100 YOUR BET</p>
        <p>
            IF THERE&#39;S ONE BAR YOU WIN NOTHING</p>
    </form>
</body>
</html>
