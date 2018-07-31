<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="PhiPortal_Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Panel runat="server" CssClass="row text-center">
        <asp:Panel runat="server" CssClass="col-lg-3 d-none d-md-block">
        </asp:Panel>
        <asp:Panel runat="server" CssClass="col-lg-6">
            <asp:Panel ID="pnlLoginContainer" runat="server" CssClass="container bg-light">
                <asp:Panel ID="pnlLoginHeader" runat="server" CssClass="bg-info py-2">
                    <asp:Label ID="lblLoginHeader" Font-Bold="True" Font-Size="X-Large" runat="server" Text="Login"></asp:Label>
                </asp:Panel>
                <asp:Panel ID="pnlLoginUsername" runat="server" CssClass="row p-3">
                    <asp:Label ID="lblUsername" CssClass="col-sm-4" runat="server" Text="Username:"></asp:Label>
                    <asp:TextBox ID="txtbxUsername" CssClass="col-sm-8 rounded-top" placeholder="Username" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="reqFieldValUser" runat="server" ErrorMessage="Required Field" ControlToValidate="txtbxUsername" Font-Bold="True" ForeColor="Red"></asp:RequiredFieldValidator>
                </asp:Panel>
                <asp:Panel ID="pnlLoginPassword" runat="server" CssClass="row px-3">
                    <asp:Label ID="lblPassword" CssClass="col-sm-4" runat="server" Text="Password:"></asp:Label>
                    <asp:TextBox ID="txtbxPassword" CssClass="col-sm-8 rounded-bottom" placeholder="Password" TextMode="Password" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="reqFieldValPass" runat="server" ErrorMessage="Required Field" ControlToValidate="txtbxPassword" Font-Bold="True" ForeColor="Red"></asp:RequiredFieldValidator>
                </asp:Panel>
                <asp:Panel ID="pnlLoginFooter" runat="server" CssClass="py-2" Style="text-align: center">
                    <asp:Label ID="lblLoginError" CssClass="alert alert-danger" runat="server" Visible="false" Font-Bold="true" ForeColor="Red" Text="Login Error: Username or Password invalid."></asp:Label>
                    <br />
                    <asp:Button ID="btnLogin" CssClass="btn btn-primary" Width="50%" runat="server" Text="Login" OnClick="btnLogin_Click"></asp:Button>
                </asp:Panel>
            </asp:Panel>
        </asp:Panel>
        <asp:Panel runat="server" CssClass="col-lg-3  d-none d-md-block">
        </asp:Panel>
    </asp:Panel>
</asp:Content>

