#region License
// Copyright (c) 2013 Nano Taboada, http://openid.nanotaboada.com.ar 
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE. 
#endregion

using System;
using System.Web;
using System.Web.UI;
using System.Reflection;
using System.Text;

/// <remarks>
/// http://msdn.microsoft.com/en-us/library/ms178472
/// </remarks>

namespace Mono.Samples.AspNet
{
    public partial class Program : System.Web.UI.Page
    {
        private DateTime timestamp;
        
        /// <summary>
        /// http://msdn.microsoft.com/en-us/library/system.web.ui.page.onpreinit
        /// </summary>
        protected override void OnPreInit(EventArgs e)
        {
            timestamp = DateTime.Now;
            Response.Write(this.GetPreInitResponse());
            Response.Write(this.GetResponse(MethodBase.GetCurrentMethod().Name, DateTime.Now));
        }
        
        /// <summary>
        /// http://msdn.microsoft.com/en-us/library/system.web.ui.page.oninit
        /// </summary>
        protected override void OnInit(EventArgs e)
        {
            Response.Write(this.GetResponse(MethodBase.GetCurrentMethod().Name, DateTime.Now));
        }

        /// <summary>
        /// http://msdn.microsoft.com/en-us/library/system.web.ui.page.oninitcomplete
        /// </summary>
        protected override void OnInitComplete(EventArgs e)
        {
            Response.Write(this.GetResponse(MethodBase.GetCurrentMethod().Name, DateTime.Now));
        }
        
        /// <summary>
        /// http://msdn.microsoft.com/en-us/library/system.web.ui.page.onpreload
        /// </summary>
        protected override void OnPreLoad(EventArgs e)
        {
            Response.Write(this.GetResponse(MethodBase.GetCurrentMethod().Name, DateTime.Now));
        }
        
        /// <remarks>
        /// http://msdn.microsoft.com/en-us/library/system.web.ui.page.onload
        /// </remarks>
        protected override void OnLoad(EventArgs e)
        {
            Response.Write(this.GetResponse(MethodBase.GetCurrentMethod().Name, DateTime.Now));
        }
        
        /// <summary>
        /// http://msdn.microsoft.com/en-us/library/system.web.ui.page.onloadcomplete
        /// </summary>
        protected override void OnLoadComplete(EventArgs e)
        {
            Response.Write(this.GetResponse(MethodBase.GetCurrentMethod().Name, DateTime.Now));
        }
        
        /// <summary>
        /// http://msdn.microsoft.com/en-us/library/system.web.ui.page.onprerender
        /// </summary>
        protected override void OnPreRender(EventArgs e)
        {
            Response.Write(this.GetResponse(MethodBase.GetCurrentMethod().Name, DateTime.Now));
        }
        
        /// <summary>
        /// http://msdn.microsoft.com/en-us/library/system.web.ui.page.onprerendercomplete
        /// </summary>
        protected override void OnPreRenderComplete(EventArgs e)
        {
            Response.Write(this.GetResponse(MethodBase.GetCurrentMethod().Name, DateTime.Now));
        }
        
        /// <summary>
        /// http://msdn.microsoft.com/en-us/library/system.web.ui.page.onsavestatecomplete
        /// </summary>
        protected override void OnSaveStateComplete(EventArgs e)
        {
            Response.Write(this.GetResponse(MethodBase.GetCurrentMethod().Name, DateTime.Now));
        }
        
        /// <summary>
        /// http://msdn.microsoft.com/en-us/library/system.web.ui.page.onunload
        /// </summary>
        protected override void OnUnload(EventArgs e)
        {
            Response.Write(this.GetResponse(MethodBase.GetCurrentMethod().Name, DateTime.Now));
            Response.Write(this.GetUnloadResponse());
        }
        
        #region Helpers
        private string GetResponse(string eventName, DateTime dateTime)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("<li>");
            builder.Append(eventName);
            builder.AppendFormat(" <em>({0}ms)</em>", dateTime.Subtract(timestamp).TotalMilliseconds);
            builder.Append("</li>");
            return builder.ToString();
        }
        
        private string GetPreInitResponse()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("<!doctype html>");
            builder.Append("<html lang='en'>");
            builder.Append("<head>");
            builder.Append("<meta charset='UTF-8'>");
            builder.Append("<title>ASP.NET Page Life Cycle Overview</title>");
            builder.Append("</head>");
            builder.Append("<body>");
            builder.Append("<section>");
            builder.Append("<h1>Life-cycle Events</h1>");
            builder.Append("<ol>");
            return builder.ToString();      
        }
        
        private string GetUnloadResponse()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("</ol>");            
            builder.Append("</section>");
            builder.Append("</body>");
            builder.Append("</html>");
            return builder.ToString();
        }
        #endregion
    }
}

