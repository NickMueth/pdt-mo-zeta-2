<%@ Page Title="" Language="C#" MasterPageFile="~/PhiPortal/Portal.master" AutoEventWireup="true" CodeFile="Manage.aspx.cs" Inherits="PhiPortal_Manage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h1>MANAGE ACCOUNT PAGE</h1>
    <asp:HyperLink ID="btnChangePassword" runat="server" CssClass="btn btn-dark w-50" Text="Change password" NavigateUrl="#ContentPlaceHolder1_mdlChangePassword" data-toggle="modal"></asp:HyperLink>
    
    <asp:Label ID="lblSuccessOrError" runat="server" Visible="false" Text=""></asp:Label>


    <!--CHANGE PASSWORD MODAL-->
    <asp:Panel runat="server" CssClass="modal fade" ID="mdlChangePassword">
            <asp:Panel runat="server" CssClass="modal-dialog" role="document">
                <asp:Panel runat="server" CssClass="modal-content">
                    <asp:Panel runat="server" CssClass="modal-header bg-info">
                        <h5 class="modal-title">Change Password</h5>
                        <button type="button" class="close" data-dismiss="modal">
                            <span>×</span>
                        </button>
                    </asp:Panel>
                    <asp:Panel runat="server" CssClass="modal-body">
                        <asp:Label ID="Label1" runat="server" Text="Old password:"></asp:Label>
                        <asp:TextBox ID="txtBoxOldPassword" runat="server"></asp:TextBox>
                    </asp:Panel>
                    <asp:Panel runat="server" CssClass="modal-body">
                        <asp:Label ID="Label2" runat="server" Text="New password:"></asp:Label>
                        <asp:TextBox ID="txtBoxNewPassword" runat="server"></asp:TextBox>
                    </asp:Panel>
                    <asp:Panel runat="server" CssClass="modal-body">
                        <asp:Label ID="Label3" runat="server" Text="Confirm new password:"></asp:Label>
                        <asp:TextBox ID="txtBoxConfirmPassword" runat="server"></asp:TextBox>
                    </asp:Panel>
                    <asp:Panel runat="server" CssClass="modal-footer">
                        <asp:Button ID="btnChange" runat="server" CssClass="btn btn-primary w-25" Text="Change" OnClick="btnChange_Click"/>
                        <asp:Button ID="btnCancel" runat="server" CssClass="btn btn-secondary w-25" Text="Cancel" data-dismiss="modal"/>
                    </asp:Panel>
                </asp:Panel>
            </asp:Panel>
        </asp:Panel>
</asp:Content>

