<%@ Page Title="" Language="C#" MasterPageFile="~/admin_panel/admin.Master" AutoEventWireup="true" CodeBehind="kullanici_yetki.aspx.cs" Inherits="eng_website.admin_panel.kullanici_yetki" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script src="https://code.jquery.com/jquery-3.6.0.js"></script>
    <script src="../Scripts/DataTables/jquery.dataTables.js"></script>
    <link href="../Content/DataTables/css/jquery.dataTables.css" rel="stylesheet" />
    <link href="home.css" rel="stylesheet" />
    <h2>Kullanıcı Yetkileri Düzenleme Sayfası</h2>
    <div class="center">
        <table class="table" id="myTable">
  <thead>
    <tr>
       
      <th scope="col">User ID</th>
      <th scope="col">User Nickname</th>
      <th scope="col">Şifre</th>

      
        <th scope="col">İşlemler</th>
    </tr>
  </thead>
  <tbody>
      <asp:Repeater ID="Repeaterytk" runat="server">
          <ItemTemplate>
              <tr>
                 
                  <td><%#Eval("user_id")%></td>
                   <td><%#Eval("usr_ncknm")%></td>
                  <td><%#Eval("sifre")%></td>
                 

                  <td>
                      <asp:HyperLink ID="dznl" CssClass=" btn btn-success"  NavigateUrl='<%#"~/K_YD?user_id="+Eval("user_id") %>'  runat="server">Düzenle</asp:HyperLink>
                   <a href="/K_YE?user_id=<%#Eval("user_id") %>&islem=sil " id="dlt" onclick="return confirm('Kayıt silinecek. Devam edecek misiniz?')">
                       <asp:Label ID="Label1" CssClass="btn btn-danger"  runat="server"   Text="Sil"></asp:Label>
                       </a>
          </script>
                      <script>
                          $(document).ready(function () {
                              $('#myTable').DataTable();
                          });
                      </script>
                  </td>
              </tr>
          </ItemTemplate>
      </asp:Repeater>
  </tbody>
</table>
       
    </div>
</asp:Content>
