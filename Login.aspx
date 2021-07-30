<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="bilgiyarisma.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="Dosyalar/bootstrap.min.css" rel="stylesheet" />

    <title></title>
    <style type="text/css">
        #form1 {
            height: 657px;
        }
        .auto-style1 {
            color: #FFFFFF;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" style=" background-repeat: no-repeat;  width: 1360px; text-align: center;  background-color: #001F3E; color: #001F3E;">
       
             
            <div  style ="text-align:center; color: #003366; background-color: #001F3E;">
                  <br />
             <br />
             <div style ="width:1100px; height:570px; margin:auto;  background-image: url('Resimler/A arka.png'); border-radius:40px; ">
             <br />
                <asp:Image ID="Image1" runat="server" Width="700px" ImageUrl="Resimler/A.gif" Height="120px"  />
             <br />
                
                    <div style ="width:400px;  height:300px; margin:auto; display:inline-block" >
                         <asp:Image ID="Image2" runat="server"  ImageUrl="~/Resimler/A div.gif" Height="415px" Width="527px"  />
                    </div>

                    <div style ="width:400px;  height:300px; margin-left:150px;  display:inline-block">
                        <br />
                        
                            <asp:TextBox ID="TxtKullanici" runat="server" CssClass="form-control" Width="340px" placeholder="Oyuncu Adı" ></asp:TextBox>   
                         
                        <br />
                        
                            <asp:TextBox ID="TxtSifre" runat="server" CssClass="form-control" Width="340px" TextMode="Password" placeholder="Şifre" ></asp:TextBox>
                        
                        
                        <br />
                        <br />
                         <div style ="width:340px; color: #003366;">
                            <asp:Button ID="TxtGiris" runat="server" Text="GİRİŞ YAP" CssClass="btn btn-success" Width="165px" OnClick="TxtGiris_Click" />
                            <asp:Button ID="TxtKayit" runat="server" Text="KAYDOL"  CssClass="btn btn-warning" Width="165px" OnClick="TxtKayit_Click" />
                         <br />
                         </div>
                           
                    </div>

               </div>
           </div>
    </form>
</body>
</html>

