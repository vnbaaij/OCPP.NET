using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;


namespace BlazorChargePointTest.Components
{
    public partial class LogViewer : ComponentBase, IDisposable
    {

        [Parameter]
        public string Message { get; set; }


        [Parameter]
        public ComponentBase Parent { get; set; }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        protected override void BuildRenderTree(RenderTreeBuilder builder)
        {

            int k = -1;

            //builder.OpenElement(k++, "div");
            //builder.AddAttribute(k++, "id", "listitem" + Guid.NewGuid().ToString("d").Substring(1, 4));
            //builder.AddAttribute(k++, "style", "width:900px;max-height:26px;position:relative;margin:5px");
            builder.OpenElement(k++, "span");






                builder.AddAttribute(k++, "style", "position:relative;cursor:pointer;color:blue");

            //else
            //{
            //    builder.AddAttribute(k++, "style", "position:absolute;top:0px;cursor:pointer;color:green");
            //}




            builder.AddContent(k++, (MarkupString)(Message.Replace("\n","<br />") + "<br />"));



            builder.CloseElement();

            //builder.CloseElement();



            base.BuildRenderTree(builder);
        }
    }
}
