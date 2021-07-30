<%@ Page Title="" Language="C#" MasterPageFile="~/Ana.Master" AutoEventWireup="true" CodeBehind="SanatPuan.aspx.cs" Inherits="bilgiyarisma.WebForm6" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

     <br /><br />
    <form style="margin:auto; width:600px; border-radius:50px;">
     <h1 style="color:white; font-size:32px; text-align:center;"> SANAT KULVARI SIRALAMASI</h1>
        <br />
        <table class="table table-striped table-dark">
          <thead>
            <tr>
              <th scope="col">#</th>
              <th scope="col">Oyuncu Adı</th>
              <th scope="col">Puanı</th>
             
            </tr>
          </thead>
          <tbody>
         <asp:Repeater ID="Repeater1" runat="server">
                  <ItemTemplate>
                      <tr>
                          <td><%#Eval("id")%></td>
                          <td><%#Eval("OyuncuAdı")%></td>
                          <td><%#Eval("puan")%></td>
                      </tr>
                  </ItemTemplate>
              </asp:Repeater>
           
          </tbody>
        </table>
    </form>

</asp:Content>
