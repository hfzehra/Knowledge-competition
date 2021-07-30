<%@ Page Title="" Language="C#" MasterPageFile="~/Ana.Master" AutoEventWireup="true" CodeBehind="Anasayfa.aspx.cs" Inherits="bilgiyarisma.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

   <style>
    input {
    background-color: #2B0141;
    width: 150px;
    height: 150px;
    font-size: 20px;
    color: white;
    font-family: Arial, Helvetica, sans-serif;
    font-weight: bold;
    text-shadow: #2d4251 5px 5px 5px;
    border: 15px solid rgba(255, 255, 255, .5);
    border-radius: 50%;
    -moz-border-radius: 50%;
    -webkit-border-radius: 50%;
    }

    input:hover {
        color: aliceblue;
        background-color: darkmagenta;
        border: 15px solid rgba(255, 255, 255, .5);
        line-height: 200px;
    }

    .bir {
        background-color: brown;
    }

        .bir:hover {
             line-height:unset;
             border: 20px solid rgba(255, 255, 255, .5);
            background-color: chocolate;
        }

    .iki {
        line-height:10px;
        width: 100px;
        height: 100px;
        background-color: darkslategray;
        border: 10px solid rgba(255, 255, 255, .5);
    }

        .iki:hover {
            line-height:unset;
             border: 20px solid rgba(255, 255, 255, .5);
            background-color: darkcyan;
        }

    .üç {
        width: 180px;
        height: 180px;
        background-color:forestgreen ;
    }

    .üç:hover {
        line-height:unset;
         border: 20px solid rgba(255, 255, 255, .5);
        background-color: darkolivegreen;
    }
    .text{
        font-family:Calibri;
        font-size: 28px; 
        font-weight: bold; 
        color: #FFFFFF;
        margin:auto;
        text-align:center;
        width:1200px;
        height:50px;
    }
   </style>
   <div  style="background-color: #2B0141;  text-align:center; width:1350px; ">
        <div class="text">
            
            <h1 >HOŞGELDİN   <asp:Label ID="Label1" runat="server" BorderStyle="Groove" Text=""></asp:Label> HANGİ KULVARDA YARIŞMAK İSTERSİN ?</</h1>
        </div>

   </div>
    <div style="background-color: #2B0141;  width:1350px;     height:450px;">
       <br /> <br />

            <div style=" float: left;   width:350px;  height: 380px; margin-left:30px; ">
  
                <div  style=" display: inline-block; text-align: center; width: 350px; height: 180px;">
                    <div style=" float: left; margin-right:20px;"> <a href="Sanat.aspx"><input class="bir"  type="button" value="SANAT" /></a> </div>
                    <div> <a href="Bilim.aspx"><input class="iki" type="button" value="BİLİM"  /></a> </div>   
                </div>
                <div style=" display: inline-block; text-align: center; width: 350px; height: 200px;">
                      <a href="Tarih.aspx"><input class="üç" type="button" value="TARİH" /></a>
                </div>
            </div>  
        
            <div style=" float: left;   width: 550px;  height: 453px; border-radius:100px;">
                <img alt="" src="Resimler/A Ana.gif" style="height: 400px; width: 550px; background-color: #1E003C;" />
            </div>

            <div style=" float: left;   width: 350px;  height: 380px;    margin-left:30px;">

              <div style="display: inline-block; text-align: center; width: 350px; height: 180px;">
                 <a href="Edebiyat.aspx"><input class="üç"  type="button" value="EDEBİYAT" /></a>
                 
              </div>

              <div style="display: inline-block; text-align: center; width: 350px; height: 200px;">
                  <div style=" float: left; margin-right:20px;"> <a href="Coğrafya.aspx"><input class="bir" type="button" value="COĞRAFYA" /></a> </div>

                  <div style="margin-top:30px; margin-left:30px;"><a href="Spor.aspx"> <input class="iki" type="button" value="SPOR" /></a></div>
         </div>
    </div>
   
</asp:Content>

