#pragma checksum "C:\Users\esian\source\repos\FileManage\FileManage\Pages\SystemSoft.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c7c32a1a2a598e0bb9aa3cdfe896f34cad189d4c"
// <auto-generated/>
#pragma warning disable 1591
namespace FileManage.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\esian\source\repos\FileManage\FileManage\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\esian\source\repos\FileManage\FileManage\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\esian\source\repos\FileManage\FileManage\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\esian\source\repos\FileManage\FileManage\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\esian\source\repos\FileManage\FileManage\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\esian\source\repos\FileManage\FileManage\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\esian\source\repos\FileManage\FileManage\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\esian\source\repos\FileManage\FileManage\_Imports.razor"
using FileManage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\esian\source\repos\FileManage\FileManage\_Imports.razor"
using FileManage.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\esian\source\repos\FileManage\FileManage\Pages\SystemSoft.razor"
using FileManage.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/system")]
    public partial class SystemSoft : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>系统类列表</h1>");
#nullable restore
#line 7 "C:\Users\esian\source\repos\FileManage\FileManage\Pages\SystemSoft.razor"
 if (FileInfoDatas == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<p><em>Loading...</em></p>");
#nullable restore
#line 10 "C:\Users\esian\source\repos\FileManage\FileManage\Pages\SystemSoft.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "table");
            __builder.AddAttribute(3, "class", "table");
            __builder.AddMarkupContent(4, "<thead><tr><th>名称</th>\r\n            <th>发布时间</th>\r\n            <th>操作</th></tr></thead>\r\n        ");
            __builder.OpenElement(5, "tbody");
#nullable restore
#line 22 "C:\Users\esian\source\repos\FileManage\FileManage\Pages\SystemSoft.razor"
         foreach (var file in FileInfoDatas)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(6, "tr");
            __builder.OpenElement(7, "td");
            __builder.AddContent(8, 
#nullable restore
#line 25 "C:\Users\esian\source\repos\FileManage\FileManage\Pages\SystemSoft.razor"
                     file.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n                ");
            __builder.OpenElement(10, "td");
            __builder.AddContent(11, 
#nullable restore
#line 26 "C:\Users\esian\source\repos\FileManage\FileManage\Pages\SystemSoft.razor"
                     file.Date.ToShortDateString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n                ");
            __builder.OpenElement(13, "td");
            __builder.OpenElement(14, "a");
            __builder.AddAttribute(15, "href", 
#nullable restore
#line 27 "C:\Users\esian\source\repos\FileManage\FileManage\Pages\SystemSoft.razor"
                              file.FilePath

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(16, "download", 
#nullable restore
#line 27 "C:\Users\esian\source\repos\FileManage\FileManage\Pages\SystemSoft.razor"
                                                        file.Name

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(17, "下载");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 29 "C:\Users\esian\source\repos\FileManage\FileManage\Pages\SystemSoft.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 32 "C:\Users\esian\source\repos\FileManage\FileManage\Pages\SystemSoft.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 35 "C:\Users\esian\source\repos\FileManage\FileManage\Pages\SystemSoft.razor"
      

    private FileInfoData[] FileInfoDatas;

    protected override async Task OnInitializedAsync()
    {
        FileInfoDatas = await FileService.GetForecastAsync("System");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private FileInfoService FileService { get; set; }
    }
}
#pragma warning restore 1591
