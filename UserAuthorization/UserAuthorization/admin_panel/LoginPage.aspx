<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="eng_website.Login.LoginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Loginstyle.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="container">
  <div class="header">
    <h1>Hoşgeldiniz</h1>
  </div>
  <div class="input_area">
      <asp:TextBox ID="ncknm_txtbx" placeholder="Kullanıcı Adı" runat="server"></asp:TextBox>
      <asp:TextBox ID="sifre_txtbx" placeholder="Şifre" runat="server"></asp:TextBox>
      <asp:Label ID="Label2" runat="server" ></asp:Label>
  </div>
  <div class="actions">
      <asp:Button ID="Button1"  runat="server" CssClass="actionsbutton" Text="Giriş yap" Width="200px" OnClick="Button1_Click" />
    
  </div>
</div>
  </div>
        
    </form>
</body>
</html>
