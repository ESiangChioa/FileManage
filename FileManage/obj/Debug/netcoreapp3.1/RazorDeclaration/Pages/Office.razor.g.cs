// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 2 "C:\Users\esian\source\repos\FileManage\FileManage\Pages\Office.razor"
using FileManage.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/office")]
    public partial class Office : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 35 "C:\Users\esian\source\repos\FileManage\FileManage\Pages\Office.razor"
      

    private FileInfoData[] FileInfoDatas;

    protected override async Task OnInitializedAsync()
    {
        FileInfoDatas = await FileService.GetForecastAsync("Office");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private FileInfoService FileService { get; set; }
    }
}
#pragma warning restore 1591
