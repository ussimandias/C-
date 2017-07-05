<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DevSheet3.aspx.cs" Inherits="ASPApplications.DevSheet3" MaintainScrollPositionOnPostback="true" %>

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
           .auto-style1 {
               width: 191px;
               height: 220px;
           }
    </style>

  </head>
  <body>
      <div class="container">
           <div class="jumbotron">
                <h3 class="display-5">Working with ASP.NET and Formatting Strings...</h3>
                <hr class="m-y-2" />
           </div>
          <div class="row">
              <div class="col-md-6">
                  <form id="form1" class="" runat="server"> 
                      <div class="form-control cell">
                           <div class="form-group">
                               <h5><small>Page_Load and Page.IsPostBack</small></h5>
                               <br />
                               <asp:TextBox ID="TextBox" runat="server"  class="form-control"></asp:TextBox>
                               <br />
                               <asp:Calendar ID="myCalendar" runat="server" BackColor="#FFFFCC" BorderColor="#FFCC66" BorderWidth="1px"
                                   DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="#663399" Height="200px" ShowGridLines="True" Width="220px">
                                   <DayHeaderStyle BackColor="#FFCC66" Font-Bold="True" Height="1px" />
                                   <NextPrevStyle Font-Size="9pt" ForeColor="#FFFFCC" />
                                   <OtherMonthDayStyle ForeColor="#CC9966" />
                                   <SelectedDayStyle BackColor="#CCCCFF" Font-Bold="True" />
                                   <SelectorStyle BackColor="#FFCC66" />
                                   <TitleStyle BackColor="#990000" Font-Bold="True" Font-Size="9pt" ForeColor="#FFFFCC" />
                                   <TodayDayStyle BackColor="#FFCC66" ForeColor="White" />
                               </asp:Calendar>
                               <br />
                               <asp:Button ID="okButton" runat="server" Text="ok" class="btn btn-primary" OnClick="okButton_Click" />
                               <br />
                               <br />
                               <asp:TextBox ID="resultTextBox" runat="server" Class="form-control"></asp:TextBox>

                           </div>
                      </div>
                      &nbsp;
                       <div class="form-control cell">
                           <div class="form-group">
                               <h3><small>Formatting strings</small></h3>
                               <h4><small style="color:brown">Loan Application Form</small></h4>
                               <asp:Label ID="Label1" runat="server" Text="Label" class="form-control-label">Name:</asp:Label>
                               <asp:TextBox ID="nameTextBox" runat="server"  class="form-control"></asp:TextBox>
                              
                               <br />
                              
                               <asp:Label ID="Label2" runat="server" Text="Label" class="form-control-label">Phone Number:</asp:Label>
                               <asp:TextBox ID="phnumberTextBox" runat="server"  class="form-control" TextMode="Phone"></asp:TextBox>
                               
                               <br />
                               
                               <asp:Label ID="Label3" runat="server" Text="Label" class="form-control-label">Social Security Number:</asp:Label>
                               <asp:TextBox ID="sssTextBox" runat="server"  class="form-control"></asp:TextBox>
                             
                               <br />
                             
                               <h5><small>Loan Origination Date</small></h5>
                               <asp:Calendar ID="loanCalendar" runat="server" BackColor="White" BorderColor="#3366CC" BorderWidth="1px" 
                                   DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="#003399" Height="200px" Width="220px">
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
                             
                               <asp:Label ID="Label4" runat="server" Text="Label" class="form-control-label">Salary</asp:Label>
                               <asp:TextBox ID="salaryTextBox" runat="server"  class="form-control" TextMode="Number"></asp:TextBox>
                               <br />
                               <asp:Button ID="submitButton" runat="server" Text="Submit" class="btn btn-success" OnClick="submitButton_Click" />
                               <br />
                               <br />
                               <asp:TextBox ID="loanResultTextBox" runat="server" class="form-control" TextMode="MultiLine"></asp:TextBox>
                               <br />
                           </div>
                      </div>
                       &nbsp;
                      <div class="form-control cell">
                           <div class="form-group">
                               
                               <img class="auto-style1" src="epicspies.jpg" /><br />

                               <br />

                               <h3><small class="text-muted text-warning">Spy New Assignment Form</small></h3>

                               <asp:Label ID="Label5" runat="server" Text="Label" class=" form-control-label">Spy Code Name:</asp:Label>
                               <asp:TextBox ID="codenameTextBox" runat="server"  class="form-control"></asp:TextBox>

                               <br />

                               <asp:Label ID="Label6" runat="server" Text="Label" class=" form-control-label">New Appointment Name</asp:Label>
                               <asp:TextBox ID="newnameTextBox" runat="server"  class="form-control"></asp:TextBox>

                               <br />

                               <p><small class="text-danger text-muted">End Date of Previous Assignment</small></p>
                               <asp:Calendar ID="spyCalendar" runat="server" BackColor="White" BorderColor="White" BorderWidth="1px" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="190px" NextPrevFormat="FullMonth" Width="350px">
                                   <DayHeaderStyle Font-Bold="True" Font-Size="8pt" />
                                   <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" VerticalAlign="Bottom" />
                                   <OtherMonthDayStyle ForeColor="#999999" />
                                   <SelectedDayStyle BackColor="#333399" ForeColor="White" />
                                   <TitleStyle BackColor="White" BorderColor="Black" BorderWidth="4px" Font-Bold="True" Font-Size="12pt" ForeColor="#333399" />
                                   <TodayDayStyle BackColor="#CCCCCC" />
                               </asp:Calendar>

                                <br />

                                <p><small class="text-danger text-muted">Start Date of New Assignment</small></p>
                               <asp:Calendar ID="spyCalendar2" runat="server" BackColor="White" BorderColor="White" BorderWidth="1px" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="190px" NextPrevFormat="FullMonth" Width="350px">
                                   <DayHeaderStyle Font-Bold="True" Font-Size="8pt" />
                                   <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" VerticalAlign="Bottom" />
                                   <OtherMonthDayStyle ForeColor="#999999" />
                                   <SelectedDayStyle BackColor="#333399" ForeColor="White" />
                                   <TitleStyle BackColor="White" BorderColor="Black" BorderWidth="4px" Font-Bold="True" Font-Size="12pt" ForeColor="#333399" />
                                   <TodayDayStyle BackColor="#CCCCCC" />
                               </asp:Calendar>

                                <br />

                                <p><small class="text-danger text-muted">Projected End Date of New Assignment</small></p>
                               <asp:Calendar ID="spyCalendar3" runat="server" BackColor="White" BorderColor="White" BorderWidth="1px" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="190px" NextPrevFormat="FullMonth" Width="350px">
                                   <DayHeaderStyle Font-Bold="True" Font-Size="8pt" />
                                   <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" VerticalAlign="Bottom" />
                                   <OtherMonthDayStyle ForeColor="#999999" />
                                   <SelectedDayStyle BackColor="#333399" ForeColor="White" />
                                   <TitleStyle BackColor="White" BorderColor="Black" BorderWidth="4px" Font-Bold="True" Font-Size="12pt" ForeColor="#333399" />
                                   <TodayDayStyle BackColor="#CCCCCC" />
                               </asp:Calendar>

                               <br />

                               <asp:Button ID="spyButton" runat="server" Text="Assign Spy" class="btn btn-success" OnClick="spyButton_Click" />
                               <br />
                               <br />
                               <asp:TextBox ID="spyresultTextBox" runat="server" class="form-control" TextMode="MultiLine"></asp:TextBox>

                           </div>
                          </div>

                       &nbsp;
                      
                  </form>

              </div>
          </div>

      </div> 

    <!-- jQuery first, then Bootstrap JS. -->
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/2.1.4/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0-alpha.2/js/bootstrap.min.js" integrity="sha384-vZ2WRJMwsjRMW/8U7i6PWi6AlO1L79snBrmgiDpgIWJ82z8eA5lenwvxbMV1PAh7" crossorigin="anonymous"></script>
  </body>
</html>
