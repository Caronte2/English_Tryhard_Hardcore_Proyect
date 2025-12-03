<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="English_Tryhard_Hardcore_Proyect.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
  
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
        <h3>Nuestros servicios</h3>
        
        <div class="sections-wrapper"> 
            <section class="servicio_1">
                <div class="texto-servicio"> <%-- Envuelve h4 y p --%>
                    <h4>Servicio estandar</h4>
                    <p>pepe</p>
                </div>
                <img src="../img/habitacion_estandar.png" alt="Imagen servicio 1" />
            </section>

            <span class="separator"></span> <%-- Fuera de la section --%>

            <section class="servicio_2">
                <div class="texto-servicio"> <%-- Envuelve h4 y p --%>
                    <h4>Servicio vip</h4>
                    <p>pepe</p> 
                </div>
                <img src="../img/habitacion_suite.png" alt="Imagen servicio 2" />
            </section>

            <span class="separator"></span> <%-- Fuera de la section --%>

            <section class="servicio_3">
                <div class="texto-servicio"> <%-- Envuelve h4 y p --%>
                    <h4>Servicio catering</h4>
                    <p>pepe</p>
                </div>
                <img src="../img/servicio_habitacion.png" alt="Imagen servicio 3" />
            </section>
        </div> <%-- Cierra sections-wrapper --%>
    </main>

    <footer>
        <p>Todos los derechos reservados</p>
    </footer>

</body>
</html>
