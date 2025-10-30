<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="AppCapas.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link rel="stylesheet" href="estilos.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="page-center">
            <div>
                <div class="caption">
                    <strong>Ecuación</strong><br />
                    <i>y = (a) x^2 + b (x) + c</i><br />
                    Para resolver la ecuación es nesario introducir el valor de <i>x</i>.<br />
                    Los valores <i>a</i>, <i>b</i> & <i>c</i> serán obtenidos desde la base de datos.

			Agregando un cambio para git!!

                </div>

                <table>


                    <tbody>
                        <tr>
                            <td class="variables"><i >x</i> =</td>
                            <td>
                                <asp:TextBox ID="txt_x" TextMode="Number" runat="server"></asp:TextBox>

                            </td>

                        </tr>
                        <tr>
                            <td></td>
                            <td>
                                <asp:Button ID="btn_calcular" runat="server" Text="Calcular" OnClick="calcular_click" Style="height: 26px" />


                            </td>
                        </tr>
                        <tr>
                            <td class="variables"><i>y</i> =</td>
                            <td>
                                <asp:TextBox ID="txt_y" TextMode="Number" Enabled="false" runat="server"></asp:TextBox></td>
                        </tr>

                    </tbody>
                </table>
            </div>
        </div>
    </form>
</body>
</html>
