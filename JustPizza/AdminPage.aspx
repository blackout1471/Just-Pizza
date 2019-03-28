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


        <div class="form-group">
            <div class="container">
                <label for="sel1">Select pizza to change it</label>
                <select class="form-control" id="sel1">
                    <option>1</option>
                    <option>2</option>
                    <option>3</option>
                    <option>4</option>
                </select>
      
            </div>
        </div>
    </form>


    <div class="container">      
  <table class="table">
    <thead>
      <tr>
        <th>Pizza</th>
        <th>Price</th>
      </tr>
    </thead>
    <tbody>
      <tr>
        <td>John</td><!--Input text from pizza-->
        <td>Doe</td>
      </tr>
      <tr>
        <td>Mary</td>
        <td>Moe</td>

      </tr>
      <tr>
        <td>July</td>
        <td>Dooley</td>

      </tr>
    </tbody>
  </table>
</div>
    
   






</body>
</html>
