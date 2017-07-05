<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DefiningAndCallingHelperMethods.aspx.cs" Inherits="ASPApplications.DefiningAndCallingHelperMethods" %>

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
                <h2 class="display-5">Defining And Calling Helper Methods...</h2>
                <hr class="m-y-2" />
           </div>
		    &nbsp;
      
           <form id="form1" class="" runat="server">
               <div class="row">
                   <div class="col-xs-6 cell" >

                       <p>Convert to Cups</p>
                       <hr/>
                       <asp:TextBox ID="convertTextBox" runat="server" CssClass="form-control" AutoPostBack="True" OnTextChanged="convertTextBox_TextChanged" ></asp:TextBox>
                       <br />
                       <br />
                       <asp:RadioButton ID="cupsRadioButton" runat="server"  Text="Cups" GroupName="measurements" AutoPostBack="True" OnCheckedChanged="cupsRadioButton_CheckedChanged" />
                       <br />
                       <asp:RadioButton ID="pintsRadioButton" runat="server" Text="Pints" GroupName="measurements" AutoPostBack="True" OnCheckedChanged="pintsRadioButton_CheckedChanged"  />
                       <br />
                       <asp:RadioButton ID="quartsRadioButton" runat="server" Text="Quarts" GroupName="measurements" AutoPostBack="True" OnCheckedChanged="quartsRadioButton_CheckedChanged"  />
                       <br />
                       <asp:RadioButton ID="gallonsRadioButton" runat="server" text="Gallons" GroupName="measurements" AutoPostBack="True" OnCheckedChanged="gallonsRadioButton_CheckedChanged"  />
                       <br />
                       <br />
                       <asp:TextBox ID="resultTextBox" runat="server" CssClass="form-control"></asp:TextBox>

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
