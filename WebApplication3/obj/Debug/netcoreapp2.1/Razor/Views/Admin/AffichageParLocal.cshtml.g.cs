#pragma checksum "C:\Users\dell\Desktop\Nouveau dossier (6)\WebApplication3\WebApplication3\Views\Admin\AffichageParLocal.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b9e234abc0bcab2745a6cb4510d40cc49c4db269"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_AffichageParLocal), @"mvc.1.0.view", @"/Views/Admin/AffichageParLocal.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/AffichageParLocal.cshtml", typeof(AspNetCore.Views_Admin_AffichageParLocal))]
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
#line 1 "C:\Users\dell\Desktop\Nouveau dossier (6)\WebApplication3\WebApplication3\Views\_ViewImports.cshtml"
using miniPrpject_Asp;

#line default
#line hidden
#line 2 "C:\Users\dell\Desktop\Nouveau dossier (6)\WebApplication3\WebApplication3\Views\_ViewImports.cshtml"
using miniPrpject_Asp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9e234abc0bcab2745a6cb4510d40cc49c4db269", @"/Views/Admin/AffichageParLocal.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7526617cd1245d2f900c0656a732b5055e04ccc", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_AffichageParLocal : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<miniPrpject_Asp.Models.DetailEmploi>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\dell\Desktop\Nouveau dossier (6)\WebApplication3\WebApplication3\Views\Admin\AffichageParLocal.cshtml"
  
    ViewData["Title"] = "AffichageParClasse";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(160, 554, true);
            WriteLiteral(@"

<div class=""row"">
    <div class=""col-md-12"">

        <div class=""card"">
            <table class=""table table-striped table-striped-bg-default mt-4"">
                <thead>
                    <tr>
                        <th>

                        </th>
                        <th>8-10</th>
                        <th>10-12</th>
                        <th>12-14</th>
                        <th>14-16</th>
                        <th>16-18</th>

                    </tr>
                </thead>
                <tbody>
");
            EndContext();
#line 28 "C:\Users\dell\Desktop\Nouveau dossier (6)\WebApplication3\WebApplication3\Views\Admin\AffichageParLocal.cshtml"
                       string[] tab = new string[] { "lundi", "mardi", "mercredi", "jeudi", "vendredi", "samedi" };
                        for (int i = 0; i < tab.Length; i++)
                        {

#line default
#line hidden
            BeginContext(920, 62, true);
            WriteLiteral("                        <tr>\r\n                            <th>");
            EndContext();
            BeginContext(983, 6, false);
#line 32 "C:\Users\dell\Desktop\Nouveau dossier (6)\WebApplication3\WebApplication3\Views\Admin\AffichageParLocal.cshtml"
                           Write(tab[i]);

#line default
#line hidden
            EndContext();
            BeginContext(989, 7, true);
            WriteLiteral("</th>\r\n");
            EndContext();
#line 33 "C:\Users\dell\Desktop\Nouveau dossier (6)\WebApplication3\WebApplication3\Views\Admin\AffichageParLocal.cshtml"
                              int k = i * 5;
                                    for (int j = k; j < k + 5; j++)
                                    {

#line default
#line hidden
            BeginContext(1150, 62, true);
            WriteLiteral("                                                        <td>\r\n");
            EndContext();
#line 37 "C:\Users\dell\Desktop\Nouveau dossier (6)\WebApplication3\WebApplication3\Views\Admin\AffichageParLocal.cshtml"
                                                               int cont = 1;
                                                                foreach (var line in Model)
                                                                {
                                                                    if (@line.SeanceID == j + 1)
                                                                    {
                                                                        cont = 2;

                                                                        foreach (var cour in ViewBag.cours)
                                                                        {
                                                                            if (cour.Id == @line.CoursID)
                                                                            {
                                                                                

#line default
#line hidden
            BeginContext(2155, 8, false);
#line 48 "C:\Users\dell\Desktop\Nouveau dossier (6)\WebApplication3\WebApplication3\Views\Admin\AffichageParLocal.cshtml"
                                                                           Write(cour.Nom);

#line default
#line hidden
            EndContext();
            BeginContext(2165, 88, true);
            WriteLiteral("                                                                                <br />\r\n");
            EndContext();
#line 50 "C:\Users\dell\Desktop\Nouveau dossier (6)\WebApplication3\WebApplication3\Views\Admin\AffichageParLocal.cshtml"
                                                                                foreach (var prof in ViewBag.prof)
                                                                                {
                                                                                    if (prof.Id == @cour.ProfesseurID)
                                                                                    {
                                                                                        

#line default
#line hidden
            BeginContext(2748, 13, false);
#line 54 "C:\Users\dell\Desktop\Nouveau dossier (6)\WebApplication3\WebApplication3\Views\Admin\AffichageParLocal.cshtml"
                                                                                   Write(prof.UserName);

#line default
#line hidden
            EndContext();
#line 54 "C:\Users\dell\Desktop\Nouveau dossier (6)\WebApplication3\WebApplication3\Views\Admin\AffichageParLocal.cshtml"
                                                                                                      

                                                                                    }
                                                                                }

#line default
#line hidden
            BeginContext(2935, 88, true);
            WriteLiteral("                                                                                <br />\r\n");
            EndContext();
#line 59 "C:\Users\dell\Desktop\Nouveau dossier (6)\WebApplication3\WebApplication3\Views\Admin\AffichageParLocal.cshtml"
                                                                                foreach (var niveau in ViewBag.niveau)
                                                                                {
                                                                                    if (niveau.Id == @cour.ClasseID)
                                                                                    {
                                                                                        

#line default
#line hidden
            BeginContext(3520, 11, false);
#line 63 "C:\Users\dell\Desktop\Nouveau dossier (6)\WebApplication3\WebApplication3\Views\Admin\AffichageParLocal.cshtml"
                                                                                   Write(niveau.code);

#line default
#line hidden
            EndContext();
#line 63 "C:\Users\dell\Desktop\Nouveau dossier (6)\WebApplication3\WebApplication3\Views\Admin\AffichageParLocal.cshtml"
                                                                                                    ;
                                                                                    }
                                                                                }

                                                                            }
                                                                        }







                                                                    }
                                                                }
                                                                if (@cont == 1)
                                                                {

                                                                } 

#line default
#line hidden
            BeginContext(4231, 63, true);
            WriteLiteral("                                                        </td>\r\n");
            EndContext();
#line 83 "C:\Users\dell\Desktop\Nouveau dossier (6)\WebApplication3\WebApplication3\Views\Admin\AffichageParLocal.cshtml"
                                    } 

#line default
#line hidden
            BeginContext(4335, 33, true);
            WriteLiteral("\r\n                        </tr>\r\n");
            EndContext();
#line 86 "C:\Users\dell\Desktop\Nouveau dossier (6)\WebApplication3\WebApplication3\Views\Admin\AffichageParLocal.cshtml"
                        } 

#line default
#line hidden
            BeginContext(4397, 88, true);
            WriteLiteral("\r\n\r\n\r\n                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n</div>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<miniPrpject_Asp.Models.DetailEmploi>> Html { get; private set; }
    }
}
#pragma warning restore 1591