<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminLogin.aspx.cs" Inherits="JustPizza.AdminPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="./Css/bootstrap.min.css" type="text/css" />
    <link rel="stylesheet" href="./Css/Alogin.css" type="text/css" />


    <script src="https://code.jquery.com/jquery-3.2.1.slim.min.js" integrity="sha384-KJ3o2DKtIkvYIK3UENzmM7KCkRr/rE9/Qpg6aAZGJwFDMVNA/GpGFF93hXpG5KkN" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.12.9/umd/popper.min.js" integrity="sha384-ApNbgh9B+Y1QKtv3Rn7W3mgPxhU9K/ScQsAP7hUibX39j7fakFPskvXusvfa0b4Q" crossorigin="anonymous"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js" integrity="sha384-JZR6Spejh4U02d8jOt6vLEHfe/JQGiRRSQQxSfFWpi1MquVdAyjUar5+76PVCmYl" crossorigin="anonymous"></script>

</head>
<body>
    <form id="form" runat="server">
        <div class ="input" id ="input">
            <h1 ><strong>Admin login</strong></h1>
        </div>
        <table class="centerText">
            <tr>
                <td class="centerText">Username</td>
                <td class="centerText">
                    <asp:TextBox ID="usernameTxt" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="centerText">Password</td>
                <td class="centerText">
                    <asp:TextBox ID="passwordTxt" runat="server" TextMode="Password"></asp:TextBox>
                </td>
                <td class="centerText">&nbsp;</td>
            </tr>
            <tr>
                <td class="centerText">&nbsp;</td>
                <td class="centerText">
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Login" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="centerText">&nbsp;</td>
                <td class="centerText">
                    <asp:Label ID="loginConfirmation" runat="server" Enabled="False"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
