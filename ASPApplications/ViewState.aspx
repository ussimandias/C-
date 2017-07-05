<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewState.aspx.cs" Inherits="ASPApplications.Devsheet4" %>

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

    <form id="form1" runat="server">

   <div class="container">
        <div class="jumbotron">
                <h1 class="display-5">ASP.NET Fundamentals...</h1>
                <hr class="m-y-2" />

        </div>

       <div class="row">
           <div class="col-xs-6 cell" >

               <h3 class="text-muted text-primary">Maintaining State with ViewState </h3>
               Type a value to add to the string:<br />
               <br />
               Server Control:<br />
               <asp:TextBox ID="serverTextBox" runat="server" class="form-control"></asp:TextBox>
               <br />
               <br />
               Plain ol&#39; HTML Input Text field:<br />
               <input type="text" ID="htlmTextBox" class="form-control" />
               <br />
               <br />
               <asp:Button ID="addButton" runat="server" Text="Add" class="btn btn-warning" OnClick="addButton_Click" />
               <br />
               <br />
               <asp:Label ID="resultLabel" runat="server" Text=""></asp:Label>


           </div>
       </div>
       &nbsp;
	   <div class="row">
           <div class="col-xs-6 cell" ></div>
       </div>
        &nbsp;
	   <div class="row">
           <div class="col-xs-6 cell" ></div>
       </div>
   </div>

    <!-- jQuery first, then Bootstrap JS. -->
    <!--<script src="https://ajax.googleapis.com/ajax/libs/jquery/2.1.4/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0-alpha.2/js/bootstrap.min.js" integrity="sha384-vZ2WRJMwsjRMW/8U7i6PWi6AlO1L79snBrmgiDpgIWJ82z8eA5lenwvxbMV1PAh7" crossorigin="anonymous"></script>-->
    <script src="Scripts/jquery-2.0.0.js"></script>
    <script src="Scripts/bootstrap.js"></script>
    </form>
</body>
</html>
