#pragma checksum "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Sinyaller/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "99f3ac7fceac7ba9b296b3847ee5c36878128715"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Sinyaller_Index), @"mvc.1.0.view", @"/Views/Sinyaller/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/_ViewImports.cshtml"
using com.mehmet.proje.MVCWebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/_ViewImports.cshtml"
using com.mehmet.proje.MVCWebUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/_ViewImports.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/_ViewImports.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Sinyaller/Index.cshtml"
using com.mehmet.oracle.entities.BaseClasses;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Sinyaller/Index.cshtml"
using X.PagedList.Mvc.Core.Common;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99f3ac7fceac7ba9b296b3847ee5c36878128715", @"/Views/Sinyaller/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"76bbc8dec0f5616cb7704077617a323a6bac9c77", @"/Views/_ViewImports.cshtml")]
    public class Views_Sinyaller_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<com.mehmet.oracle.entities.BaseClasses.Sinyaller>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 5 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Sinyaller/Index.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<meta http-equiv=""refresh"" content=""5""/>
 <script type = ""text/JavaScript"">
         <!--
            function AutoRefresh( t ) {
               setTimeout(""location.reload(true);"", 5000);
            }
         //-->
      </script>


    

<div class=""container-fluid text-center"" onload = ""AutoRefresh(1000);"">
    <h3 class=""bg-warning"" >Anlık Sinyal Akışı</h3>
    <div class=""table-responsive"">
        <table class=""table table-striped table-hover table-sm "">
            <thead class=""thead"">
            <td>Sid</td>
            <td>Abone No</td>
            <td>Sinyal Tarihi</td>
            <td>Sinyal Saati</td>
            <td>İşl.Saati</td>
            <td>İşl.Tarihi</td>
            <td>Sinyal Kodu</td>
            <td>Bölge No</td>
            <td>Zone</td>
            <td>Operatör</td>
            <td>Sinyal Açıklama</td>
            </thead>
            <tbody>
");
#nullable restore
#line 38 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Sinyaller/Index.cshtml"
             foreach(var sinyal in Model)
            {
                if (sinyal.SinyalKod== "E200" ||
                    sinyal.SinyalKod=="E211"||
                    sinyal.SinyalKod=="E222"||
                    sinyal.SinyalKod=="E233"||
                    sinyal.SinyalKod=="E255")
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr class=\"bg-danger\" >\n                        <td>");
#nullable restore
#line 47 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Sinyaller/Index.cshtml"
                       Write(sinyal.SinyalId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 48 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Sinyaller/Index.cshtml"
                       Write(sinyal.AboneNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 49 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Sinyaller/Index.cshtml"
                       Write(sinyal.SinyalTarih);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 50 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Sinyaller/Index.cshtml"
                       Write(sinyal.SinyalSaat);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>İşlenmedi</td>\n                        <td>işlenmedi</td>\n                        <td>");
#nullable restore
#line 53 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Sinyaller/Index.cshtml"
                       Write(sinyal.SinyalKod);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 54 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Sinyaller/Index.cshtml"
                       Write(sinyal.Bolum);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 55 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Sinyaller/Index.cshtml"
                       Write(sinyal.Zone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>yok</td>\n                        <td>");
#nullable restore
#line 57 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Sinyaller/Index.cshtml"
                       Write(sinyal.SinyalTAnim);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    </tr>  \n");
#nullable restore
#line 59 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Sinyaller/Index.cshtml"
                }
                if (sinyal.SinyalKod== "E400" ||
                    sinyal.SinyalKod=="E401")
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr class=\"bg-success\" >\n                        <td>");
#nullable restore
#line 64 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Sinyaller/Index.cshtml"
                       Write(sinyal.SinyalId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 65 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Sinyaller/Index.cshtml"
                       Write(sinyal.AboneNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 66 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Sinyaller/Index.cshtml"
                       Write(sinyal.SinyalTarih);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 67 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Sinyaller/Index.cshtml"
                       Write(sinyal.SinyalSaat);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>İşlenmedi</td>\n                        <td>işlenmedi</td>\n                        <td>");
#nullable restore
#line 70 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Sinyaller/Index.cshtml"
                       Write(sinyal.SinyalKod);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 71 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Sinyaller/Index.cshtml"
                       Write(sinyal.Bolum);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 72 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Sinyaller/Index.cshtml"
                       Write(sinyal.Zone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>yok</td>\n                        <td>");
#nullable restore
#line 74 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Sinyaller/Index.cshtml"
                       Write(sinyal.SinyalTAnim);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    </tr>  \n");
#nullable restore
#line 76 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Sinyaller/Index.cshtml"
                }
                if (sinyal.SinyalKod== "E402" )
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr class=\"bg-warning\" >\n                        <td>");
#nullable restore
#line 80 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Sinyaller/Index.cshtml"
                       Write(sinyal.SinyalId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 81 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Sinyaller/Index.cshtml"
                       Write(sinyal.AboneNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 82 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Sinyaller/Index.cshtml"
                       Write(sinyal.SinyalTarih);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 83 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Sinyaller/Index.cshtml"
                       Write(sinyal.SinyalSaat);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>İşlenmedi</td>\n                        <td>işlenmedi</td>\n                        <td>");
#nullable restore
#line 86 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Sinyaller/Index.cshtml"
                       Write(sinyal.SinyalKod);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 87 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Sinyaller/Index.cshtml"
                       Write(sinyal.Bolum);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 88 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Sinyaller/Index.cshtml"
                       Write(sinyal.Zone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>yok</td>\n                        <td>");
#nullable restore
#line 90 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Sinyaller/Index.cshtml"
                       Write(sinyal.SinyalTAnim);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    </tr>  \n");
#nullable restore
#line 92 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Sinyaller/Index.cshtml"
                }
                if (sinyal.SinyalKod== "E403" || sinyal.SinyalKod== "E405" )
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr class=\"bg-primary\" >\n                        <td>");
#nullable restore
#line 96 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Sinyaller/Index.cshtml"
                       Write(sinyal.SinyalId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 97 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Sinyaller/Index.cshtml"
                       Write(sinyal.AboneNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 98 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Sinyaller/Index.cshtml"
                       Write(sinyal.SinyalTarih);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 99 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Sinyaller/Index.cshtml"
                       Write(sinyal.SinyalSaat);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>İşlenmedi</td>\n                        <td>işlenmedi</td>\n                        <td>");
#nullable restore
#line 102 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Sinyaller/Index.cshtml"
                       Write(sinyal.SinyalKod);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 103 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Sinyaller/Index.cshtml"
                       Write(sinyal.Bolum);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 104 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Sinyaller/Index.cshtml"
                       Write(sinyal.Zone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>yok</td>\n                        <td>");
#nullable restore
#line 106 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Sinyaller/Index.cshtml"
                       Write(sinyal.SinyalTAnim);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    </tr>  \n");
#nullable restore
#line 108 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Sinyaller/Index.cshtml"
                }
                if (sinyal.SinyalKod== "E140" )
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr class=\"bg-secondary\" >\n                        <td>");
#nullable restore
#line 112 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Sinyaller/Index.cshtml"
                       Write(sinyal.SinyalId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 113 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Sinyaller/Index.cshtml"
                       Write(sinyal.AboneNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 114 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Sinyaller/Index.cshtml"
                       Write(sinyal.SinyalTarih);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 115 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Sinyaller/Index.cshtml"
                       Write(sinyal.SinyalSaat);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>İşlenmedi</td>\n                        <td>işlenmedi</td>\n                        <td>");
#nullable restore
#line 118 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Sinyaller/Index.cshtml"
                       Write(sinyal.SinyalKod);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 119 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Sinyaller/Index.cshtml"
                       Write(sinyal.Bolum);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 120 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Sinyaller/Index.cshtml"
                       Write(sinyal.Zone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>yok</td>\n                        <td>");
#nullable restore
#line 122 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Sinyaller/Index.cshtml"
                       Write(sinyal.SinyalTAnim);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    </tr>  \n");
#nullable restore
#line 124 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Sinyaller/Index.cshtml"
                }
                if (sinyal.SinyalKod== "E120" )
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr class=\"bg-info\" >\n                        <td>");
#nullable restore
#line 128 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Sinyaller/Index.cshtml"
                       Write(sinyal.SinyalId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 129 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Sinyaller/Index.cshtml"
                       Write(sinyal.AboneNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 130 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Sinyaller/Index.cshtml"
                       Write(sinyal.SinyalTarih);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 131 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Sinyaller/Index.cshtml"
                       Write(sinyal.SinyalSaat);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>İşlenmedi</td>\n                        <td>işlenmedi</td>\n                        <td>");
#nullable restore
#line 134 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Sinyaller/Index.cshtml"
                       Write(sinyal.SinyalKod);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 135 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Sinyaller/Index.cshtml"
                       Write(sinyal.Bolum);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 136 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Sinyaller/Index.cshtml"
                       Write(sinyal.Zone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>yok</td>\n                        <td>");
#nullable restore
#line 138 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Sinyaller/Index.cshtml"
                       Write(sinyal.SinyalTAnim);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    </tr>  \n");
#nullable restore
#line 140 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Sinyaller/Index.cshtml"
                }
                if (sinyal.SinyalKod== "E100" )
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr class=\"bg-dark\" >\n                        <td>");
#nullable restore
#line 144 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Sinyaller/Index.cshtml"
                       Write(sinyal.SinyalId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 145 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Sinyaller/Index.cshtml"
                       Write(sinyal.AboneNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 146 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Sinyaller/Index.cshtml"
                       Write(sinyal.SinyalTarih);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 147 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Sinyaller/Index.cshtml"
                       Write(sinyal.SinyalSaat);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>İşlenmedi</td>\n                        <td>işlenmedi</td>\n                        <td>");
#nullable restore
#line 150 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Sinyaller/Index.cshtml"
                       Write(sinyal.SinyalKod);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 151 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Sinyaller/Index.cshtml"
                       Write(sinyal.Bolum);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 152 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Sinyaller/Index.cshtml"
                       Write(sinyal.Zone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>yok</td>\n                        <td>");
#nullable restore
#line 154 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Sinyaller/Index.cshtml"
                       Write(sinyal.SinyalTAnim);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    </tr>  \n");
#nullable restore
#line 156 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Sinyaller/Index.cshtml"
                }
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\n        </table>    \n            \n    </div>\n    ");
#nullable restore
#line 162 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Sinyaller/Index.cshtml"
Write(Html.PagedListPager((IPagedList)Model, page => Url.Action("Index", new { page = page }),
                new PagedListRenderOptions
                {
                    DisplayItemSliceAndTotal = false,
                    ContainerDivClasses = new[] { "navigation" },
                    LiElementClasses = new[] { "page-item" },
                    PageClasses = new[] { "page-link" }
                }
                ));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</div>\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        // Workaround to fix style of text for showing items .. through ..
        // Problem related to Boostrap 4 according to issue in link below
        // https://github.com/dncuug/X.PagedList/issues/127
        $(document).ready(function () {
            $('ul.pagination> li.disabled > a').addClass('page-link');
            $('ul.pagination').addClass('justify-content-center');
            
        });
    </script>
");
            }
            );
            WriteLiteral("\n  ");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<com.mehmet.oracle.entities.BaseClasses.Sinyaller>> Html { get; private set; }
    }
}
#pragma warning restore 1591
