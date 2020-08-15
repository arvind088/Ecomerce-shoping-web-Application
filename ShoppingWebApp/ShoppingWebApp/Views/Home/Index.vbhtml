﻿@Code
    ViewData("Title") = "Home Page"
End Code

<div id="themeSlider" class="carousel slide" data-ride="carousel">
    <ol class="carousel-indicators">
        <li data-target="#themeSlider" data-slide-to="0" class="active"></li>
        <li data-target="#themeSlider" data-slide-to="1"></li>
        <li data-target="#themeSlider" data-slide-to="2"></li>
    </ol>

    <div class="carousel-inner">
        <div class="item active">
            <div class="imgOverlay"></div>
            <img style="height:320px; width:100%;" src="..\images\0_03_21_2017_08_03_26.jpg" alt="First slide">
            <div class="carousel-caption">
                <h3>First slide</h3>
                <p>Nulla vitae elit libero, a pharetra augue mollis interdum.</p>
            </div>
        </div>
        <div class="item">
            <div class="imgOverlay"></div>
            <img style="height:320px; width:100%;" src="../images/2_03_21_2017_08_15_59.jpg" alt="Second slide">
            <div class="carousel-caption">
                <h3>Second slide</h3>
                <p>Nulla vitae elit libero, a pharetra augue mollis interdum.</p>
            </div>
        </div>
        <div class="item">
            <div class="imgOverlay"></div>
            <img style="height:320px; width:100%;" src="../images/3_03_21_2017_08_19_28.jpg" alt="Third slide">
            <div class="carousel-caption">
                <h3>Third slide</h3>
                <p>Nulla vitae elit libero, a pharetra augue mollis interdum.</p>
            </div>
        </div>
    </div>

    <a class="left carousel-control" href="#themeSlider" data-slide="prev">
        <span class="fa fa-chevron-left"></span>
    </a>
    <a class="right carousel-control" href="#themeSlider" data-slide="next">
        <span class="fa fa-chevron-right"></span>
    </a>

</div>
<div class="olContent f1"><h2 style="color:black">Search Product/Category</h2></div>
<div class="olSearch fr">
    <input type="text" placeholder="Enter Keyword" name="searchKey" class="inputComn houseText form-control" />
    <div class="searchIcon">
        <button type="button" class="searchBtn">
            <img src="~/Images/searchIcon.png" />
        </button>
    </div>


</div>

<div class="row">
    <div class="col-md-12">
        <div class="page-header">
            <h2>Our Producrs <small>trends products</small></h2>
        </div>
    </div>
</div>

<div class="row product-container">

    <div class="col-md-3 col-sm-3 col-xs-6" style="margin-bottom:8px">
        <div class="thumbnail product-item" style="height:300px">

            <img class="img-responsive" title="Click to View Product detail"
                 style="cursor:pointer;height:160px;width:100%"
                 src="~/Images/81_12_24_2017_10_26_28.jpg" />

            <div class="caption">
                <h5>Product Name</h5>
                <p>500.00 ৳.</p>
                <p>Available</p>
                <div class="product-item-badge">New</div>
            </div>
        </div>
    </div>
</div>
   