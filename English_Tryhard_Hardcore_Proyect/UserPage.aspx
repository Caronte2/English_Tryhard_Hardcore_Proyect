<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserPage.aspx.cs" Inherits="English_Tryhard_Hardcore_Proyect.UserPage" %>


<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title>Users Landing Page</title>
    <link rel="stylesheet" href="./Stile/UserPage.css" />
</head>

<body>

    <header>
        <a href="#">
            <img class="logo" src="../img/img_logo_sin_fondo.png" alt="Website logo" />
        </a>

        <nav>
            <ul>
                <li><a href="#">Log in</a></li>
            </ul>
        </nav>
    </header>

    <main>
        <h2>Your profile</h2>
        <form id="form1" runat="server">
            <div class="user-info">

                <div class="info-row">
                    <asp:Label ID="Label1" runat="server" Text="Name:" CssClass="label-title"></asp:Label>
                    <asp:Label ID="LabelName" runat="server" Text=""></asp:Label>
                </div>

                <div class="info-row">
                    <asp:Label ID="Label3" runat="server" Text="Email:" CssClass="label-title"></asp:Label>
                    <asp:Label ID="LabelEmail" runat="server" Text=""></asp:Label>
                </div>

                <div class="info-row">
                    <asp:Label ID="Label5" runat="server" Text="Date:" CssClass="label-title"></asp:Label>
                    <asp:Label ID="LabelDate" runat="server" Text=""></asp:Label>
                </div>

                <div class="info-row">
                    <asp:Label ID="Label7" runat="server" Text="Mobile:" CssClass="label-title"></asp:Label>
                    <asp:Label ID="LabelMobile" runat="server" Text=""></asp:Label>
                </div>

                <div class="info-row">
                    <asp:Label ID="Label9" runat="server" Text="Address:" CssClass="label-title"></asp:Label>
                    <asp:Label ID="LabelAddress" runat="server" Text=""></asp:Label>
                </div>

                <div class="info-row">
                    <asp:Label ID="Label11" runat="server" Text="Rol:" CssClass="label-title"></asp:Label>
                    <asp:Label ID="LabelRol" runat="server" Text=""></asp:Label>
                </div>
                
                <div></div>

                <div class="button-container">
                    <asp:ListBox ID="ListBoxBooking" runat="server"></asp:ListBox>
                </div>

            </div>
                
            
        </form>
    </main>

    <footer>
        <p>All rights reserved</p>
    </footer>

</body>
</html>

<!--
    ᘛ⁐ᕐᐷ   <--Pelusín
-->
                        