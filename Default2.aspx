<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="Styles/ImageStyling.css" rel="stylesheet" />
    <title>UpdatePanel Example</title>
    <script runat="server">
    void DropDownSelection_Change(Object sender, EventArgs e)
    {
        Calendar1.DayStyle.BackColor =
            System.Drawing.Color.FromName(ColorList.SelectedItem.Value);
    }

    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {
        SelectedDate.Text = 
            Calendar1.SelectedDate.ToString();
    }

</script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <%--<asp:PlaceHolder ID="plhExecImages" runat="server"></asp:PlaceHolder>--%>

        <div>
            <asp:ScriptManager ID="ScriptManager1" 
                               runat="server" />
            <asp:UpdatePanel ID="UpdatePanel1"
                             runat="server">
                <ContentTemplate>
                    <asp:Calendar ID="Calendar1" 
                                  ShowTitle="True"
                                  OnSelectionChanged="Calendar1_SelectionChanged"
                                  runat="server" />
                    <div>
                        Background:
                        <br />
                        <asp:DropDownList ID="ColorList" 
                                          AutoPostBack="True" 
                                          OnSelectedIndexChanged="DropDownSelection_Change"
                                          runat="server">
                            <asp:ListItem Selected="True" Value="White"> 
                            White </asp:ListItem>
                            <asp:ListItem Value="Silver"> 
                            Silver </asp:ListItem>
                            <asp:ListItem Value="DarkGray"> 
                            Dark Gray </asp:ListItem>
                            <asp:ListItem Value="Khaki"> 
                            Khaki </asp:ListItem>
                            <asp:ListItem Value="DarkKhaki">
                            Dark Khaki </asp:ListItem>
                        </asp:DropDownList>
                    </div>
                    <br />
                    Selected date:
                    <asp:Label ID="SelectedDate" 
                               runat="server">None.</asp:Label>
                </ContentTemplate>
            </asp:UpdatePanel>
            <br />
        </div>

</asp:Content>

