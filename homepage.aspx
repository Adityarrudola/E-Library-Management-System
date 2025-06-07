<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="homepage.aspx.cs" Inherits="WebApplication1.homepage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section>
        <img src="images/home-bg.jpg" class="img-fluid" width="100%" alt="Welcome to our library"/>
    </section>
    <section>
        <div class="container">
            <div class="row">
                <div class="col-12">
                    <h2 class="text-center">Discover Our Features</h2>
                    <p class="lead text-center"><strong>Explore the key highlights of our library:</strong></p>
                </div>
            </div>
            <div class="row">
                <div class="col-md-4">
                    <div class="text-center">
                        <img width="150px" src="images/digital-inventory.png" alt="Digital Book Inventory"/>
                        <h4>Digital Book Inventory</h4>
                        <p class="text-justify">Browse through our extensive digital collection, meticulously curated to satisfy every reader's taste.</p>
                    </div>
                </div>
                <div class="col-md-4">
                    <div class="text-center">
                        <img width="150px" src="images/search-online.png" alt="Search Books"/>
                        <h4>Search Books</h4>
                        <p class="text-justify">Effortlessly search for your favorite titles or discover new ones with our user-friendly search feature.</p>
                    </div>
                </div>
                <div class="col-md-4">
                    <div class="text-center">
                        <img width="150px" src="images/defaulters-list.png" alt="Defaulter List"/>
                        <h4>Defaulter List</h4>
                        <p class="text-justify">Stay updated with our defaulter list, ensuring a smooth borrowing experience for all our members.</p>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <section>
        <img src="images/in-homepage-banner.jpg" class="img-fluid" width="100%" alt="Discover more at our library"/>
    </section>
    <section>
        <div class="container">
            <div class="row">
                <div class="col-12">
                    <h2 class="text-center">Experience Our Process</h2>
                    <p class="lead text-center"><strong>Embark on a seamless journey with our simple 3-step process:</strong></p>
                </div>
            </div>
            <div class="row">
                <div class="col-md-4">
                    <div class="text-center">
                        <img width="150px" src="images/sign-up.png" alt="Sign Up"/>
                        <h4>Sign Up</h4>
                        <p class="text-justify">Begin your library adventure by signing up for a personalized account. It's quick, easy, and free!</p>
                    </div>
                </div>
                <div class="col-md-4">
                    <div class="text-center">
                        <img width="150px" src="images/search-online.png" alt="Search Books"/>
                        <h4>Search Books</h4>
                        <p class="text-justify">Uncover literary gems by seamlessly searching through our vast collection, tailored to your preferences.</p>
                    </div>
                </div>
                <div class="col-md-4">
                    <div class="text-center">
                        <img width="150px" src="images/library.png" alt="Visit Us"/>
                        <h4>Visit Us</h4>
                        <p class="text-justify">Step into our welcoming space and immerse yourself in the world of literature. We can't wait to meet you!</p>
                    </div>
                </div>
            </div>
        </div>
    </section>
</asp:Content>
