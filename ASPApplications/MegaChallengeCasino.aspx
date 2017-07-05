<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MegaChallengeCasino.aspx.cs" Inherits="ASPApplications.MegaChallengeCasino" %>

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
                <h2 class="display-5">Mega...</h2>
                <hr class="m-y-2" />
           </div>
		    &nbsp;
      
           <form id="form1" class="" runat="server">
               <div class="row">
                   <div class="col-xs-12 cell" >

                       <asp:Image ID="Image1" runat="server" CssClass="img-fluid img-rounded" Height="150px" Width="150px" />
                       &nbsp;<asp:Image ID="Image2" runat="server" CssClass="img-fluid img-rounded" Height="150px" Width="150px" />
                       &nbsp;<asp:Image ID="Image3" runat="server" CssClass="img-fluid img-rounded" Height="150px" Width="150px" />
                       <br />
                       <br />
                       <asp:Label ID="Label1" runat="server" Text="Your Bet:" class="form-control-label"></asp:Label>
                       &nbsp;<asp:TextBox ID="betTextBox" runat="server" class="form-control" ></asp:TextBox>
                       <br />
                       <br />
                       <asp:Button ID="pullButton" runat="server" Text="Pull The Lever" class="btn btn-success" OnClick="pullButton_Click" />
                       <br />
                       <br />
                       <asp:Label ID="resultLabel" runat="server" class="form-control-label"></asp:Label>
                       <br />
                       <br />
                       <br />
                       <asp:Label ID="moneyLabel" runat="server" class="form-control-label"></asp:Label>
                       <br />
                       <br />
                       1. Cherry - x2 Your Bet<br />
                       2. Cherries- x3 Your Bet<br />
                       3. Cherries- x4 Your Bet<br />
                       3 7&#39;s - Jackpot -x100 your Bet<br />
                       HOWEVER... if there&#39;s even one BAR you win nothing<br />
                       <br />

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