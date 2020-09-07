<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="kategori.aspx.cs" Inherits="veritabani.kategori" MasterPageFile="~/veritabani.Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">

        .auto-style15 {
            width: 100%;
            height: 361px;
           
        }
        .auto-style16 {
           
           border: 4px groove #808080
        }
       
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 
                <td>
 
                <table class="auto-style16">
               

                    <asp:HiddenField ID="kategoriID" runat="server" />
                    
                    <tr>
                        <td>kategori adı </td>
                         <td><asp:TextBox ID="kategoriAditxt" runat="server"></asp:TextBox></td>
                    </tr>
                  

                     <tr>
                       <td>
                            <br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                           
                    <asp:Button Text="Ekle" ID="btnSave" runat="server" OnClick="btnSave_Click" />
                     <asp:Button Text="Sil" ID="btnDelete" runat="server" />                    
                   
                     <asp:Button Text="Temizle" ID="btnClear" runat="server" OnClick="btnClear_Click" />
                       </td>
                         </tr>

                      <asp:GridView ID="gvProduct" runat="server" AutoGenerateColumns="false" >
            <Columns>
                <asp:BoundField DataField="idKategori" HeaderText="id" />
                <asp:BoundField DataField="kategoriAdi" HeaderText="ad" />
               
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:LinkButton ID="lnkSelect" runat="server" CommandArgument='<%#Eval("idKategori") %>'  >Select</asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
       
                          <tr><td></td>
                                 <td>
                    <asp:Label Text="" ID="lblSuccessMessage" runat="server" ForeColor="Green" />
                                </td>
                          </tr>
                         <tr><td></td>
                            <td>
                 
                    <asp:Label Text="" ID="lblErrorMessage" runat="server" ForeColor="Red" />
                </td>
            </tr>
                </table>
                </td>
   </asp:Content>
