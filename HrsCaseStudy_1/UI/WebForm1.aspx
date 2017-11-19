<%@ Page Title="" Language="C#" MasterPageFile="~/UI/MasterPage.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="HrsCaseStudy_1.UI.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style2 {
            width: 367px;
        }
        .auto-style3 {
            width: 342px;
        }
        .auto-style4 {
            width: 367px;
            height: 30px;
        }
        .auto-style5 {
            width: 342px;
            height: 30px;
        }
        .auto-style6 {
            height: 30px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <asp:Panel ID="Panel1" runat="server" Height="580px">
        <table style="width:100%;">
            <tr>
                <td class="auto-style2">Last Name
                    <asp:TextBox ID="txt_lastName" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style3">First Name<asp:TextBox ID="txt_firstName" runat="server"></asp:TextBox>
                </td>
                <td>Middle Name<asp:TextBox ID="txt_middleName" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Birth Date<asp:Calendar ID="cal_birthDate" runat="server"></asp:Calendar>
                </td>
                <td class="auto-style3">Age<asp:TextBox ID="txt_age" runat="server"></asp:TextBox>
                </td>
                <td>Gender<asp:DropDownList ID="ddl_gender" runat="server" AutoPostBack="True">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Status<asp:DropDownList ID="ddl_status" runat="server" AutoPostBack="True">
                    </asp:DropDownList>
                </td>
                <td class="auto-style3">Citizenship<asp:TextBox ID="txt_citizenship" runat="server"></asp:TextBox>
                </td>
                <td>Religion<asp:TextBox ID="txt_religion" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">SSS No<asp:TextBox ID="txt_sssNo" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style5">TIN No<asp:TextBox ID="TextBox7" runat="server" OnTextChanged="TextBox7_TextChanged"></asp:TextBox>
                </td>
                <td class="auto-style6"></td>
            </tr>
            <tr>
                <td class="auto-style2">Street<asp:TextBox ID="txt_street1" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style3">Mobile NO<asp:TextBox ID="TextBox13" runat="server" OnTextChanged="TextBox13_TextChanged"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="txt_street2" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style3">Home NO<asp:TextBox ID="txt_homeNo" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">City<asp:TextBox ID="txt_city" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">State<asp:TextBox ID="txt_state" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">Country<asp:TextBox ID="txt_country" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style3">ZipCode<asp:TextBox ID="txt_zipCode" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">Email Address<asp:TextBox ID="txt_emailAddr" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style3">Enterprise ID<asp:TextBox ID="txt_enterpriseId" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">GMU<asp:TextBox ID="txt_gmu" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style3">Level<asp:DropDownList ID="ddl_level" runat="server" AutoPostBack="True">
                    </asp:DropDownList>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">Date Hired<asp:Calendar ID="cal_dateHired" runat="server"></asp:Calendar>
                </td>
                <td class="auto-style3">LMU<asp:TextBox ID="txt_lmu" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">Work Group<asp:TextBox ID="TextBox17" runat="server" OnTextChanged="TextBox17_TextChanged"></asp:TextBox>
                </td>
                <td class="auto-style3">Status<asp:TextBox ID="txt_status" runat="server"></asp:TextBox>
                </td>
                <td>Project Profile
                    <asp:TextBox ID="txt_proProfile" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Speciality<asp:DropDownList ID="ddl_speciality" runat="server" AutoPostBack="True">
                    </asp:DropDownList>
                </td>
                <td class="auto-style3">Service Line<asp:TextBox ID="txt_serviceLine" runat="server"></asp:TextBox>
                </td>
                <td>Skill Profile
                    <asp:TextBox ID="txt_skillProfile" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Educational Background<asp:TextBox ID="txt_eduBackground" runat="server" OnTextChanged="TextBox17_TextChanged" TextMode="MultiLine"></asp:TextBox>
                </td>
                <td class="auto-style3">&nbsp;</td>
                <td>Created by
                    <asp:TextBox ID="txt_createdBy" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Certificate/Awards<asp:TextBox ID="txt_certificate" runat="server" OnTextChanged="TextBox17_TextChanged" TextMode="MultiLine"></asp:TextBox>
                </td>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">
                    <asp:Button ID="btn_add" runat="server" OnClick="Button1_Click" Text="Add" />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" style="height: 26px" Text="Cancel" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </asp:Panel>
</asp:Content>
