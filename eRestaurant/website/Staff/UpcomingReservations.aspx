<%@ Page Title="Upcoming Reservations" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="UpcomingReservations.aspx.cs" Inherits="Staff_UpcomingReservations" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
   <div class="row">
         <div class="col-md-12">
            <h1>Upcoming Reservations</h1>
             <asp:ObjectDataSource ID="ActiveEventsDataSource" runat="server" OldValuesParameterFormatString="original_{0}" 
                 SelectMethod="ListActiveEvents" 
                 TypeName="eRestaurant.Framework.BLL.ReservationsController">
             </asp:ObjectDataSource>
             <asp:Label ID="EventDropDownLabel" runat="server" Text="Events" AssociatedControlID="EventsRadioButton"></asp:Label>
             <asp:RadioButtonList ID="ActiveEventsRadioButtonList" runat="server" DataSourceID="ActiveEventsDataSource"
                  DataTextField="Description" DataValueField="Code" AppendDataBoundItems="true" RepeatDirection="Horizontal" RepeatLayout="Flow">
                 <asp:ListItem Value="All" Selected="True">All Events</asp:ListItem>
                 <asp:ListItem Value="None">No Event</asp:ListItem>
             </asp:RadioButtonList>

             <!-- Show the upcoming reservations here -->
             <asp:Repeater ID="ReservationsRepeater" runat="server"
                 DataSourceID="DailyReservationsDataSource"
                 ItemType="eRestaurant.Framework.Entities.DTOs.DailyReservation">
                 <ItemTemplate>
                     Month: <%# Item.Month %>
                     Day: <%# Item.Day %>
                 </ItemTemplate>
             </asp:Repeater>
             <asp:ObjectDataSource ID="DailyReservationsDataSource" runat="server" 
                 OldValuesParameterFormatString="original_{0}" SelectMethod="ListUpcomingReservations" 
                 TypeName="eRestaurant.Framework.BLL.ReservationsController">
                 <SelectParameters>
                     <asp:ControlParameter ControlID="ActiveEventsRadioButtonList" PropertyName="SelectedValue" Name="eventCode" Type="String"></asp:ControlParameter>
                 </SelectParameters>
             </asp:ObjectDataSource>
        </div>
   </div>
</asp:Content>

