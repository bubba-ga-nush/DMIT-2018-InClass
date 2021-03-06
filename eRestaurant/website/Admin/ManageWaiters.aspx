﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ManageWaiters.aspx.cs" Inherits="Admin_ManageWaiters" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <div class="row col-md-12">
        <h1>Manage Special Events
            <span class="glyphicon glyphicon-glass"></span>
        </h1>

          <asp:ObjectDataSource ID="WaitersDataSource" runat="server"
            TypeName="eRestaurant.Framework.BLL.RestaurantAdminController"
            SelectMethod="ListAllWaiters"
            DataObjectTypeName="eRestaurant.Framework.Entities.Waiter" OldValuesParameterFormatString="original_{0}"
            UpdateMethod="UpdateWaiter"
            DeleteMethod="DeleteWaiter"
            InsertMethod="AddWaiter" OnDeleted="ProcessExceptions" OnInserted="ProcessExceptions" OnUpdated="ProcessExceptions"></asp:ObjectDataSource>

          <asp:Label ID="MessageLabel" runat="server"></asp:Label>

        <asp:ListView ID="WaitersListView" runat="server"
        DataSourceID="WaitersDataSource"
        DataKeyNames="WaiterID"
        InsertItemPosition="LastItem">

        <LayoutTemplate>
            <fieldset runat="server" id="itemPlaceholderContainer">
                <div runat="server" id="itemPlaceholder"/>
            </fieldset>
        </LayoutTemplate>

        <ItemTemplate>
            <div>

            </div>
        </ItemTemplate>

       </asp:ListView>
</asp:Content>

