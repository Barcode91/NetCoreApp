#pragma checksum "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Admin/Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eb47ec74399cfb2002c60960eab3d2d4cf5aa09b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Dashboard), @"mvc.1.0.view", @"/Views/Admin/Dashboard.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb47ec74399cfb2002c60960eab3d2d4cf5aa09b", @"/Views/Admin/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"76bbc8dec0f5616cb7704077617a323a6bac9c77", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n\n\n");
#nullable restore
#line 4 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Admin/Dashboard.cshtml"
  
    ViewBag.Title = "title";
    Layout = "_AdminLayout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
.menu li{
list-style: none;
}
.menu li a{
background: #532d27;
color: #ffffff;
font: 15px;
display: block;
padding: 20px 0px;
text-decoration: none;
text-align: center;
}
#bir{
border-left: 5px solid #28a745 ;
}
#bir:hover { background: #28a745 }

#iki{
border-left: 5px solid #d0213c ;
}
#iki:hover { background: #d0213c }

#uc{
border-left: 5px solid #1b5fea ;
}
#uc:hover { background: #1b5fea }

#dor{
border-left: 5px solid #72601d ;
}
#dor:hover { background: #72601d }

#bes{
border-left: 5px solid #ae39e0 ;
}
#bes:hover { background: #ae39e0 }

#bir,#iki,#uc,#dor,#bes{transition-duration: 0.3s;}

</style>
<div class=""container-fluied"">
    <div class=""container mb-5""></div>
    <div class=""row"">
        <div class=""col-md-2"">
            <div class=""menu"">
                <ul class=""nav flex-column"">
                    <li><a id=""bir"" href=""#bir-con"" data-toggle=""pill"" role=""tab"" aria-controls=""#bir-con"" aria-selected=""true"">Abone ist.</a></li>
                    <li><a id=""iki"" href=""#iki-con"" ");
            WriteLiteral(@"data-toggle=""pill"" role=""tab"" aria-controls=""#iki-con"" aria-selected=""false"">Sinyal Türü İst.</a></li>
                    <li><a id=""uc"" href=""#uc-con"" data-toggle=""pill"" role=""tab"" aria-controls=""#uc-con"" aria-selected=""false"">Operatör İst.</a></li>
                    <li><a id=""dor"" href=""#dor-con"" data-toggle=""pill"" role=""tab"" aria-controls=""#dor-con"" aria-selected=""false"">Haftalık İst.</a></li>
                    <li><a id=""bes"" href=""#bes-con"" data-toggle=""pill"" role=""tab"" aria-controls=""#bes-con"" aria-selected=""false"">Aylık İst.</a></li>
                </ul>
            </div>
        </div>
        <div class=""col-md-10 mt-4"">
            <div class=""tab-content"">
                <div class=""tab-pane active"" id=""bir-con"" role=""tabpanel"" aria-labelledby=""bir"">
                     <div class=""row mt-4"">
                                                        <div class=""container col-md-6"">
                                                            <h5 class=""text-center"">ABONELERİN İŞLEM GÖRMÜŞ Sİ");
            WriteLiteral(@"NYAL SAYILARI</h5>
                                                            <canvas id=""islenmisAbone"" width=""300"" height=""300""></canvas>
                                                        </div>
                                                        <div class=""container col-md-6"">
                                                            <h5 class=""text-center"">ABONELERİN BEKLEYEN SİNYAL SAYILARI</h5>
                                                            <canvas id=""islenmemisAbone"" width=""300"" height=""300""></canvas>
                                                        </div>
                                                    </div>
                </div>
                <div class=""tab-pane"" id=""iki-con"" role=""tabpanel"" aria-labelledby=""iki"">
                     <div class=""row mt-4"">
                                        <div class=""container col-md-6"">
                                            <h5 class=""text-center"">SİNYAL TÜRLERİNE GÖRE İŞLEM GÖRMÜŞ SİNYALLER</h5>
            ");
            WriteLiteral(@"        
                                            <canvas id=""islenmisSinyal"" width=""300"" height=""300""></canvas>
                    
                                        </div>
                                        <div class=""container col-md-6"">
                                            <h5 class=""text-center"">SİNYAL TÜRLERİNE GÖRE BEKLEYEN SİNYALLER</h5>
                                            <canvas id=""islenmemisSinyal"" width=""300"" height=""300""></canvas>
                    
                                        </div>
                    
                                    </div>
                </div>
                <div class=""tab-pane"" id=""uc-con"" role=""tabpanel"" aria-labelledby=""uc"">
                    <div class=""row mt-4 text-center"">
                        <div class=""container col-md-6"">
                            <h5 class=""text-center"">OPERATÖR SİNYAL İSTATİSTİKLERİ</h5>
                            <canvas id=""operatr"" width=""300"" height=""300""></canvas>
                 ");
            WriteLiteral(@"       </div>
                    </div>
                </div>
                <div class=""tab-pane"" id=""dor-con"" role=""tabpanel"" aria-labelledby=""dor"">
                    <div class=""row mt-4"">
                                    <div class=""container col-md-6"">
                                        <h5 class=""text-center"">SON BİR HAFTADA İŞLEM GÖREN SİNYALLER</h5>
                                        <canvas id=""sonHftislenmis"" width=""300"" height=""300""></canvas>
                                    </div>
                                    <div class=""container col-md-6"">
                                        <h5 class=""text-center"">SON BİR HAFTADA BEKLEYEN SİNYALLER</h5>
                                        <canvas id=""sonHftBekleyen"" width=""300"" height=""300""></canvas>
                                    </div>
                                </div>
                </div>
                <div class=""tab-pane"" id=""bes-con"" role=""tabpanel"" aria-labelledby=""bes"">
                     <div class=""r");
            WriteLiteral(@"ow mt-4"">
                                        <div class=""container col-md-6"">
                                            <h5 class=""text-center"">SON BİR AYDA İŞLEM GÖREN SİNYALLER</h5>
                                            <canvas id=""sonAyislenmis"" width=""300"" height=""300""></canvas>
                                        </div>
                                        <div class=""container col-md-6"">
                                            <h5 class=""text-center"">SON BİR AYDA BEKLEYEN SİNYALLER</h5>
                                            <canvas id=""sonAyBekleyen"" width=""300"" height=""300""></canvas>
                                        </div>
                                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<script>
var sinyalTur=");
#nullable restore
#line 131 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Admin/Dashboard.cshtml"
         Write(Html.Raw(Json.Serialize(@ViewBag.SINYALTUR)));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\nvar sinyalSay=");
#nullable restore
#line 132 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Admin/Dashboard.cshtml"
         Write(Html.Raw(Json.Serialize(@ViewBag.SINYALSAYI)));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\nvar issinyalTur=");
#nullable restore
#line 133 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Admin/Dashboard.cshtml"
           Write(Html.Raw(Json.Serialize(@ViewBag.ISSINYALTUR)));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\nvar issinyalSay=");
#nullable restore
#line 134 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Admin/Dashboard.cshtml"
           Write(Html.Raw(Json.Serialize(@ViewBag.ISSINYALSAYI)));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\n\nvar islenmisAboneSay=");
#nullable restore
#line 136 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Admin/Dashboard.cshtml"
                Write(Html.Raw(Json.Serialize(@ViewBag.ISLENMISABNSAY)));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\nvar islemisAboneNo=");
#nullable restore
#line 137 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Admin/Dashboard.cshtml"
              Write(Html.Raw(Json.Serialize(@ViewBag.ISLENMISABNO)));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\nvar islenmemisAboneSay=");
#nullable restore
#line 138 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Admin/Dashboard.cshtml"
                  Write(Html.Raw(Json.Serialize(@ViewBag.ISLENMEMISABNSAY)));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\nvar islenmemisAboneNo=");
#nullable restore
#line 139 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Admin/Dashboard.cshtml"
                 Write(Html.Raw(Json.Serialize(@ViewBag.ISLENMEMISABNO)));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\n\nvar islenmisTarihSay=");
#nullable restore
#line 141 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Admin/Dashboard.cshtml"
                Write(Html.Raw(Json.Serialize(@ViewBag.ISLENMISTRHSAY)));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\nvar islemisTarih=");
#nullable restore
#line 142 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Admin/Dashboard.cshtml"
            Write(Html.Raw(Json.Serialize(@ViewBag.ISLENMISTRH)));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\nvar islenmemisTarihSay=");
#nullable restore
#line 143 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Admin/Dashboard.cshtml"
                  Write(Html.Raw(Json.Serialize(@ViewBag.ISLENMEMISTRHSAY)));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\nvar islenmemisTarih=");
#nullable restore
#line 144 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Admin/Dashboard.cshtml"
               Write(Html.Raw(Json.Serialize(@ViewBag.ISLENMEMISTRH)));

#line default
#line hidden
#nullable disable
            WriteLiteral(@";

//son hafta istatistik
hftislenmisTarihSay=islenmisTarihSay.slice(1,8);
hftislemisTarih=islemisTarih.slice(1,8);
hftislenmemisTarihSay=islenmemisTarihSay.slice(1,8);
hftislenmemisTarih=islenmemisTarih.slice(1,8);


//son bir ay
ayislenmisTarihSay=islenmisTarihSay.slice(1,31);
ayislemisTarih=islemisTarih.slice(1,31);
ayislenmemisTarihSay=islenmemisTarihSay.slice(1,31);
ayislenmemisTarih=islenmemisTarih.slice(1,31);

//OPERATÖR SİNYAL İSTS.
var oprsay=");
#nullable restore
#line 160 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Admin/Dashboard.cshtml"
      Write(Html.Raw(Json.Serialize(@ViewBag.OPERATORSAY)));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\nvar oprid=");
#nullable restore
#line 161 "/home/memo/RiderProjects/com.mehmet/com.mehmet.proje.MVCWebUI/Views/Admin/Dashboard.cshtml"
     Write(Html.Raw(Json.Serialize(@ViewBag.OPERATORNO)));

#line default
#line hidden
#nullable disable
            WriteLiteral(@";


var ctx = document.getElementById('islenmisSinyal');
var islenmisSinyal = new Chart(ctx, {
    type: 'bar',
    data: {
        labels: sinyalTur,
        datasets: [{
            label: 'İŞLEM YAPILMIŞ SİNYALLER',
            data: sinyalSay,
            backgroundColor: [
                'rgba(255, 99, 132)',
                'rgba(54, 162, 235)',
                'rgba(255, 206, 86)',
                'rgba(75, 192, 192)',
                'rgba(153, 102, 255)',
                'rgba(255, 159, 64)'
            ],
            borderColor: [
                'rgba(255, 99, 132, 1)',
                'rgba(54, 162, 235, 1)',
                'rgba(255, 206, 86, 1)',
                'rgba(75, 192, 192, 1)',
                'rgba(153, 102, 255, 1)',
                'rgba(255, 159, 64, 1)'
            ],
            borderWidth: 2
        }]
    }
});
var ctx1 = document.getElementById('islenmemisSinyal');
var islenmemisSinyal = new Chart(ctx1, {
    type: 'bar',
    data: {
        labels: issinyalTur,
        dat");
            WriteLiteral(@"asets: [{
            label: 'BEKLEYEN SİNYALLER',
            data: issinyalSay,
            backgroundColor: [
                'rgba(255, 99, 132)',
                'rgba(54, 162, 235)',
                'rgba(255, 206, 86)',
                'rgba(75, 192, 192)',
                'rgba(153, 102, 255)',
                'rgba(255, 159, 64)'
            ],
            borderColor: [
                'rgba(255, 99, 132, 1)',
                'rgba(54, 162, 235, 1)',
                'rgba(255, 206, 86, 1)',
                'rgba(75, 192, 192, 1)',
                'rgba(153, 102, 255, 1)',
                'rgba(255, 159, 64, 1)'
            ],
            borderWidth: 2
        }]
    }
});
var ctx2 = document.getElementById('islenmisAbone');
var islenmisAbone = new Chart(ctx2, {
    type: 'pie',
    data: {
        labels: islemisAboneNo,
        datasets: [{
            label: 'ABONE NUMARALARINA GÖRE İŞLEM GÖRMÜŞ SİNYAL SAYILARI',
            data: islenmisAboneSay,
            backgroundColor: [
                '");
            WriteLiteral(@"rgba(255, 99, 132)',
                'rgba(54, 162, 235)',
                'rgba(255, 206, 86)',
                'rgba(75, 192, 192)',
                'rgba(153, 102, 255)',
                'rgba(255, 159, 64)'
            ],
            borderColor: [
                'rgba(255, 99, 132, 1)',
                'rgba(54, 162, 235, 1)',
                'rgba(255, 206, 86, 1)',
                'rgba(75, 192, 192, 1)',
                'rgba(153, 102, 255, 1)',
                'rgba(255, 159, 64, 1)'
            ],
            borderWidth: 2
        }]
    }   
});
var ctx3 = document.getElementById('islenmemisAbone');
var islenmemisAbone = new Chart(ctx3, {
    type: 'pie',
    data: {
        labels: islenmemisAboneNo,
        datasets: [{
            label: 'ABONE NUMARALARINA GÖRE İŞLEM BEKLEYEN SİNYAL SAYILARI',
            data: islenmemisAboneSay,
            backgroundColor: [
                'rgba(255, 99, 132)',
                'rgba(54, 162, 235)',
                'rgba(255, 206, 86)',
                'rg");
            WriteLiteral(@"ba(75, 192, 192)',
                'rgba(153, 102, 255)',
                'rgba(255, 159, 64)'
            ],
            borderColor: [
                'rgba(255, 99, 132, 1)',
                'rgba(54, 162, 235, 1)',
                'rgba(255, 206, 86, 1)',
                'rgba(75, 192, 192, 1)',
                'rgba(153, 102, 255, 1)',
                'rgba(255, 159, 64, 1)'
            ],
            borderWidth: 2
        }]
    }
});
var ctx4 = document.getElementById('sonHftislenmis');
var sonHftislenmis = new Chart(ctx4, {
    type: 'line',
    data: {
        labels: hftislemisTarih,
        datasets: [{
            label: 'HAFTALIK İŞLENENEN SİNYAL SAYISI',
            data: hftislenmisTarihSay,
            backgroundColor: [
                'rgba(33,89,234,0.9)',
                'rgba(54, 162, 235)',
                'rgba(255, 206, 86)',
                'rgba(75, 192, 192)',
                'rgba(153, 102, 255)',
                'rgba(255, 159, 64)'
            ],
            borderColor: [
     ");
            WriteLiteral(@"           'rgba(255, 99, 132, 1)',
                'rgba(54, 162, 235, 1)',
                'rgba(255, 206, 86, 1)',
                'rgba(75, 192, 192, 1)',
                'rgba(153, 102, 255, 1)',
                'rgba(255, 159, 64, 1)'
            ],
            borderWidth: 2
        }]
    }
});
var ctx5 = document.getElementById('sonHftBekleyen');
var sonHftBekleyen = new Chart(ctx5, {
    type: 'line',
    data: {
        labels: hftislenmemisTarih,
        datasets: [{
            label: 'HAFTALIK BEKLEYEN SİNYAL SAYISI',
            data: hftislenmemisTarihSay,
            backgroundColor: [
                'rgba(33,89,234,0.9)',
                'rgba(54, 162, 235)',
                'rgba(255, 206, 86)',
                'rgba(75, 192, 192)',
                'rgba(153, 102, 255)',
                'rgba(255, 159, 64)'
            ],
            borderColor: [
                'rgba(255, 99, 132, 1)',
                'rgba(54, 162, 235, 1)',
                'rgba(255, 206, 86, 1)',
                'rgb");
            WriteLiteral(@"a(75, 192, 192, 1)',
                'rgba(153, 102, 255, 1)',
                'rgba(255, 159, 64, 1)'
            ],
            borderWidth: 2
        }]
    }
});
var ctx6 = document.getElementById('sonAyislenmis');
var sonAyislenmis = new Chart(ctx6, {
    type: 'line',
    data: {
        labels: ayislemisTarih,
        datasets: [{
            label: 'SON BİR AY İŞLENEN SİNYAL SAYISI',
            data: ayislenmisTarihSay,
            backgroundColor: [
                'rgba(33,89,234,0.9)',
                'rgba(54, 162, 235)',
                'rgba(255, 206, 86)',
                'rgba(75, 192, 192)',
                'rgba(153, 102, 255)',
                'rgba(255, 159, 64)'
            ],
            borderColor: [
                'rgba(255, 99, 132, 1)',
                'rgba(54, 162, 235, 1)',
                'rgba(255, 206, 86, 1)',
                'rgba(75, 192, 192, 1)',
                'rgba(153, 102, 255, 1)',
                'rgba(255, 159, 64, 1)'
            ],
            borderWidth: 3,
");
            WriteLiteral(@"            fill:false
        }]
    }
});
var ctx7 = document.getElementById('sonAyBekleyen');
var sonAyBekleyen = new Chart(ctx7, {
    type: 'line',
    data: {
        labels: ayislenmemisTarih,
        datasets: [{
            label: 'SON BİR AY BEKLEYEN SİNYAL SAYISI',
            data: ayislenmemisTarihSay,
            backgroundColor: [
                'rgba(33,89,234,0.9)',
                'rgb(50,59,17)',
                'rgba(255, 206, 86)',
                'rgba(75, 192, 192)',
                'rgb(190,174,222)',
                'rgba(255, 159, 64)'
            ],
            borderColor: [
                'rgba(255, 99, 132, 1)',
                'rgba(54, 162, 235, 1)',
                'rgba(255, 206, 86, 1)',
                'rgba(75, 192, 192, 1)',
                'rgba(153, 102, 255, 1)',
                'rgba(255, 159, 64, 1)'
            ],
            borderWidth: 3,
            
        }]
    }
});
var ctx8 = document.getElementById('operatr');
var operatr = new Chart(ctx8, {
    type: '");
            WriteLiteral(@"bar',
    data: {
        labels: oprid,
        datasets: [{
            label: 'OPERATÖR İŞLEMLERİ',
            data: oprsay,
            backgroundColor: [
                'rgba(255, 99, 132)',
                'rgba(54, 162, 235)',
                'rgba(255, 206, 86)',
                'rgba(75, 192, 192)',
                'rgba(153, 102, 255)',
                'rgba(255, 159, 64)'
            ],
            borderColor: [
                'rgba(255, 99, 132, 1)',
                'rgba(54, 162, 235, 1)',
                'rgba(255, 206, 86, 1)',
                'rgba(75, 192, 192, 1)',
                'rgba(153, 102, 255, 1)',
                'rgba(255, 159, 64, 1)'
            ],
            borderWidth: 2,
            fill:false
            
        }]
    }
});
</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
