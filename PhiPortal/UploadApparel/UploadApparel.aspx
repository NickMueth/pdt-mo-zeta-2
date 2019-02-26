<%@ Page Title="" Language="C#" MasterPageFile="~/PhiPortal/Portal.master" AutoEventWireup="true" CodeFile="UploadApparel.aspx.cs" Inherits="PhiPortal_UploadApparel_UploadApparel" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Panel ID="Panel1" CssClass="col-md-6" runat="server">
        <h1 class="text-center">Apparel Upload</h1>
        <asp:Panel ID="Panel2" CssClass="row" runat="server">
            <asp:Label ID="Label1" runat="server" CssClass="col-auto" Text="Shirt Title: "></asp:Label><asp:TextBox ID="txtShirtTitle" CssClass="col-2" runat="server"></asp:TextBox>
        </asp:Panel>
        <asp:Panel CssClass="row" runat="server">
            <asp:Label ID="Label2" runat="server" CssClass="col-auto" Text="Shirt Description (Please keep fairly brief): "></asp:Label><asp:TextBox ID="txtDescription" CssClass="" runat="server"></asp:TextBox>
        </asp:Panel>
        <asp:Panel CssClass="row" runat="server">
            <asp:Label ID="Label3" runat="server" CssClass="col-auto" Text="Shirt Price: "></asp:Label><asp:TextBox ID="txtPrice" runat="server"></asp:TextBox>
        </asp:Panel>
        <asp:Panel CssClass="row" runat="server">
            <asp:Label ID="Label4" runat="server" CssClass="col-auto" Text="Last Date to Order: "></asp:Label><asp:Calendar ID="calEndDate" runat="server"></asp:Calendar>
        </asp:Panel>
        <asp:Panel CssClass="row" runat="server">
            <asp:Label ID="Label5" runat="server" CssClass="col-auto" Text="Upload picture of shirt: "></asp:Label><asp:FileUpload ID="uplApparelPhoto" runat="server" />
        </asp:Panel>
        <asp:Button ID="btnUploadApparel" OnClick="btnUploadApparel_Click" runat="server" Text="Upload" />
        <asp:Label ID="lblUploadStatus" runat="server" Visible="false"></asp:Label>
    </asp:Panel>
</asp:Content>

