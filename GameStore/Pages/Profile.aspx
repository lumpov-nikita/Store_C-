<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Store.Master" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="GameStore.Pages.Profile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="bodyContent" runat="server">
    <div id="content">

        <div id="checkoutForm" class="checkout" runat="server">
            <h2 id="Hi1" runat="server">Личный кабинет</h2>

            <h3>Данная информация будет автоматически подставляться при оформлении заказа</h3>
            <div>
                <label for="name">Имя:</label>
                <input Property="Name" runat="server" />
            </div>

            <h3>Адрес доставки</h3>
            <div>
                <label for="line1">Адрес 1:</label>
                <input Property="Line1" runat="server" />
            </div>
            <div>
                <label for="line2">Адрес 2:</label>
                <input Property="Line2" runat="server" />
            </div>
            <div>
                <label for="line3">Адрес 3:</label>
                <input Property="Line3" runat="server" />
            </div>
            <div>
                <label for="city">Город:</label>
                <input Property="City" runat="server" />
            </div>

            <div>
                <label for="city">Изменить стиль магазина:</label>
                <input Property="Style" runat="server" />
            </div>
            <div>
                <label for="groupe">Роль в проекте</label>
                <input Property="Groupe" runat="server" />
            </div>
        <p class="actionButtons">
            <button class="actionButtons" type="submit">Сохранить данные</button>
        </p>
        </div>
        <div id="nav">
        <a href="<%= OrdersUrl %>">Управление заказами</a>
        <a href="<%= GamesUrl %>">Управление каталогом игр</a>
    </div>
        <div id="checkoutMessage" runat="server">
            Спасибо что выбрали наш магазин! 
        </div>
    </div>
</asp:Content>
