<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DevSheet5.aspx.cs" Inherits="ASPApplications.DevSheet5" %>

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
            color: #000099;
        }
    </style>
</head>
<body>
     
   <div class="container">
       <div class="jumbotron">
                <h2 class="display-5">Arrays and Iteration Statements...</h2>
                <hr class="m-y-2" />
           </div>
        &nbsp;
      
           <form id="form1" class="" runat="server">
               <div class="row">
                   <div class="col-xs-12 cell" >
                       <h3><small class="text-muted" style="font-size: 25px; color: #000080; font-weight: bold">Storing values in Arrays</small></h3>
                       <p><small class="text-muted text-success">Type a value to add to the array:</small></p><br />
                       <br />
                       <asp:TextBox ID="TextBox1" runat="server" class="form-control"></asp:TextBox>
                       &nbsp;<asp:TextBox ID="TextBox2" runat="server" class="form-control"></asp:TextBox>
                       &nbsp;<asp:TextBox ID="TextBox3" runat="server" class="form-control"></asp:TextBox>
                       &nbsp;<asp:TextBox ID="TextBox4" runat="server" class="form-control"></asp:TextBox>
                       &nbsp;<asp:TextBox ID="TextBox5" runat="server" class="form-control"></asp:TextBox>
                       <br />
                       <br />
                       <asp:Button ID="addButton" runat="server" Text="Add" class="btn btn-warning" OnClick="addButton_Click" />
                       &nbsp;<asp:Button ID="retrieveButton" runat="server" Text="Retrieve" class="btn btn-warning" OnClick="retrieveButton_Click" />
                       <br />
                       <br />
                       <asp:TextBox ID="resultTextBox" runat="server" class="form-control "></asp:TextBox>

                   </div>

               </div>
                &nbsp;
               <div class="row">
                   <div class="col-xs-6 cell" >

                       <p><small class="text-muted text-success" style="font-size: 25px; color: #000080; font-weight: bold">Understanding Multidimentional Arrays</small></p><br />
                       <br />
                       <asp:RadioButton ID="chicagoRadioButton" runat="server" GroupName="radio1" />
                       &nbsp;Chicago<br />
                       <asp:RadioButton ID="newYorkRadioButton" runat="server" GroupName="radio1" />
                       &nbsp;New York<br />
                       <asp:RadioButton ID="londonRadioButton" runat="server" GroupName="radio1" />
                       &nbsp;London<br />
                       <br />
                       To<br />
                       <br />
                       <asp:RadioButton ID="chicagoRadioButton2" runat="server" GroupName="radio2" />
                       &nbsp;Chicago<br />
                       <asp:RadioButton ID="newYorkRadioButton2" runat="server" GroupName="radio2" />
                       &nbsp;New York<br />
                       <asp:RadioButton ID="londonRadioButton3" runat="server" GroupName="radio2" />
                       &nbsp;London<br />
                       <br />
                       <asp:Button ID="multidimentionButton" runat="server" Text="Ok" CssClass="btn btn-primary" OnClick="multidimentionButton_Click" />
                       <br />
                       <br />
                       <asp:TextBox ID="multiresultTextBox" runat="server" CssClass="form-control"></asp:TextBox>

                   </div>

               </div>
                &nbsp;
               <div class="row">
                   <br />
                   <div class="col-xs-6 cell" >
                       <h4 class="auto-style1">Changing the Length of an Array</h4>
                       <hr />
                       <p class="text-muted">
                           Hours Worked on Project:</p>
                       
                       <asp:TextBox ID="hoursworkedTextBox" runat="server" CssClass="form-control"></asp:TextBox>
                        <br />
                       <asp:Button ID="addhoursButton" runat="server" Text="Ok" CssClass="btn btn-primary" OnClick="addhoursButton_Click" />
                       <br />
                       <br />
                       <asp:Label ID="addHoursResultLabel" runat="server" CssClass="form-control-label" ></asp:Label>

                   </div>

               </div>
                &nbsp;
                <div class="row">
                    <div class="col-xs-6 cell" >
                        <h4 class="auto-style1">Challenge: EpicSpies Asset Tracker</h4>
                        <img src="epicspies.jpg" Height="200px" Width="200px" />
                        <br />

                        <h3 class="text-muted text-primary">Asset Performance Tracker</h3>
                        <p class="text-muted text-primary">&nbsp;</p>
                        <p class="text-muted text-primary">Asset Name:</p>
                        
                        <asp:TextBox ID="assetNameTextBox" runat="server" CssClass="form-control"></asp:TextBox>
                        
                        <p class="text-muted text-primary">&nbsp;</p>
                        <p class="text-muted text-primary">Elections Rigged:</p>
                        <asp:TextBox ID="riggedTextBox" runat="server"  class="form-control"></asp:TextBox>
                      
                        <p class="text-muted text-primary">&nbsp;</p>
                        <p class="text-muted text-primary">Acts of Subterfuge Performed:</p>
                        <asp:TextBox ID="actsPerformedTextBox" runat="server"  class="form-control"></asp:TextBox>
                        
                        <p class="text-muted text-primary">&nbsp;</p>
                        <asp:Button ID="addAssetButton" runat="server" Text="Add Asset" class="btn btn-warning" OnClick="addAssetButton_Click" />
                        
                        <p class="text-muted text-primary">&nbsp;</p>
                        <asp:Label ID="assetResultLabel" runat="server" Text=""></asp:Label>
                       

                    </div>

                    <br />

                </div>
                &nbsp;
                <div class="row">
                    <div class="col-xs-6 cell" >
                         <p class="text-muted text-primary">Code Blocks and Nested Statements</p>
                        <hr />
                        <asp:CheckBox ID="CheckBox1" runat="server" />
                        <br />
                        <asp:CheckBox ID="CheckBox2" runat="server" />
                        <br />
                        <asp:CheckBox ID="CheckBox3" runat="server" />
                        <br />
                        <br />
                        <asp:Button ID="nestedAddButton" runat="server" Text="Add" CssClass="btn btn-success" OnClick="nestedAddButton_Click" />
                        <br />
                        <br />
                        <asp:TextBox ID="nestedResultTextBox" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>

                </div>
                &nbsp;

                &nbsp;
                <div class="row">
                    <div class="col-xs-6 cell" >
                         <p class="text-muted text-primary">Looping with the for Iteration statement</p>
                        <hr />
                        <asp:Label ID="forloopResultLabel" runat="server" Text="" CssClass="form-control-label"></asp:Label>
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
