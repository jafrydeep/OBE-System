#pragma checksum "E:\Bitbucket\Research\obetools\Views\AcademicEvaluation\Partial\EvaluationToCLOMapping.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b8c14b469c7eed884ce05bd9a09ddadcb2c01530"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AcademicEvaluation_Partial_EvaluationToCLOMapping), @"mvc.1.0.view", @"/Views/AcademicEvaluation/Partial/EvaluationToCLOMapping.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "E:\Bitbucket\Research\obetools\Views\_ViewImports.cshtml"
using OBETools;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Bitbucket\Research\obetools\Views\_ViewImports.cshtml"
using OBETools.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Bitbucket\Research\obetools\Views\_ViewImports.cshtml"
using OBETools.Models.View_Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Bitbucket\Research\obetools\Views\_ViewImports.cshtml"
using OBETools.BLL.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\Bitbucket\Research\obetools\Views\_ViewImports.cshtml"
using OBETools.Utility;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\Bitbucket\Research\obetools\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\Bitbucket\Research\obetools\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\Bitbucket\Research\obetools\Views\_ViewImports.cshtml"
using System.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\Bitbucket\Research\obetools\Views\_ViewImports.cshtml"
using MoreLinq;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b8c14b469c7eed884ce05bd9a09ddadcb2c01530", @"/Views/AcademicEvaluation/Partial/EvaluationToCLOMapping.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0de566846af86ce063b9bf726c0b790922d0238c", @"/Views/_ViewImports.cshtml")]
    public class Views_AcademicEvaluation_Partial_EvaluationToCLOMapping : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EvaluationToCLOMapping>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info btn-custom-style"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateEvaluationToCLOMapping", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "AcademicEvaluation", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("p-1 "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Edit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditEvaluationToCLOMapping", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\Bitbucket\Research\obetools\Views\AcademicEvaluation\Partial\EvaluationToCLOMapping.cshtml"
  
    int count = 1;
    int AssessmentCount = 1;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<hr class=""c-hr-gray"" />
<div class="" row pb-2 pt-1"">
    <div class=""text-left col-md-6"">
        <h5 class=""font-weight-light""><i class=""fas fa-list p-1""></i>Evaluation With CLO Mapping</h5>
    </div>
    <div class="" text-right col-md-6"">
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b8c14b469c7eed884ce05bd9a09ddadcb2c015306818", async() => {
                WriteLiteral("<i class=\"fas fa-plus-circle\"></i>&nbsp; MAP");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    </div>
</div>

<div class=""card mb-4"">
    <div class=""card-body"">
        <div class=""table-responsive"">
            <table class=""table custom-table table-bordered display MultipleDataTable"" id=""dataTable_User"" width=""100%"" cellspacing=""0"">
                <thead>
                    <tr class=""custom-table-user text-center"">
                        <th class=""text-left"">Sl No.</th>
                        <th> Course Name</th>
                        <th> Evaluation Name</th>
                        <th>CLO Name</th>
                        <th>Points</th>
                        <th>Semester</th>
                        <th>Action</th>
                    </tr>
                </thead>

                <tbody>
");
#nullable restore
#line 34 "E:\Bitbucket\Research\obetools\Views\AcademicEvaluation\Partial\EvaluationToCLOMapping.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 37 "E:\Bitbucket\Research\obetools\Views\AcademicEvaluation\Partial\EvaluationToCLOMapping.cshtml"
                            Write(count++);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 38 "E:\Bitbucket\Research\obetools\Views\AcademicEvaluation\Partial\EvaluationToCLOMapping.cshtml"
                           Write(Html.DisplayFor(modelItem => item.AcademicEvaluation.Course.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 39 "E:\Bitbucket\Research\obetools\Views\AcademicEvaluation\Partial\EvaluationToCLOMapping.cshtml"
                           Write(Html.DisplayFor(modelItem => item.AcademicEvaluation.Assessment.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 40 "E:\Bitbucket\Research\obetools\Views\AcademicEvaluation\Partial\EvaluationToCLOMapping.cshtml"
                           Write(Html.DisplayFor(modelItem => item.CLO.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 41 "E:\Bitbucket\Research\obetools\Views\AcademicEvaluation\Partial\EvaluationToCLOMapping.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Points));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 42 "E:\Bitbucket\Research\obetools\Views\AcademicEvaluation\Partial\EvaluationToCLOMapping.cshtml"
                           Write(Html.DisplayFor(modelItem => item.AcademicEvaluation.SemesterId));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td class=\"text-center\" style=\"font-size: .75em\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b8c14b469c7eed884ce05bd9a09ddadcb2c0153011489", async() => {
                WriteLiteral("<i class=\"far fa-edit text-info\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 44 "E:\Bitbucket\Research\obetools\Views\AcademicEvaluation\Partial\EvaluationToCLOMapping.cshtml"
                                                                                                                                           WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                <a class=\"p-1\" title=\"View Details\" data-toggle=\"modal\" data-target=\"#view-evaluationmapping-modal\" data-id=\"");
#nullable restore
#line 45 "E:\Bitbucket\Research\obetools\Views\AcademicEvaluation\Partial\EvaluationToCLOMapping.cshtml"
                                                                                                                                        Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"><i class=\"far fa-eye text-danger\"></i></a>\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 48 "E:\Bitbucket\Research\obetools\Views\AcademicEvaluation\Partial\EvaluationToCLOMapping.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EvaluationToCLOMapping>> Html { get; private set; }
    }
}
#pragma warning restore 1591
