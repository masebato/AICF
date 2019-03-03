<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="AICF.views.Login" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="https://fonts.googleapis.com/css?family=Montserrat:400,700,200" rel="stylesheet" />
    <link href="https://maxcdn.bootstrapcdn.com/font-awesome/latest/css/font-awesome.min.css" rel="stylesheet" />
    <!-- CSS Files -->
    <link href="assets/css/bootstrap.min.css" rel="stylesheet" />
    <link href="assets/css/paper-dashboard.css?v=2.0.0" rel="stylesheet" />
    <!-- CSS Just for demo purpose, don't include it in your project -->
    <link href="assets/demo/demo.css" rel="stylesheet" />
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/limonte-sweetalert2/7.28.5/sweetalert2.all.js"></script>
    <form runat="server">
        <div class="wraper">
            <div style="position: relative; float: right; width: 100%; background-color: #f4f3ef; height: 100%; max-height: 100%;">
                <div class="content">
                    <div class="row">
                        <div style="width: 500px; height: 100px; margin-left: 450px; margin-top: 200px;" class="">
                            <div class="card card-user">
                                <div class="card-header">
                                    <h6>INICIAR SESION</h6>
                                </div>
                                <div class="card-body">
                                    <div class="row">
                                        <div class="col-sm-4">
                                                <div class="logo-image-small">
                                            <img src="assets/img/logo.jpg" alt="10%">
                                        </div>
                                        </div>
                                    
                                        <div class="col-sm-4">
                                            <label>Usuario</label>
                                            <asp:TextBox runat="server" ID="users" CssClass="form-control"></asp:TextBox>
                                        </div>
                                
                                        <div class="col-sm-4">
                                            <label>Contraseña</label>
                                            <input type="password" runat="server" id="pass" class="form-control" />
                                        </div>
                                         <div class="col-sm-4 offset-6">

                                    <asp:Button runat="server" CssClass="btn btn-border" Text="INGRESAR" OnClick="Acceder" />
                                </div>
                                    </div>
                                </div>
                                <br />
                               
                            </div>
                        </div>
                    </div>

                </div>

            </div>

        </div>
    </form>
</body>

</html>
