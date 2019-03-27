<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="menuOrdered.aspx.cs" Inherits="JustPizza.menuOrdered" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous" />
    <link rel="stylesheet" href="./Css/theme.css" type="text/css" />
    <link rel="stylesheet" href="./Css/menuOrdered.css" type="text/css" />

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
    <div class="container-fluid bgColor">
        <div class="row" id="decoy">

        </div>
        <div class="row">
            <div class="col">
                <h2 class="text-white text-center">Thank You For Your order!</h2>
            </div>
        </div>
        <div class="row">
            <hr id="horizontalLine"/>
        </div>
        <div class="row text-center">
            <form runat="server" id="form" class="w-100">
                
            </form>
        </div>
    </div>
</body>
</html>
