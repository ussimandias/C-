<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DataTypesVariablesAndOperators.aspx.cs" Inherits="ASPApplications.DevSheet2" %>

<!DOCTYPE html>
<html lang="en">
  <head>
    <!-- Required meta tags always come first -->
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <meta http-equiv="x-ua-compatible" content="ie=edge">

    <!-- Bootstrap CSS -->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0-alpha.2/css/bootstrap.min.css" integrity="sha384-y3tfxAZXuh4HwSYylfB+J125MxIs6mR5FOHamPBG064zB+AFeWH94NdvaCBm8qnd" crossorigin="anonymous">
      <style>
        .cell {
            background-color: #efefff;
            border: 2px solid #9d9df7;
            padding-top: 20px;
            padding-bottom: 20px;
        }
    </style>
  </head>

  <body>
      <div class="container">
          <div class="jumbotron">
                <h2 class="display-6">Branching Logic, Comparison and Logical Operators...</h2>
               <h3 class="display-6">DateTime TimeSpan and Calender Server Control...</h3>
                <hr class="m-y-2" />
           </div>
          <form id="form1" class="" runat="server">
              <div class="row">
                  <div class="col-md-12 form-control">
                      <div class="col-xs-6 cell" >
                          <div  class="form-group">
                              
                              <asp:Label ID="Label1" runat="server" Text="Is" class="form-control-label"></asp:Label>
                              &nbsp;<asp:TextBox ID="firstTextBox" runat="server" class="form-control"></asp:TextBox>
                             
                              <asp:Label ID="comparisionTypeLabel" runat="server" Text="comparisionTypeLabel" class="form-control-label"></asp:Label>
                              &nbsp;<asp:TextBox ID="secondTextBox" runat="server" class="form-control"></asp:TextBox>
                              <br />
                              <br />
                              <asp:CheckBox ID="CheckBox1" runat="server" Text=" I am Checked" />
                              <br />
                              <br />
                              <asp:Button ID="Button1" runat="server" class="btn btn-success" Text="Ok" OnClick="Button1_Click" />
                              <br />
                              <br />
                              <asp:Label ID="resultLabel" runat="server" Text="resultLabel" class="form-control-label"></asp:Label>
                              <hr />
                           </div>
                       
                          <p> &nbsp;</p>

                           <div  class="form-group ">
                               <h4>Date Time, TimeSpan and Calendar Server Control</h4>
                               <p><small class="text-muted">Working with  Date and Times</small> </p>
                               <p>
                                   <asp:Button ID="datetimeButton" runat="server" class="btn btn-warning" Text="Ok" OnClick="datetimeButton_Click" />
                               </p>
                               <p>
                                   <asp:TextBox ID="datetimeTextBox" runat="server" class="form-control" ></asp:TextBox>
                               </p>
                               
                          </div>

                           <hr />
                          <p> &nbsp;</p>
                           <div  class="form-group ">
                               <h4>Date Time, TimeSpan and Calendar Server Control</h4>
                               <p><small class="text-muted">Working with Span of Time</small> </p>
                               <p>
                                   <asp:Button ID="timespanButton" runat="server" class="btn btn-primary" Text="Ok" OnClick="spantimeButton_Click" />
                               </p>
                               <p>
                                   <asp:TextBox ID="timespanTextBox" runat="server" class="form-control" ></asp:TextBox>
                               </p>
                               
                          </div>

                           <hr />
                          <p> &nbsp;</p>
                          <div  class="form-group ">
                               <h4>Date Time, TimeSpan and Calendar Server Control</h4>
                               <p><small class="text-muted">Working with calender server control</small> </p>
                               <p>
                                   <asp:Calendar ID="myCalendar" runat="server" EnableTheming="True" BackColor="White" BorderColor="White" BorderWidth="1px" 
                                       FirstDayOfWeek="Sunday" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="190px" NextPrevFormat="FullMonth" 
                                       OnSelectionChanged="myCalendar_SelectionChanged" Width="350px" >
                                       <DayHeaderStyle Font-Bold="True" Font-Size="8pt" />
                                       <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" VerticalAlign="Bottom" />
                                       <OtherMonthDayStyle ForeColor="#999999" />
                                       <SelectedDayStyle BackColor="#333399" ForeColor="White" />
                                       <TitleStyle BackColor="White" BorderColor="Black" BorderWidth="4px" Font-Bold="True" Font-Size="12pt" ForeColor="#333399" />
                                       <TodayDayStyle BackColor="#CCCCCC" />
                                   </asp:Calendar>
                               </p>
                               <div class="form-group">
                                   <asp:Button ID="getdateButton" runat="server" Text="Get Date" class="btn btn-success" OnClick="getdateButton_Click" />
                                   <asp:Button ID="setdateButton" runat="server" Text="Set Date" class="btn btn-success" OnClick="setdateButton_Click" />
                                   <asp:Button ID="showdateButton" runat="server" Text="Show Date" class="btn btn-success" OnClick="showdateButton_Click" />
                                   <asp:Button ID="selectweekButton" runat="server" Text="Select Week " class="btn btn-success" OnClick="selectweekButton_Click" />
                               </div>
                               <p>
                                   <asp:TextBox ID="calendarTextBox" runat="server" class="form-control"></asp:TextBox>
                               </p>
                              
                               
                          </div>


                      </div>
                       <div class="col-xs-6 cell form-group " style="">
                           <div  class="form-group">

                               <asp:Image ID="pizzaImage" runat="server" Height="200px" Width="200px" />
                               <br />
                               <br />
                               <asp:RadioButton ID="smRadioButton" runat="server" GroupName="GroupSize" />

                               S - Size(10&quot;) - $10<br />
                               <br />
                               <asp:RadioButton ID="mdRadioButton2" runat="server" GroupName="GroupSize" />
                                M - Size(12&quot;) - $12
                               <br />
                               <br />
                               <asp:RadioButton ID="lgRadioButton3" runat="server" GroupName="GroupSize" />
                                L - Size(14&quot;) - $14
                               <br />
                               <br />
                               <br />
                               <asp:RadioButton ID="RadioButton4" runat="server" GroupName="GroupStyle" />
                               Thin Crust<br />
                               <br />
                               <asp:RadioButton ID="dpdishRadioButton" runat="server" GroupName="GroupStyle" />
                               Deep Dish (+$2)<br />
                               <br />
                               <br />
                               <asp:CheckBox ID="pepperoniCheckBox" runat="server" />
                               Pepperoni (+$1.50)<br />
                               <br />
                               <asp:CheckBox ID="onionCheckBox" runat="server" />
                               Onions (+$0.50)<br />
                               <br />
                               <asp:CheckBox ID="gpeppersCheckBox" runat="server" />
                               Green Peppers (+$0.75)<br />
                               <br />
                               <asp:CheckBox ID="redpeppersCheckBox" runat="server" />
                               Red Peppers (+$0.75)<br />
                               <br />
                               <asp:CheckBox ID="anchoviesCheckBox" runat="server" />
                               Anchovies (+$2)<br />
                               <br />
                               <asp:Label ID="Label2" runat="server" Text="" ForeColor="Black" ><p style="font-size:large; color:black">Papa Bob's  <span style="color:red"> Special Deal</span> </p></asp:Label>
                               
                               <asp:Label ID="Label3" runat="server"><small class="text-muted">Save $2:00 when you add Pepperoni, Green Peppers and Anchovies OR Pepperoni, Red Peppers and Onions to your pizza</small></asp:Label>
                               <br />
                               <br />
                               <asp:Button ID="purchaseButton" runat="server" Text="Purchase"  class="btn btn-info" OnClick="purchaseButton_Click" />
                               <br />
                               <br />
                               <asp:Label ID="totalLabel" runat="server" Text="Total: "></asp:Label>

                          </div>
                           <hr />
                           <div class="form-group">
                               <h3><small>How many days have elaspsed?</small></h3>

                               <h5><small>Choose one date: </small></h5>
                               <asp:Calendar ID="challengeCalendar" runat="server" BackColor="#FFFFCC" BorderColor="#FFCC66" BorderWidth="1px" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="#663399" Height="200px" ShowGridLines="True" Width="220px">
                                   <DayHeaderStyle BackColor="#FFCC66" Font-Bold="True" Height="1px" />
                                   <NextPrevStyle Font-Size="9pt" ForeColor="#FFFFCC" />
                                   <OtherMonthDayStyle ForeColor="#CC9966" />
                                   <SelectedDayStyle BackColor="#CCCCFF" Font-Bold="True" />
                                   <SelectorStyle BackColor="#FFCC66" />
                                   <TitleStyle BackColor="#990000" Font-Bold="True" Font-Size="9pt" ForeColor="#FFFFCC" />
                                   <TodayDayStyle BackColor="#FFCC66" ForeColor="White" />
                               </asp:Calendar>
                               &nbsp;
                               <h5><small>Choose a second date:</small></h5>
                               <asp:Calendar ID="challengeCalendar2" runat="server" BackColor="White" BorderColor="#3366CC" BorderWidth="1px" CellPadding="1" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="#003399" Height="200px" Width="220px">
                                   <DayHeaderStyle BackColor="#99CCCC" ForeColor="#336666" Height="1px" />
                                   <NextPrevStyle Font-Size="8pt" ForeColor="#CCCCFF" />
                                   <OtherMonthDayStyle ForeColor="#999999" />
                                   <SelectedDayStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                                   <SelectorStyle BackColor="#99CCCC" ForeColor="#336666" />
                                   <TitleStyle BackColor="#003399" BorderColor="#3366CC" BorderWidth="1px" Font-Bold="True" Font-Size="10pt" ForeColor="#CCCCFF" Height="25px" />
                                   <TodayDayStyle BackColor="#99CCCC" ForeColor="White" />
                                   <WeekendDayStyle BackColor="#CCCCFF" />
                               </asp:Calendar>
                                <br />
                                &nbsp;
                               <asp:Button ID="challengeButton" runat="server" Text="Ok"  CssClass="btn btn-success" OnClick="challengeButton_Click"/>
                                &nbsp;<br />
                                &nbsp;<asp:TextBox ID="challengeTextBox" runat="server" class="form-control"></asp:TextBox>
                           </div>

                       </div>   

                  </div>

              </div>

          </form>

      </div>
      
    <!-- jQuery first, then Bootstrap JS. -->
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/2.1.4/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0-alpha.2/js/bootstrap.min.js" integrity="sha384-vZ2WRJMwsjRMW/8U7i6PWi6AlO1L79snBrmgiDpgIWJ82z8eA5lenwvxbMV1PAh7" crossorigin="anonymous"></script>
  </body>
</html>

