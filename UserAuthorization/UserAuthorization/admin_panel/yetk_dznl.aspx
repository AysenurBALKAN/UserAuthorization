<%@ Page Title="" Language="C#" MasterPageFile="~/admin_panel/admin.Master" AutoEventWireup="true" CodeBehind="yetk_dznl.aspx.cs" Inherits="eng_website.yetk_dznl" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../css/user.css" rel="stylesheet" />

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div class="center">
        <h5>Kullanıcı Yetki Düzenleme Sayfası</h5>
        <asp:Panel ID="Panel1"  CssClass="chckbx-box" runat="server">
           <div class="left-div"><asp:Label ID="kllc_id_lbl" Width="100%" runat="server" Text="Kullanıcı ID :"></asp:Label></div>
            <div class="right-div"><asp:TextBox ID="kllnc_id_txtbx" Width="100%" runat="server" ReadOnly="True"></asp:TextBox> </div>
            <div class="left-div"><asp:Label ID="kllnc_ad_lbl"  Width="50%"  runat="server" Text="Kullanıcı Adı :" style="margin-left: 0px"></asp:Label></div>
            <div class="right-div"><asp:TextBox ID="kllnc_ad_txtbx" Width="100%" runat="server" ReadOnly="True"></asp:TextBox> 
           </div>
          
            <br />
           <div class="baslik-div"><h4>Kullanıcı Yetkileri</h4></div>
            <div>
    <asp:CheckBoxList ID="chckbx_yetki" CssClass=" pnl table" RepeatColumns="3" runat="server">
    </asp:CheckBoxList>
                </div>
            <div>
    <asp:Button ID="Button1" runat="server" Text="Kaydet" CssClass=" buttonsave btn btn-success" OnClick="Button1_Click"  />
    <asp:Button ID="Button2" runat="server" Text="İptal" CssClass="btn_iptl btn btn-danger" OnClick="Button2_Click" /></div>
            
            </asp:Panel>
    </div>

</asp:Content>
