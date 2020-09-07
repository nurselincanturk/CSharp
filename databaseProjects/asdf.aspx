<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="asdf.aspx.cs" Inherits="veritabani.asdf" MasterPageFile="~/veritabani.Master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">

        .auto-style15 {
            width: 100%;
            height: 361px;
           
        }
        .auto-style16 {
           
           border: 4px groove #808080;
        }
       
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
             

    <td colspan="2"><table>
       
                    </table>
                    <asp:Button  Text="UrunSiparisBilgisi" ID="btnSave" runat="server" OnClick="btnSave_Click" style="width:250px;" BackColor="#999999"/><br />

                     <asp:Button Text="SiparisStokSorgulama" ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="width:250px;"/>  <br />                  
                   <asp:Button Text="Fiyatlar" ID="btnGuncelle" runat="server" style="width:250px;" OnClick="btnfiyat"/><br />
                 <%--     <asp:Button Text="KtegoriÜrünBilgileri" ID="btnClear" runat="server" OnClick="btnClear_Click" style="width:250px;"/>--%>
                </td>
    <td><table>
   
               <asp:GridView ID="gvProduct" runat="server" AutoGenerateColumns="false" >
            <Columns>
                <asp:BoundField DataField="productid" HeaderText="id" />
                <asp:BoundField DataField="price" HeaderText="fiyat" />
                 <asp:BoundField DataField="urun_sayisi" HeaderText="urunsayisi" />
                <asp:BoundField DataField="sepetNo" HeaderText="sepetno" />

            </Columns>
        </asp:GridView>


        </table></td>
      <td><table>
   
               <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" >
            <Columns>
                <asp:BoundField DataField="siparisNo" HeaderText="id" />
                <asp:BoundField DataField="count" HeaderText="fiyat" />
                 <asp:BoundField DataField="Expr1" HeaderText="urunsayisi" />
              

            </Columns>
        </asp:GridView>


        </table></td>
      <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="false" >
            <Columns>
                <asp:BoundField DataField="product" HeaderText="id" />
                <asp:BoundField DataField="price" HeaderText="fiyat" />
                 

            </Columns>
        </asp:GridView>


              
   
 </asp:Content>