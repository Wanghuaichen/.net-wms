<%@ Page Language="c#" CodeBehind="FRMAClosedRateQP.aspx.cs" AutoEventWireup="True"
    Inherits="BenQGuru.eMES.Web.WebQuery.FRMAClosedRateQP" %>

<%@ Register TagPrefix="uc2" TagName="UpDown" Src="~/UserControl/NumericUpDown/UCNumericUpDown.ascx" %>
<%@ Register TagPrefix="uc1" TagName="eMESDate" Src="~/UserControl/DateTime/DateTime/eMESDate.ascx" %>
<%@ Register TagPrefix="cc2" Namespace="BenQGuru.eMES.Web.SelectQuery" Assembly="BenQGuru.eMES.Web.SelectQuery" %>
<%@ Register Src="UserControls/UCPie3DChartProcess.ascx" TagName="UCPie3DChartProcess"
    TagPrefix="uc3" %>
<%@ Register TagPrefix="cc1" Namespace="BenQGuru.eMES.Web.Helper" Assembly="BenQGuru.eMES.WebUI.Helper" %>
<%@ Register Assembly="Infragistics35.Web.v11.2, Version=11.2.20112.1019, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cb"
    Namespace="Infragistics.Web.UI.GridControls" TagPrefix="ig" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html>
<head>
    <title>FRMAClosedRateQP</title>
    <meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
    <meta content="C#" name="CODE_LANGUAGE">
    <meta content="JavaScript" name="vs_defaultClientScript">
    <meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
    <link href="<%=StyleSheet%>" rel="stylesheet">
</head>
<body scroll="yes" ms_positioning="GridLayout">
    <form id="Form1" method="post" runat="server">
    <table id="Table1" height="100%" width="100%" runat="server">
        <tr class="moduleTitle">
            <td>
                <asp:Label ID="lblTitle" runat="server" CssClass="labeltopic">RMA�᰸��</asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <table class="query" height="100%" width="100%">
                    <tr>
                        <td class="fieldNameLeft" nowrap>
                            <asp:Label ID="lblStartDateQuery" runat="server">��ʼ����</asp:Label>
                        </td>
                        <td class="fieldValue">                      
  <asp:TextBox  id="dateStartDateQuery"  class='datepicker' runat="server"  Width="110px"/>
                        </td>
                        <td class="fieldName" nowrap>
                            <asp:Label ID="lblEndDateQuery" runat="server">��������</asp:Label>
                        </td>
                        <td class="fieldValue">
 <asp:TextBox  id="dateEndDateQuery"  class='datepicker' runat="server"  Width="110px"/>
                        </td>
                        <td>
                        </td>
                        <td width="50%">
                        </td>
                        <td class="fieldName">
                            <input class="submitImgButton" id="cmdQuery" type="submit" value="�� ѯ" name="btnQuery"
                                runat="server">
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr height="100%">
            <td class="fieldGrid">
                <ig:WebDataGrid ID="gridWebGrid" runat="server" Width="100%">
                </ig:WebDataGrid>
            </td>
        </tr>
        <tr class="normal">
            <td>
                <table height="100%" cellpadding="0" width="100%">
                    <tr>
                        <td class="smallImgButton">
                            <input class="gridExportButton" id="cmdGridExport" type="submit" value="  " name="cmdGridExport"
                                runat="server">
                        </td>
                        <td style="display: none">
                            <cc1:pagersizeselector id="pagerSizeSelector" runat="server">
                            </cc1:pagersizeselector>
                        </td>
                        <td align="right" style="display: none">
                            <cc1:PagerToolbar id="pagerToolBar" runat="server">
                            </cc1:PagerToolbar>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td>
                <table>
                    <tr>
                        <td align="center" colspan="8">
                            <uc3:UCPie3DChartProcess id="pie3DChart" runat="server">
                            </uc3:UCPie3DChartProcess>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
    </form>
</body>
</html>