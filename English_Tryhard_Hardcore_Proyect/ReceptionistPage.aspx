<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ReceptionistPage.aspx.cs" Inherits="English_Tryhard_Hardcore_Proyect.ReceptionistPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div id="formMakeUser">
            <h2>Make user</h2>
            <asp:Label ID="LabelMakeName" runat="server" Text="Name:"></asp:Label>
            <asp:TextBox ID="TextMakeName" runat="server"></asp:TextBox>
            <asp:Label ID="LabelMakeFod" runat="server" Text="Date:"></asp:Label>
            <asp:TextBox ID="TextMakeFod" runat="server" TextMode="Date"></asp:TextBox>
            <asp:Label ID="LabelMakeAddress" runat="server" Text="Address:"></asp:Label>
            <asp:TextBox ID="TextMakeAddress" runat="server"></asp:TextBox>
            <asp:Label ID="LabelMakeMobile" runat="server" Text="Mobile:"></asp:Label>
            <asp:TextBox ID="TextMakeMobile" runat="server"></asp:TextBox>
            <asp:Label ID="LabelMakeEmail" runat="server" Text="Email:"></asp:Label>
            <asp:TextBox ID="TextMakeEmail" runat="server"></asp:TextBox>
            <asp:Label ID="LabelMakeRol" runat="server" Text="Rol:"></asp:Label>
            <asp:DropDownList ID="DropDownList1" runat="server" Width="87px">
                <asp:ListItem>user</asp:ListItem>
                <asp:ListItem>receptionist</asp:ListItem>
            </asp:DropDownList>
            <asp:Label ID="LabelMakePassword" runat="server" Text="Password:"></asp:Label>
            <asp:TextBox ID="TextMakePassword" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
        </div>


        <div id="formDeleteUser">
            <h2>Delete user</h2>
            <asp:Label ID="LabelDeleteEmail" runat="server" Text="Email user"></asp:Label>
            <asp:TextBox ID="TextDeleteEmail" runat="server"></asp:TextBox>
            <asp:Button ID="Button2" runat="server" Text="Delete user" OnClick="Button2_Click" />
            <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
        </div>


        <div id="formChangeUser">
            <h2>Chanege user</h2>
            <asp:Label ID="Label3" runat="server" Text="Email user"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:Button ID="Button3" runat="server" Text="Button" />
        </div>


        <div id="formMakebooking">
            <h2>Make booking</h2>
            <asp:Label ID="LabelMakeBookingUserEmail" runat="server" Text="Label"></asp:Label>
            <asp:TextBox ID="TextMakeBookingUserEmail" runat="server"></asp:TextBox>
            <asp:Label ID="LabelMakeBookingRoomNumber" runat="server" Text="Label"></asp:Label>
            <asp:TextBox ID="TextMakeBookingRoomNumber" runat="server"></asp:TextBox>
            <asp:Label ID="LabelMakeBookingCheckInDate" runat="server" Text="Label"></asp:Label>
            <asp:TextBox ID="TextMakeBookingCheckInDate" runat="server" TextMode="Date"></asp:TextBox>
            <asp:Label ID="LabelMakeBookingCheckOutDate" runat="server" Text="Label"></asp:Label>
            <asp:TextBox ID="TextMakeBookingCheckOutDate" runat="server" TextMode="Date"></asp:TextBox>
            <asp:Button ID="Button4" runat="server" Text="Button" OnClick="Button4_Click" />
            <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
        </div>

        <div id="formDeletebooking">
            <h2>Delete booking</h2>
            <asp:Label ID="LabelDeleteBookingID" runat="server" Text="Label"></asp:Label>
            <asp:TextBox ID="TextDeleteBookingID" runat="server"></asp:TextBox>
            <asp:Button ID="Button5" runat="server" Text="Button" />
        </div>

        <div id="formChangebooking">
            <h2>Change booking</h2>
            <asp:Label ID="LabelChangeBookingID" runat="server" Text="Label"></asp:Label>
            <asp:TextBox ID="TextBox21" runat="server"></asp:TextBox>
            <asp:Label ID="LabelChangeBookingUserEmail" runat="server" Text="Label"></asp:Label>
            <asp:TextBox ID="TextBox22" runat="server"></asp:TextBox>
            <asp:Label ID="LabelChangeBookingRoomNumber" runat="server" Text="Label"></asp:Label>
            <asp:TextBox ID="TextBox23" runat="server"></asp:TextBox>
            <asp:Label ID="LabelChangeBookingCheckInDate" runat="server" Text="Label"></asp:Label>
            <asp:TextBox ID="TextBox24" runat="server"></asp:TextBox>
            <asp:Label ID="LabelChangeBookingCheckOutDate" runat="server" Text="Label"></asp:Label>
            <asp:TextBox ID="TextBox25" runat="server"></asp:TextBox>
        </div>
        <div id="search">
            <h2>Search user</h2>
            <asp:Label ID="LabelSearchUserEmail" runat="server" Text="Label"></asp:Label>
            <asp:TextBox ID="TextBox26" runat="server"></asp:TextBox>
            <asp:Label ID="LabelSearchBookingID" runat="server" Text="Label"></asp:Label>
            <asp:TextBox ID="TextBox27" runat="server"></asp:TextBox>
        </div>
    </form>
</body>
</html>
