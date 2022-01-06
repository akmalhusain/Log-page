<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Log_page.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        h1{
           text-align:center
       }
        .div{
            margin:60px 400px;
            padding:20px;
            border:1px double;
        }
        .txt{
            
            width:300px;
            height:30px;

        }
        .btn {
             width: 100px;
             margin-top: 10px;
         }
    </style>
</head>
<body>
    <form id="form1" runat="server">
         <h1>Log in page </h1>
        <hr />
        <div class="div">UserName:<br />
            <asp:TextBox CssClass="txt" ID="txtuser" runat="server"/><br />
             password:<br />
            <asp:TextBox CssClass="txt" ID="txtpass" runat="server"/><br />
            <asp:Button CssClass="btn" ID="btn1" runat="server" Text="Insert" OnClick="btn1_Click" />
            <asp:Button CssClass="btn" ID="btn2" runat="server" Text="Update" OnClick="btn2_Click" />
            <asp:Button CssClass="btn" ID="btn3" runat="server" Text="Delete" OnClick="btn3_Click" />
            <asp:Button CssClass="btn" ID="btn4" runat="server" Text="Read" OnClick="btn4_Click" />
        </div>
    </form>
</body>
</html>
