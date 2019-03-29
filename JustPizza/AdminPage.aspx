<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminPage.aspx.cs" Inherits="JustPizza.Css.AdminPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="./Css/bootstrap.min.css" type="text/css" />
    <link rel="stylesheet" href="./Css/Apage.css" type="text/css" />

    <script src="https://code.jquery.com/jquery-3.2.1.slim.min.js" integrity="sha384-KJ3o2DKtIkvYIK3UENzmM7KCkRr/rE9/Qpg6aAZGJwFDMVNA/GpGFF93hXpG5KkN" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.12.9/umd/popper.min.js" integrity="sha384-ApNbgh9B+Y1QKtv3Rn7W3mgPxhU9K/ScQsAP7hUibX39j7fakFPskvXusvfa0b4Q" crossorigin="anonymous"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js" integrity="sha384-JZR6Spejh4U02d8jOt6vLEHfe/JQGiRRSQQxSfFWpi1MquVdAyjUar5+76PVCmYl" crossorigin="anonymous"></script>

    <style type="text/css">
        .auto-style1 {
            width: 394px;
            height: 156px;
        }
    </style>

</head>
<body>
    <form id="form1" runat="server">
        <nav class="navbar">
            <a class="input" href="#">Admin Menu</a>
            <asp:Button class="rightTXT" ID="Button1" runat="server" OnClick="Logout_click" Text="Logout" />
        </nav>



        <div class="container-fluid bgColor">
            <asp:GridView runat="server" ID="menuList" CssClass="w-75 m-auto" ShowHeader="false" BorderStyle="None" GridLines="both" AutoGenerateColumns="false" RowStyle-Height="100" OnSelectedIndexChanged="DeletePizza">
                <Columns>
                    <asp:BoundField HeaderText="MenuId" DataField="MenuId" ItemStyle-CssClass="headerTextColor" />
                    <asp:BoundField HeaderText="PizzaName" DataField="Name" ItemStyle-CssClass="text-black" />
                    <asp:BoundField HeaderText="Toppings" DataField="ToppingsToString" ItemStyle-CssClass="text-black" />
                    <asp:BoundField HeaderText="Total" DataField="TotalPrice" DataFormatString="{0} Kr." ItemStyle-CssClass="text-black" />
                    <asp:ButtonField Text="Delete" CommandName="Select" ItemStyle-ForeColor="#dc3c2d" />
                </Columns>
            </asp:GridView>
        </div>
        <br />
        <div class="container">
            <h4> Create pizza</h4>
            <asp:TextBox ID="MenuID" runat="server" Text="Menu ID" > </asp:TextBox>
            <asp:TextBox ID="PizzaName" runat="server" Text="Name" > </asp:TextBox>
            <asp:TextBox ID="ToppinID" runat="server" Text="ToppingID" > </asp:TextBox>
            <asp:Button ID="CreatePizza" runat="server" onclick="CreatePizza_Click" Text="Create"/>
 

        </div>

    </form>


</body>
</html>
