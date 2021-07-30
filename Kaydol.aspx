<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Kaydol.aspx.cs" Inherits="bilgiyarisma.Kaydol" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="Dosyalar/bootstrap.min.css" rel="stylesheet" />

    <title></title>
    <style type="text/css">
        #form1 {
            width: 1360px;
            height: 657px;
        }
        .auto-style1 {
            color: #FFFFFF;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" style=" background-repeat: no-repeat;  width: 1360px; text-align: center;  background-color: #001F3E;">
       
             
            <div  style ="text-align:center; color: #001F3E; background-color: #001F3E;">
                  <br /> <br />
             <div style ="width:1100px; height:570px; margin:auto; padding=center; background-image: url('Resimler/Akaydol.png'); border-radius:40px; ">
                <br /><br /><br />
                   <div style =" display:inline-block" >
                         <asp:Image ID="Image2" runat="server"  ImageUrl="~/Resimler/A tatlı.gif" Height="346px" Width="445px"  />  <br /> <br />
                    </div>
                
                    <div style =" display:inline-block; margin-left:80px; height: 430px;">
                        <h3 style="color:white;">KAYDOL</h3>
                        <br />
                              <asp:TextBox ID="TxtOyuncuAd" runat="server" CssClass="form-control" Width="340px" placeholder="Oyuncu Adı" ></asp:TextBox>   
                        <br />
                            <asp:TextBox ID="TxtAd" runat="server" CssClass="form-control" Width="340px"  placeholder="Adınız" ></asp:TextBox>
                        <br />
                            <asp:TextBox ID="TxtSoyad" runat="server" CssClass="form-control" Width="340px"  placeholder="Soyadınız" ></asp:TextBox>
                        <br />
                            <asp:TextBox ID="TxtEposta" runat="server" CssClass="form-control" Width="340px" placeholder="E-posta" ></asp:TextBox>   
                        <br />
                            <asp:TextBox ID="TxtSifre" runat="server" CssClass="form-control" Width="340px" placeholder="Şifre" TextMode="Password" ></asp:TextBox>   
                       
                        <br />
                         <div style ="width:340px; color: #003366;">
                           
                            <asp:Button ID="TxtKaydol" runat="server" Text="KAYDOL"  CssClass="btn btn-warning" Width="300px" OnClick="TxtKaydol_Click" />
                         
                         </div>

                    </div>   
                 <br /><br /><br />
                   

               </div>
           </div>
    </form>
</body>
</html>
