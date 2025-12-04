<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="English_Tryhard_Hardcore_Proyect.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Grandeur Hotel - Welcome</title>
  
    <link rel="stylesheet" href="./Stile/Index.css" />

</head>
<body>
    <header>
        <a href="#">
            <img class="logo" src="../img/img_logo_sin_fondo.png" alt="Website logo" />
        </a>

        <nav>
            <ul>
                <li><a href="./login.aspx">Log in</a></li>
            </ul>
        </nav>
    </header>
            
    <main>
        <h3>Our Services</h3>
        
        <div class="sections-wrapper"> 
            <section class="servicio_1">
                <div class="texto-servicio"> 
                    <h4>Standard Service</h4>
                    <p>Enjoy a comfortable and fully equipped *Standard Room* with all the essential amenities for a pleasant stay, including high-speed Wi-Fi and a spacious work area. Ideal for short visits and business travelers.</p>
                </div>
                <img src="../img/habitacion_estandar.png" alt="Imagen servicio 1" />
            </section>

            <span class="separator"></span> 

            <section class="servicio_2">
                <div class="texto-servicio"> 
                    <h4>VIP Service</h4>
                    <p>Upgrade to a luxurious *Suite Room* offering premium features, exclusive access to our executive lounge, personalized concierge service, and breathtaking views of the city. Experience true grandeur during your visit.</p> 
                </div>
                <img src="../img/habitacion_suite.png" alt="Imagen servicio 2" />
            </section>

            <span class="separator"></span> 

            <section class="servicio_3">
                <div class="texto-servicio"> 
                    <h4>Catering Service</h4>
                    <p>Indulge in our exquisite *Room Service* and Catering options. Enjoy gourmet meals, snacks, and beverages delivered directly to your room 24/7. Perfect for late-night cravings or a private dining experience.</p>
                </div>
                <img src="../img/servicio_habitacion.png" alt="Imagen servicio 3" />
            </section>
        </div> 
    </main>

    <footer>
        <p>All rights reserved</p>
    </footer>

</body>
</html>