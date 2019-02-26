<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Philanthropy.aspx.cs" Inherits="Philanthropy" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="Styles/homepagetheme.css" rel="stylesheet" />
    <style>
        .crop{
            width:100%;
            height:550px;
            margin-top:-150px;
            overflow:hidden;
        }
    </style>    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="crop d-md-block d-none" >
        <img src="Images/Gallery/image4.jpg" class="image" />
        <div class="overlay">
            <div class="text text-center">
                <h2 style="display:inline-block">Support Our Journey To Become An Iron Phi Chapter!</h2>
                <a id="btnDonate" href="http://support.ironphi.org/site/TR/Events/General?team_id=1127&pg=team&fr_id=1040" target="_blank" class="btn btn-primary" style="display:inline-block">Donate</a>
            </div>
        </div>
    </div>
    <div style="overflow:hidden" class="mx-auto">
        <div class="row py-md-5" style="overflow:hidden">
            <div style="color:#007bff; margin-left:15%; margin-right:15%; text-align:center;">
                <h1>"We enjoy life by the help and society of others..." - Phi Delta Theta Open Motto</h1>
                <p></p>
                <iframe width="560" height="315" src="https://www.youtube.com/embed/MNzgT0bXKL4" frameborder="5" allow="accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture" allowfullscreen></iframe>
            </div>
        </div>
        
    </div>
</asp:Content>

