<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="arama.aspx.cs" Inherits="veritabani.arama" MasterPageFile="~/veritabani.Master" %>


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
        <table>
            <tr>
              
                <td colspan="2">
                    <asp:TextBox ID="txtsoyad" runat="server"> </asp:TextBox>
                
               </td>
                <td colspan="2">
                     <asp:Button Text="Ekle" ID="btnSave" runat="server" OnClick="btnSave_Click" />

                </td>
                 <asp:GridView ID="gvProduct" runat="server" AutoGenerateColumns="false" >
            <Columns>
                <asp:BoundField DataField="name" HeaderText="ad" />
                <asp:BoundField DataField="lastname" HeaderText="soyad" />
                 <asp:BoundField DataField="email" HeaderText="email" />
                <asp:BoundField DataField="password" HeaderText="sifre" />
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:LinkButton ID="lnkSelect" runat="server" CommandArgument='<%#Eval("userid") %>'  OnClick="lnk_OnClick">Select</asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
            </tr>

        </table>

    </td>
    


         </asp:Content>