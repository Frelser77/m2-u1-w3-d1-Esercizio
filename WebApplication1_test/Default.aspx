<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1_test._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <div class="row"> 
            <section class="col-md-8" aria-labelledby="gettingStartedTitle">
                <h2 id="gettingStartedTitle">ES:1</h2>
               
                   
                    
                    <br />
                    <asp:Label ID="Label1" runat="server" Text="Clicca per visualizzare il nome e cognome"></asp:Label>
                    <p runat="server" id="test"></p>
                    <asp:Button ID="Button1" runat="server" Text="Click me" OnClick="Button1_Click" class="btn-outline-secondary"/>

            </section>
           
        </div>
    </main>

</asp:Content>
