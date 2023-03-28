<%@ Page Title="" Language="C#" MasterPageFile="~/admin_panel/admin.Master" AutoEventWireup="true" CodeBehind="AddUser.aspx.cs" Inherits="eng_website.admin_panel.AddUser" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
   
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <link href="admin_panel/user.css" rel="stylesheet" />
   
    
    <div class="container">
    <h4 style="text-align:center;">Kullanıcı Ekle</h4>
    
    <hr>
       <div class="center">
             <div style="float:left ;width:49%; margin:0 auto;">
                  <div> <asp:Label ID="usrlbl" runat="server" CssClass="txtlbl"  Text="Kullanıcı Adı"></asp:Label></div> 
                <div><asp:TextBox ID="usrtxtbx" runat="server" CssClass="txtbx" ></asp:TextBox></div> 
           
             </div>
           <div style="float:right;width:50%; margin:0 auto;">
              <div><asp:Label ID="pswlbl"  runat="server" CssClass="txtlbl"   Text="Şifre"></asp:Label></div>   
               <div><asp:TextBox ID="pswtxtbx" runat="server" CssClass="txtbx" ></asp:TextBox></div> 
             </div>
           
                  <div class="clearfixsavebutton">
      <div class="center">
          <asp:Button ID="bttnsave" CssClass="buttonsave" runat="server" Text="Kaydet" OnClick="bttnsave_Click" /></div>
    </div>
           <br />
           <br />
           <div class="center">
               <asp:Label ID="info_lbl" runat="server" Text=" "></asp:Label>
           </div>

        </div>
      
     
</asp:Content>

