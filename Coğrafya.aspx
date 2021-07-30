<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Coğrafya.aspx.cs" Inherits="bilgiyarisma.Coğrafya" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="Coğrafya.css" rel="stylesheet" />
    <title>Coğrafya Kulvarı</title>
</head>
<body>
    <form id="form1" runat="server">
          <div>
            <div class="Anadiv">
            <div class="üst">
            <div class="ilk"><asp:Label class="sayac" ID="Lblsoru" runat="server" Text="0"></asp:Label></div>
            <div class="ilk2"><asp:TextBox class="textarea" ID="TextBox1" runat="server" ></asp:TextBox></div>
            <div ><asp:Button ID="Button5" runat="server" Text="BAŞLA" OnClick="Button5_Click" /></div>
            </div>
            <div class="ortala" >
                <div class="div"><asp:Button class="btn" ID="Button1" runat="server" Text="A)" OnClick="Button1_Click"/></div>
                <div class="div"><asp:Button class="btn" ID="Button2" runat="server" Text="B)" OnClick="Button2_Click"/></div> 
                <div class="div2">
                    <asp:Label ID="Label1" runat="server" Text="PUAN:"></asp:Label>
                    <asp:Label ID="Label2" runat="server" Text=" 0"></asp:Label>
                </div>
            </div>
            <div class="ortala" >
                <div  class="div"><asp:Button class="btn" ID="Button3" runat="server" Text="C)" OnClick="Button3_Click" /></div>
                <div  class="div"><asp:Button class="btn" ID="Button4" runat="server" Text="D)" OnClick="Button4_Click" /></div>
                <div  class="div2"> 
                    <asp:Label ID="Label3" runat="server" Text="DOĞRU"></asp:Label> 
                     <asp:Label ID="Label5" runat="server" Text=""></asp:Label>
                     <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
                    <asp:Timer ID="Timer1" runat="server" OnTick="Timer1_Tick" Interval="1000"></asp:Timer>
                    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                        <Triggers>
                            <asp:AsyncPostBackTrigger ControlID="Timer1" eventname="Tick" />
                        </Triggers>
                        <ContentTemplate>
                            <asp:Label ID="Label4" runat="server" Text="Zaman"></asp:Label>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                </div>
            </div>  
        </div>
        </div>
    </form>
</body>
</html>
