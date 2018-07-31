<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div id="myCarousel" class="carousel slide d-none d-sm-block" data-ride="carousel">
        <ol class="carousel-indicators">
          <li data-target="#myCarousel" data-slide-to="0" class="active"></li>
          <li data-target="#myCarousel" data-slide-to="1"></li>
          <li data-target="#myCarousel" data-slide-to="2"></li>
        </ol>
        <div class="carousel-inner"  style="max-height:400px">
          <div class="carousel-item active">
            <img class="first-slide slides" src="Images/Slideshow/slide1.jpg" alt="First slide">
            <div class="container">
              <div class=" carousel-caption text-left">
                <h1>Friendship</h1>
              </div>
            </div>
          </div>
          <div class="carousel-item">
            <img class="second-slide slides" src="Images/Slideshow/slide2.jpg" alt="Second slide">
            <div class="container ">
              <div class="carousel-caption text-left">
                <h1>Sound Learning</h1>
              </div>
            </div>
          </div>
          <div class="carousel-item">
            <img class="third-slide slides" src="Images/Slideshow/slide3.jpg" alt="Third slide">
            <div class="container">
              <div class="carousel-caption text-right">
                <h1>Moral Rectitude</h1>
              </div>
            </div>
          </div>
        </div>
        <a class="carousel-control-prev" href="#myCarousel" role="button" data-slide="prev">
          <span class="carousel-control-prev-icon" aria-hidden="true"></span>
          <span class="sr-only">Previous</span>
        </a>
        <a class="carousel-control-next" href="#myCarousel" role="button" data-slide="next">
          <span class="carousel-control-next-icon" aria-hidden="true"></span>
          <span class="sr-only">Next</span>
        </a>
      </div>

    <div class="row">
        <div class="col-lg-8">
            <div class="row">

            </div>
        </div>
        <div class="col-lg-4">
            <h1>Follow our Twitter!</h1>
            <a>Tweets by @PhiDeltSEMO</a>
        </div>
    </div>

</asp:Content>

