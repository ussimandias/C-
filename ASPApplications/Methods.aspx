<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Methods.aspx.cs" Inherits="ASPApplications.DevSheet6" %>

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
        .auto-style1 {
            color: #33CC33;
        }
        .auto-style2 {
            color: #00CC66;
        }
    </style>
</head>
<body>
    
   <div class="container">
    <div class="jumbotron">
                <h3><span class="auto-style1"><strong>Returning Values from Methods</strong></span><span class="auto-style2"><strong>...</strong></span></h3>
                <hr class="m-y-2" />
           </div>
		    &nbsp;
      
           <form id="form1" class="" runat="server">
               <div class="row">
                   <div class="col-xs-6 cell" >
                       
                        <p>Returning Values from Methods</p>                   
                       <hr />
                        <asp:TextBox ID="displayResultTextBox" runat="server" CssClass="form-control"></asp:TextBox>
                       <asp:Label ID="resultLabel" runat="server" Text="" CssClass="form-control-label"></asp:Label>                   
                   </div>

               </div>
                &nbsp;
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
