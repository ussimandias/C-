﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ChallengePostageCalculatorHelperMethods.aspx.cs" Inherits="ASPApplications.DevSheet7" %>

<!DOCTYPE html>
<html lang="en">
<head>
    <!-- Required meta tags always come first -->
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <meta http-equiv="x-ua-compatible" content="ie=edge">

    <!-- Bootstrap CSS -->
    <!--<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0-alpha.2/css/bootstrap.min.css" integrity="sha384-y3tfxAZXuh4HwSYylfB+J125MxIs6mR5FOHamPBG064zB+AFeWH94NdvaCBm8qnd" crossorigin="anonymous">-->
    <link href="Content/bootstrap.css" rel="stylesheet" />
    <style>
        .cell{
            background-color:#efefff;
            border: 2px solid #9d9df7;
            padding-top: 20px;
            padding-bottom: 20px;
        }
    </style>
</head>
<body>
    
   <div class="container">
    <div class="jumbotron">
                <h2 class="display-5">Challenge Postage  Calculator HelperMethods...</h2>
                <hr class="m-y-2" />
           </div>
		    &nbsp;
      

           <form id="form1" class="" runat="server">
               <div class="row">
                   <div class="col-xs-6 cell" >

                       <p>Postal Calculator</p>
                        <asp:Label ID="titleLabel" runat="server" Text=""></asp:Label>
                       <asp:Label ID="Label1" runat="server" Text="Width"></asp:Label>
                      
                       <br />
                       <br />
                       <asp:TextBox ID="widthTextBox" runat="server" CssClass="form-control" AutoPostBack="True" OnTextChanged="handleChange"></asp:TextBox>
                       <br />
                       <br />
                       <asp:Label ID="Label2" runat="server" Text="Height"></asp:Label>
                       <br />
                       <br />
                       <asp:TextBox ID="heightTextBox" runat="server" CssClass="form-control" AutoPostBack="True" OnTextChanged="handleChange"></asp:TextBox>
                       <br />
                       <br />
                       <asp:Label ID="Label3" runat="server" Text="Length"></asp:Label>
                       <br />
                       <br />
                       <asp:TextBox ID="lenghtTextBox" runat="server" CssClass="form-control" AutoPostBack="True" OnTextChanged="handleChange" ></asp:TextBox>
                       <br />
                       <br />
                       <asp:RadioButton ID="groundRadioButton" runat="server" AutoPostBack="True" Text="Ground" GroupName="shipped" OnCheckedChanged="handleChange" />
                       <br />
                       <asp:RadioButton ID="airRadioButton" runat="server" AutoPostBack="True" Text="Air" GroupName="shipped" OnCheckedChanged="handleChange" />
                       <br />
                       <asp:RadioButton ID="newDayRadioButton" runat="server" AutoPostBack="True" Text="New Day" GroupName="shipped" OnCheckedChanged="handleChange" />
                       <br />
                       <br />
                       <asp:Label ID="resultLabel" runat="server" Text=""></asp:Label>
                        &nbsp;
                   </div>

               </div>
                &nbsp;
               <div class="row">
                   <div class="col-xs-6 cell" >

                   </div>

               </div>
                &nbsp;
               <div class="row">
                   <div class="col-xs-6 cell" >

                   </div>

               </div>
                &nbsp;
           </form>

   </div>
       
	   

    <!-- jQuery first, then Bootstrap JS. -->
    <!--<script src="https://ajax.googleapis.com/ajax/libs/jquery/2.1.4/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0-alpha.2/js/bootstrap.min.js" integrity="sha384-vZ2WRJMwsjRMW/8U7i6PWi6AlO1L79snBrmgiDpgIWJ82z8eA5lenwvxbMV1PAh7" crossorigin="anonymous"></script>-->
    <script src="Scripts/jquery-2.0.0.js"></script>
    <script src="Scripts/bootstrap.js"></script>
</body>
</html>
