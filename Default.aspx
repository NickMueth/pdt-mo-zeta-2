<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="Styles/homepagetheme.css" rel="stylesheet" />

    <script src="Javascript/HomePageAnimation.js"></script>
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="crop d-md-block d-none" >
        <img src="Images/banner2.jpg" class="image" />
        <div class="overlay fade-in">
            <div class="text">
                <h2 style="display:inline-block">Become the Greatest Version of Yourself</h2>
                <asp:Button ID="btnJoin" runat="server" style="display:inline-block" CssClass="btn btn-primary" Text="Join Now" PostBackUrl="~/Contact.aspx" />
            </div>
        </div>
    </div>
    <div style="overflow:hidden">
        <div class="row bg-primary py-md-5" style="overflow:hidden">
            <div style="color:white; margin-left:9%; margin-right:9%; text-align:center;">
                <h1 class="fade-in">Welcome to the greatest fraternity on earth.</h1>
                <p>Since 1848, Phi Delta Theta has been the pinnacle of moral standards, high academic achievement, and has been a key part in shaping the lives of over 250,000 young men. Everyday, members of Phi Delta Theta strive for the highest level of excellence.</p>
            </div>
        </div>
        <div class="bg-white p-md-3" style="color:#007bff; margin-left:9%; margin-right:9%; text-align:center;">
            <div class="row">
                <p style="margin-top:20px">The founders of Phi Delta Theta put in place three ideals, known as the three Cardinal Principles, that every member of Phi Delta Theta should live their lives by.</p>
            </div>
            <div class="row">
                <div class="col-md-4 p-5">
                    <i class="fas fa-handshake fa-7x"></i>
                    <h1>Friendship</h1>
                </div>
                <div class="col-md-4 p-5">
                    <i class="fas fa-book fa-7x"></i>
                    <h1>Sound Learning</h1>
                </div>
                <div class="col-md-4 p-5">
                    <i class="fas fa-balance-scale fa-7x"></i>
                    <h1>Moral Rectitude</h1>
                </div>
            </div>
        </div>
        <div id="basic-waypoint" class="row bg-primary p-md-5">
            <div style="color:white; margin-left:9%; margin-right:9%; text-align:center;">
                <h1 class="fade-in">Welcome to the Missouri Zeta Chapter</h1>
                <p>The Missouri Zeta Chapter of Phi Delta Theta strives every day to live up to the standards set in place by our founders. Our goal is to be the best fraternity at Southeast Missouri State University, and we are well on our way to that status.</p>
                <div class="row">
                    <div class="col-md-4 p-5">
                        <a style="font-size: 5em">3.3</a>
                        <h1>Average Member GPA</h1>
                        <p>1st out of 10 on campus fraternities</p>
                    </div>
                    <div class="col-md-4 p-5">
                        <span class="counter" style="font-size: 5em">1000</span>
                        <%--<a class="counter" style="font-size: 5em">1000</a>--%>
                        <h1>Service Hours in 2018</h1>
                        <p>1st out of 10 on campus fraternities</p>
                    </div>
                    <div class="col-md-4 p-5">
                        <a style="font-size: 5em">>$1,500</a>
                        <h1>Raised for LiveLikeLou</h1>
                        <p>Phi Delta Theta's philanthropy, going towards helping those with ALS.</p>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <%--<div class="m-2 col-sm bg-light border border-3 shadow">
                
                <div class="d-none d-md-block">
                    <h1>Follow our Twitter!</h1>
                    <a href="https://twitter.com/PhiDeltSemo?ref_src=twsrc%5Etfw" class="twitter-follow-button" data-size="large" data-show-count="false">Follow @PhiDeltSemo</a><script async src="https://platform.twitter.com/widgets.js" charset="utf-8"></script>
                    <hr />
                    <a class="twitter-timeline" data-height="1000" href="https://twitter.com/PhiDeltSEMO?ref_src=twsrc%5Etfw">Tweets by PhiDeltSEMO</a> <script async src="https://platform.twitter.com/widgets.js" charset="utf-8"></script>
                </div>
                <div class="d-block d-md-none">
                    <h3>Follow our Twitter!</h3>
                    <a href="https://twitter.com/PhiDeltSemo?ref_src=twsrc%5Etfw" class="twitter-follow-button" data-size="small" data-show-count="false">Follow @PhiDeltSemo</a><script async src="https://platform.twitter.com/widgets.js" charset="utf-8"></script>
                    <a class="twitter-timeline" data-height="500" href="https://twitter.com/PhiDeltSEMO?ref_src=twsrc%5Etfw">Tweets by PhiDeltSEMO</a> <script async src="https://platform.twitter.com/widgets.js" charset="utf-8"></script>
                </div>
            </div>--%>

</asp:Content>

