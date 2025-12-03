<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="English_Tryhard_Hardcore_Proyect.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
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

    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Email"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <asp:Button ID="ButtonLogin" runat="server" Text="Login" OnClick="Button1_Click"/>
            <asp:Label ID="Label3" runat="server" Text=""></asp:Label>
        </div>
    </form>
    <footer>
        <p>Todos los derechos reservados</p>
    </footer>

</body>
</html>
