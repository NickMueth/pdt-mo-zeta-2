<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Gallery.aspx.cs" Inherits="Gallery" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="Styles/GalleryCSS.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:PlaceHolder ID="plhGallery" runat="server"></asp:PlaceHolder>

    <div id="galModal" class="modal">
        <div class="modal-content py-3">
            <img class="modal-content" id="modal-image" />
            <div id="caption"></div>
            <span class="close fas fa-times-circle"></span>

        </div>
    </div>

    <script>
        function img_click(clicked_id) {
            var mdl = document.getElementById("galModal");

            var img = document.getElementById(clicked_id);
            var mdlImg = document.getElementById("modal-image");
            var captionText = document.getElementById("caption");

            mdl.style.display = "block";
            mdlImg.src = img.src;
            captionText.innerHTML = img.alt;
            var span = document.getElementsByClassName("close")[0];

            span.onclick = function () {
                mdl.style.display = "none";
            }
            window.onclick = function (event) {
                if (event.target == mdl) {
                    mdl.style.display = "none";
                }
            }

        }
    </script>
</asp:Content>

