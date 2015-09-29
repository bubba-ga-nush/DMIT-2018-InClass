﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ManageSpecialEvents.aspx.cs" Inherits="Admin_ManageSpecialEvents" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <div class="row col-md-12">
        <h1>Manage Special Events
            <span class="glyphicon glyphicon-glass"></span>
        </h1>
    

    <!-- ObjectDataSource control to do the underlying communication with my
        BLL and my ListView control -->
    <asp:ObjectDataSource ID="SpecialEventsDataSource" runat="server"
        TypeName="eRestaurant.Framework.BLL.RestaurantAdminController"
        SelectMethod="ListAllSpecialEvents"
        DataObjectTypeName="eRestaurant.Framework.Entities.SpecialEvent"></asp:ObjectDataSource>

    <%--<asp:GridView ID="SpecialEventsGridView" runat="server"
        DataSourceID="SpecialEventsDataSource"></asp:GridView>--%>
    <asp:ListView ID="SpecialEventsListView" runat="server"
        DataSourceID="SpecialEventsDataSource">
        <LayoutTemplate>
            <fieldset runat="server" id="itemPlaceholderContainer">
                <div runat="server" id="itemPlaceholder"/>
            </fieldset>
        </LayoutTemplate>

        <ItemTemplate>
            <div>
                <asp:CheckBox Checked='<%# Eval("Active") %>'
                    runat="server" ID="ActiveCheckBox"
                    Enabled="false" Text="Active" />
                &mdash;
                <asp:Label ID="EventCodeData" runat="server"
                    Text='<%# Eval("EventCode") %>' />
                &mdash;
                <asp:Label ID="DescriptionData" runat="server"
                    Text='<%# Eval("Description") %>' />
            </div>
        </ItemTemplate>
    </asp:ListView>
        </div>
</asp:Content>
