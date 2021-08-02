<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WageCalculator._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <p class="lead">Enter the employee id </p>
        <p class="lead">&nbsp;</p>
        <p class="lead">
            <asp:TextBox ID="txtID" runat="server"></asp:TextBox>
        </p>
        <p>    <p class="lead">Enter the no of hours worked </p></p>
        <p class="lead">
            <asp:TextBox ID="txtHoursWorked" runat="server"></asp:TextBox>
        </p>

        <p>                <asp:Button ID="Button1" runat="server" Text="Calculate Wage" OnClick="Button1_Click" />
            </p>
    </div>

    <div class="row">
        <div class="col-md-4">
            <p>
                <asp:Label ID="lblWage" runat="server" Text="lblWage"></asp:Label>
            </p>
        </div>
        <div class="col-md-4">
            
        </div>
        <div class="col-md-4">
        </div>
    </div>

</asp:Content>
