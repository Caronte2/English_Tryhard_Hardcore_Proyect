<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="English_Tryhard_Hardcore_Proyect.WebForm2" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title>Log In   </title>
    <link rel="stylesheet" href="./Stile/login.css" />
</head>

<body>

    <header>
        <a href="./index.aspx">
            <img class="logo" src="../img/img_logo_sin_fondo.png" alt="Website logo" />
        </a>

        <nav>
            <ul>
                <li><a href="">Log in</a></li>
            </ul>
        </nav>
    </header>

    <form id="form1" runat="server">
        <main>
            <div class="login_container">

                <div class="login_form">
                    <h2>Log in</h2>

                    <div class="input-group">
                        <asp:Label CssClass="label" ID="Label1" runat="server" Text="Email"></asp:Label>
                        <asp:TextBox CssClass="input-group" ID="TextBox1" runat="server" ></asp:TextBox>
                    </div>

                    <div class="input-group">
                        <asp:Label class="label" ID="Label2" runat="server" Text="Password"></asp:Label>
                          <asp:TextBox class="input-group" ID="TextBox2" runat="server" ></asp:TextBox>
                    </div>


                <asp:Button class="login_button" ID="ButtonLogin" runat="server" Text="Login"  OnClick="Button1_Click"/>
                <asp:Label class="label" ID="Label3" runat="server" Text=""></asp:Label>
          
                </div>

            </div>
        </main>
    </form>

    <footer>
        <p>All rights reserved</p>
    </footer>

</body>
</html>

    <!--
        ᘛ⁐ᕐᐷ   <--Pelusín
    -->