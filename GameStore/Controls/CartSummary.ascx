<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CartSummary.ascx.cs" 
   Inherits="GameStore.Controls.CartSummary" %>


<div id="cartSummary">
    <span class="caption">
        <b>В корзине:</b>
        <span id="csQuantity" runat="server"></span> товаров,
        <span id="csTotal" runat="server"></span>
    </span>
    <a id="csLink" runat="server">Корзина</a>
</div>
<div id="in">
    <span class="caption">
        <a id="csLink_in1" runat="server">Войти</a>
    </span>
    <span class="caption">
        <a id="csLink_out1" runat="server">Выйти</a>
    </span>
    <span class="caption">
        <a id="csLink_pro1" runat="server">Личный кабинет</a>
    </span>
</div>