<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ExecBoard.aspx.cs" Inherits="ExecBoard" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="Styles/ExecBoardCSS.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
        <asp:PlaceHolder ID="plhExecBoard" runat="server"></asp:PlaceHolder>

    <div id="execModal" class="modal">
        
        <div class="modal-content py-3">
            <img id="modal-image" />
            <div id="caption"></div>
            <span class="close fas fa-times-circle"></span>

        </div>
    </div>

    <script>
        function img_click(clicked_id) {
            var mdl = document.getElementById("execModal");

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
<%--        <h1 id="header1" class="execTitle"></h1>
        
        <div id="plhExecBoard"></div>
    <!-- Modal -->
  <div class="modal fade" id="execModal" role="dialog">
    <div class="modal-dialog">

      <!-- Modal content-->
      <div class="modal-content">
        <div class="modal-header">
            <h4 id="header2">Login</h4>
          <button type="button" class="close" data-dismiss="modal">&times;</button>
        </div>
        <div class="modal-body">
          <form role="form">
            <div class="form-group">
              <label for="usrname"><span class="glyphicon glyphicon-user"></span> Username</label>
              <input type="text" class="form-control" id="usrname" placeholder="Enter email">
            </div>
            <div class="form-group">
              <label for="psw"><span class="glyphicon glyphicon-eye-open"></span> Password</label>
              <input type="text" class="form-control" id="psw" placeholder="Enter password">
            </div>
            <div class="checkbox">
              <label><input type="checkbox" value="" checked>Remember me</label>
            </div>
            <button type="submit" class="btn btn-default btn-success btn-block"><span class="glyphicon glyphicon-off"></span> Login</button>
          </form>
        </div>
        <div class="modal-footer">
          <button type="submit" class="btn btn-default btn-default pull-left" data-dismiss="modal"><span class="glyphicon glyphicon-remove"></span> Cancel</button>
          <p>Not a member? <a href="#">Sign Up</a></p>
          <p>Forgot <a href="#">Password?</a></p>
        </div>
      </div>
    </div>
  </div> 
<script src="Javascript/ExecModals.js"></script>--%>

</asp:Content>

