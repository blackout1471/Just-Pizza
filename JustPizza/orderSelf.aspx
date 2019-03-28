<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="orderSelf.aspx.cs" Inherits="JustPizza.orderSelf" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous" />
    <link rel="stylesheet" href="./Css/theme.css" type="text/css" />
    <link rel="stylesheet" href="./Css/orderSelf.css" type="text/css" />

    <script src="https://code.jquery.com/jquery-3.2.1.slim.min.js" integrity="sha384-KJ3o2DKtIkvYIK3UENzmM7KCkRr/rE9/Qpg6aAZGJwFDMVNA/GpGFF93hXpG5KkN" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.12.9/umd/popper.min.js" integrity="sha384-ApNbgh9B+Y1QKtv3Rn7W3mgPxhU9K/ScQsAP7hUibX39j7fakFPskvXusvfa0b4Q" crossorigin="anonymous"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js" integrity="sha384-JZR6Spejh4U02d8jOt6vLEHfe/JQGiRRSQQxSfFWpi1MquVdAyjUar5+76PVCmYl" crossorigin="anonymous"></script>

    <title>JustPizza - Order From Menu</title>
</head>
<body>
    <div class="navbar fixed-top bgColor" id="navBar">
        <div class="container">
            <div class="column-m borderColor border">
                <a href="./default.aspx" class="linkStyle"><h1 class="headerTextColor m-3">Menu</h1></a>
            </div>
            <div class="column-m borderColor border">
                <a href="./OrderPizza.aspx" class="linkStyle"><h1 class="headerTextColor m-3">Order Pizza</h1></a>
            </div>
        </div>
        <div class="h-100 m-0 p-0">
            <img src="./img/icon.png" id="logo" />
        </div>
    </div>
    <div class="container-fluid m-0 p-0" id="ImgContainer">
        <img class="w-100 h-100" src="./img/orderPizza.jpg" />
    </div>
    <div class="container-fluid bgColor" id="menuLink">
        <div class="container pt-2">
            <div class="row">
                
                <h3 class="headerTextColor col text-center"><a href="./OrderPizza.aspx" class="orderSelf">Order From Menu</a></h3>
                <h3 class="text-white col text-center">Create Yourself</h3>
            </div>
            <div class="pb-3">
                <hr id="horizontalLine" class="pb-2"/>
            </div>
        </div>
        
    </div>
    <div class="container-fluid bgColor">
        <div class="row">
            <form runat="server" id="form" class="w-100">
                <div class="container text-center">
                    <asp:Label runat="server" ID="toppingsText" Text="" CssClass="secondTextColor"></asp:Label>
                    <hr id="horiLine"/>
                </div>
                <asp:GridView runat="server" ID="toppingList" CssClass="border-0 w-50" ShowHeader="false" BorderStyle="None" GridLines="None" AutoGenerateColumns="false" RowStyle-Height="100" OnSelectedIndexChanged="toppingList_SelectedIndexChanged">
                    <Columns>
                        <asp:BoundField HeaderText="Id" DataField="Id" ItemStyle-CssClass="headerTextColor"/>
                        <asp:BoundField HeaderText="Name" DataField="Name" ItemStyle-CssClass="text-white"/>
                        <asp:BoundField HeaderText="Price" DataField="Price" ItemStyle-CssClass="text-white" DataFormatString="{0}Kr"/>
                        <asp:ButtonField Text="Add" CommandName="Select" ItemStyle-ForeColor="#dc3c2d" />
                    </Columns>
                </asp:GridView>
                <div class="container w-50">
                    <div class="col">
                        <asp:Button ID="orderNow" Text="Order Now" runat="server" CssClass="float-right border-0 bgColor secondTextColor" OnClick="orderNow_Click"/>
                        <asp:Button ID="AddPizza" Text="Add Pizza" runat="server" CssClass="float-left border-0 bgColor secondTextColor" OnClick="AddPizza_Click"/>
                    </div>
                </div>
            </form>
        </div>
    </div>
</body>
</html>
