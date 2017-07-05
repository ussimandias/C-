<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DevSheet1.aspx.cs" Inherits="ASPApplications.DataTypeConversion" %>

<!DOCTYPE html>
<html lang="en">
  <head>
    <!-- Required meta tags always come first -->
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <meta http-equiv="x-ua-compatible" content="ie=edge">

    <!-- Bootstrap CSS -->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0-alpha.2/css/bootstrap.min.css" integrity="sha384-y3tfxAZXuh4HwSYylfB+J125MxIs6mR5FOHamPBG064zB+AFeWH94NdvaCBm8qnd" crossorigin="anonymous">
  </head>
  <body>
      <div class="container">
           <div class="jumbotron">
                <h1 class="display-5">Getting Started...</h1>
                <h3 class="display-6">Data Types, Variables and Operators...</h3>
                <hr class="m-y-2" />
           </div>
          <div class="row">
              <div class="col-md-6">

                  <form id="form1" class="" runat="server"> 

                      <div class="form-control">
                          <h4>Building your First Web App</h4>
                          <div class="form-group">
                              <asp:Label ID="Label1" runat="server"  class="form-control-label" Text="First Name"></asp:Label>
                              <asp:TextBox ID="firstNameTextBox" runat="server"  class="form-control"></asp:TextBox>

                          </div>
                          <div class="form-group">
                              <asp:Label ID="Label2" runat="server" class="form-control-label" Text="Last Name"></asp:Label>
                              <asp:TextBox ID="lastNameTextBox" runat="server" class="form-control"></asp:TextBox>

                          </div>
                          
                          <asp:Button ID="submit_Button1" runat="server" class="btn btn-primary" Text="Submit" OnClick="submit_Button1_Click" />
                          <p> &nbsp;</p>
                          
                          <div class="form-group">
                              <asp:Label ID="resultLabel" runat="server"  class="form-control-label"></asp:Label>
                          </div>

                      </div>
                      
                      
                         <p> &nbsp;</p>                      
                      <div class="form-control">
                          <h4>  Data Type Conversion</h4>
                           <div class="form-group">                                
                               <asp:TextBox ID="dataTextBox" runat="server"  class="form-control" placeholder="enter a numeric value"></asp:TextBox>
                               <small class="text-muted">
                                   This value will be added to 2 !

                               </small>
                           </div>
                          <asp:Button ID="goButton1" runat="server" class="btn btn-success" Text="Go!" OnClick="goButton1_Click"/>
                          <p> &nbsp;</p>
                          <div class="form-group">
                              <asp:Label ID="dataLabel" runat="server"  class="form-control-label"></asp:Label>

                          </div>
                      </div>
                                         
                      
                         <p> &nbsp;</p>                    
                      <div class="form-control">
                           <h4>  Arithematic Operators</h4>
                           <div class="form-group">                          
                               <asp:TextBox ID="mathTextBox" runat="server"  class="form-control" placeholder="enter a numeric value"></asp:TextBox>
                               <small class="text-muted">
                                   Arithematic Operators

                               </small>
                           </div>
                          <asp:Button ID="mathButton" runat="server" class="btn btn-warning" Text="Go!" OnClick="mathButton_Click"/>
                          <p> &nbsp;</p>
                          <div class="form-group">
                              <asp:Label ID="mathLabel" runat="server"  class="form-control-label"></asp:Label>

                          </div>
                      </div>

                        <p> &nbsp;</p> 
                       <div class="form-control">
                           <h4>Simple Calculator</h4>
                             <div class="form-group">

                                 <asp:Label ID="Label3" runat="server" class="form-control-label" Text="First Value"></asp:Label>
                                 &nbsp;<asp:TextBox ID="firstValueTextBox" runat="server" class="form-control"></asp:TextBox>
                                 <br />
                                 <asp:Label ID="Label4" runat="server" class="form-control-label" Text="Second Value"></asp:Label>
                                 <asp:TextBox ID="secondValueTextBox" runat="server" class="form-control"></asp:TextBox>
                                 <br />
                                 <asp:Label ID="Label5" runat="server" class="form-control-label" Text="Result"></asp:Label>
                                 <asp:TextBox ID="resultTextBox" runat="server" class="form-control" Font-Bold="True" ForeColor="#66FF66"></asp:TextBox>
                                 <br />
                                 <asp:Button ID="addButton" runat="server" Text="+" class="btn btn-primary" OnClick="addButton_Click"/>
                                 &nbsp;<asp:Button ID="subtractButton" runat="server" Text="-" class="btn btn-warning" OnClick="subtractButton_Click"/>
                                 &nbsp;<asp:Button ID="multiplyButton" runat="server" Text="*" class="btn btn-success" OnClick="multiplyButton_Click"/>
                                 &nbsp;<asp:Button ID="divideButton" runat="server" Text="/" class="btn btn-danger" OnClick="divideButton_Click" />

                             </div>
                       </div>  
                        <p> &nbsp;</p>   

                        <div class="form-control">
                           <h4>The conditional statement</h4>
                            <div class="form-group">

                                <asp:Label ID="Label6" runat="server" Text="Is" class="form-control-label"></asp:Label>
                                &nbsp;<asp:TextBox ID="conditionTextBox" runat="server" class="form-control" BorderColor="#003300"></asp:TextBox>
                                &nbsp;<asp:Label ID="Label7" runat="server" Text="equal to" class="form-control-label" ></asp:Label>
                                &nbsp;<asp:TextBox ID="secondConditionTextBox" runat="server" class="form-control" BorderColor="#003300"></asp:TextBox>   
                                 
                                <asp:CheckBox ID="coolCheckBox" runat="server" Text="Are you cool?.." />
                                <br />
                                <p class="lead">if you could only eat one food for the rest of your life, what would you choose?</p>
                                <asp:RadioButton ID="pizzaRadioButton" runat="server" TexT="Pizza" GroupName="FoodGroup" />
                                 <br />
                                <asp:RadioButton ID="saladRadioButton2" runat="server" Text="Salad" GroupName="FoodGroup" />
                                 <br />
                                <asp:RadioButton ID="pbjRadioButton3" runat="server" Text="PBJ" GroupName="FoodGroup" />
                                 <br />
                                 <br />                                              
                                <asp:Button ID="okConditionButton" runat="server" Text="Ok" class="btn btn-success" OnClick="okConditionButton_Click" />
                                <br />
                                <br />                           
                                <asp:TextBox ID="resultCondidtionTextBox" runat="server" class="form-control" BorderColor="#800000" Font-Bold="false" ForeColor="#000099"></asp:TextBox>
                                <br />
                                                           
                            </div>

                        </div>

                      <p> &nbsp;</p>   

                      <div class="form-control">
                          <h4>Radio Button Challange</h4>
                          <div class="form-group">
                              <p class="lead"> Your note taking Preferences</p>
                               <p> &nbsp;</p>
                      <p> 
                          <asp:RadioButton ID="pencilRadioButton" runat="server" GroupName="MyChoices" Text="Pencil" />
                      </p>
                      <p> 
                          <asp:RadioButton ID="penRadioButton" runat="server" GroupName="MyChoices" Text="Pen" />
                      </p>
                      <p> 
                          <asp:RadioButton ID="phoneRadioButton" runat="server" GroupName="MyChoices" Text="Phone" />
                      </p>
                      <p> 
                          <asp:RadioButton ID="tabletRadioButton" runat="server" GroupName="MyChoices" Text="Tablet" />
                      </p>
                      <p> &nbsp;</p>
                      <p> 
                          <asp:Image ID="myImage" runat="server" Height="200px" Width="200px"  />
                      </p>
                      <p> &nbsp;</p>
                      <p> 
                          <asp:Button ID="choiceButton" runat="server" Text="Ok" class="btn btn-primary" OnClick="choiceButton_Click" />
                      </p>
                              <p> 
                                  <asp:Label ID="choicePickLabel" runat="server" Text=""></asp:Label>
                      </p>
                      <p> &nbsp;</p> 
                          </div>
                      </div>
                      <p> &nbsp;</p> 

                      
                  </form>

              </div>
          </div>

      </div> 

    <!-- jQuery first, then Bootstrap JS. -->
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/2.1.4/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0-alpha.2/js/bootstrap.min.js" integrity="sha384-vZ2WRJMwsjRMW/8U7i6PWi6AlO1L79snBrmgiDpgIWJ82z8eA5lenwvxbMV1PAh7" crossorigin="anonymous"></script>
  </body>
</html>

