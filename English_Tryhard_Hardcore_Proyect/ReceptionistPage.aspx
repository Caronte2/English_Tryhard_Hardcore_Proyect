<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ReceptionistPage.aspx.cs" Inherits="English_Tryhard_Hardcore_Proyect.ReceptionistPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="./Stile/Receptionist.css" />
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
            <asp:Button ID="Button1" runat="server" Text="Make" OnClick="Button1_Click" />
            <asp:Label ID="LabelError" runat="server" Text=""></asp:Label>
        </div>


        <div id="formDeleteUser">
            <h2>Delete user</h2>
            <asp:Label ID="LabelDeleteEmail" runat="server" Text="Email user"></asp:Label>
            <asp:TextBox ID="TextDeleteEmail" runat="server"></asp:TextBox>
            <asp:Button ID="Button2" runat="server" Text="Delete" OnClick="Button2_Click" />
            <asp:Label ID="LabelDeleteUserErrorr" runat="server" Text=""></asp:Label>
        </div>


        <div id="formChangeUser">
            <h2>Chanege user</h2>
            <asp:Label ID="Label3" runat="server" Text="Email user"></asp:Label>
            <asp:TextBox ID="TextSearchForEmail" runat="server"></asp:TextBox>
            <asp:Button ID="Button3" runat="server" Text="Change" OnClick="Button3_Click" />
            <asp:Label ID="LabelChangerUserError" runat="server" Text=""></asp:Label>

            <asp:Label ID="Label5" runat="server" Text="Name"></asp:Label>
            <asp:TextBox ID="TextUpdateName" runat="server"></asp:TextBox>
            <asp:Label ID="Label6" runat="server" Text="Date"></asp:Label>
            <asp:TextBox ID="TextUpdateFOD" runat="server" TextMode="Date"></asp:TextBox>
            <asp:Label ID="Label7" runat="server" Text="Address"></asp:Label>
            <asp:TextBox ID="TextUpdateAddress" runat="server"></asp:TextBox>
            <asp:Label ID="Label8" runat="server" Text="Mobile"></asp:Label>
            <asp:TextBox ID="TextUpdateMobile" runat="server"></asp:TextBox>
            <asp:Label ID="Label9" runat="server" Text="Rol"></asp:Label>
            <asp:DropDownList ID="DropDownList2" runat="server" Width="87px">
                <asp:ListItem>user</asp:ListItem>
                <asp:ListItem>receptionist</asp:ListItem>
            </asp:DropDownList>
            <asp:Label ID="Label11" runat="server" Text="Password"></asp:Label>
            <asp:TextBox ID="TextUpdatePassword" runat="server"></asp:TextBox>
            <asp:Button ID="ButtonUpdateUser" runat="server" Text="Update user" OnClick="ButtonUpdateUser_Click" />
             <asp:Label ID="LabelChangerUser2" runat="server" Text=""></asp:Label>
        </div>


        <div id="formMakebooking">
            <h2>Make booking</h2>
            <asp:Label ID="LabelMakeBookingUserEmail" runat="server" Text="Id booking"></asp:Label>
            <asp:TextBox ID="TextMakeBookingUserEmail" runat="server"></asp:TextBox>
            <asp:Label ID="LabelMakeBookingRoomNumber" runat="server" Text="Room"></asp:Label>
            <asp:TextBox ID="TextMakeBookingRoomNumber" runat="server"></asp:TextBox>
            <asp:Label ID="LabelMakeBookingCheckInDate" runat="server" Text="Entry Date"></asp:Label>
            <asp:TextBox ID="TextMakeBookingCheckInDate" runat="server" TextMode="Date"></asp:TextBox>
            <asp:Label ID="LabelMakeBookingCheckOutDate" runat="server" Text="Departure date"></asp:Label>
            <asp:TextBox ID="TextMakeBookingCheckOutDate" runat="server" TextMode="Date"></asp:TextBox>
            <asp:Button ID="Button4" runat="server" Text="Make" OnClick="Button4_Click" />
            <asp:Label ID="LabelDeletoBooking" runat="server" Text=""></asp:Label>
        </div>

        <div id="formDeletebooking">
            <h2>Delete booking</h2>
            <asp:Label ID="LabelDeleteBookingID" runat="server" Text="Id Booking"></asp:Label>
            <asp:TextBox ID="TextDeleteBookingID" runat="server"></asp:TextBox>
            <asp:Button ID="Button5" runat="server" Text="Delete" OnClick="Button5_Click" />
                        <asp:Label ID="LabeDeleteBooking1" runat="server" Text=""></asp:Label>
        </div>

        <div id="formChangebooking">
            <h2>Change booking</h2>
            <asp:Label ID="LabelChangeBookingID" runat="server" Text="Id reservation"></asp:Label>
            <asp:TextBox ID="TextSearchReservationId" runat="server"></asp:TextBox>
            <asp:Button ID="Button6" runat="server" Text="Search reservation" OnClick="Button6_Click" />
            
            <asp:Label ID="LabelChangeBooking" runat="server" Text=""></asp:Label>
            <asp:Label ID="LabelChangeBookingUserEmail" runat="server" Text="Room"></asp:Label>
            <asp:TextBox ID="TextRoomChangeBooking" runat="server"></asp:TextBox>
            <asp:Label ID="LabelChangeBookingRoomNumber" runat="server" Text="Departure date"></asp:Label>
            <asp:TextBox ID="TextDepartureChangeBookin" runat="server" TextMode="Date"></asp:TextBox>
            <asp:Label ID="LabelChangeBookingCheckInDate" runat="server" Text="Entry date"></asp:Label>
            <asp:TextBox ID="TextEntryDateChangeDate" runat="server" TextMode="Date"></asp:TextBox>
            <asp:Button ID="Button7" runat="server" Text="Update reservation" OnClick="Button7_Click" />
                        <asp:Label ID="LabelChangeBooking2" runat="server" Text=""></asp:Label>
        </div>
        <div id="search">
            <h2>Search user</h2>
            <asp:Label ID="LabelSearchUserEmail" runat="server" Text="User Email"></asp:Label>
            <asp:TextBox ID="TextEmailSearch" runat="server"></asp:TextBox>
                        <asp:Label ID="LabelSearchUser" runat="server" Text=""></asp:Label>
            <asp:Button ID="Button8" runat="server" OnClick="Button8_Click" Text="Search User" />
            <asp:Label ID="SearchName" runat="server" Text="Name:"></asp:Label>
            <asp:Label ID="SearchDate" runat="server" Text="Date:"></asp:Label>
            <asp:Label ID="SearchAddress" runat="server" Text="Address:"></asp:Label>
            <asp:Label ID="SearchMobile" runat="server" Text="Mobile:"></asp:Label>
            <asp:Label ID="SearchRol" runat="server" Text="Rol:"></asp:Label>
        </div>
    </form>
    <footer>
    <p>All rights reserved</p>
</footer>
</body>
</html>
