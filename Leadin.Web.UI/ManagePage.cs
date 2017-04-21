using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;

namespace Leadin.Web.UI
{
    public partial class ManagePage : System.Web.UI.Page
    {

        /// <summary>
        /// 弹出提示框
        /// </summary>
        public void JsMessage(string state, string text)
        {
            string msbox = "";
            msbox += "<script type=\"text/javascript\">\n";
            msbox += "ShowMessage(\"" + state + "\",\"" + text + "\")\n";
            msbox += "</script>\n";
            ClientScript.RegisterClientScriptBlock(Page.GetType(), "JsPrint", msbox);
        }
        /// <summary>
        /// 弹出提示框
        /// </summary>
        public void JsMessage(string state, string text, int endTime)
        {
            string msbox = "";
            msbox += "<script type=\"text/javascript\">\n";
            msbox += "ShowMessage(\"" + state + "\",\"" + text + "\"," + endTime + ")\n";
            msbox += "</script>\n";
            ClientScript.RegisterClientScriptBlock(Page.GetType(), "JsPrint", msbox);
        }


        /// <summary>
        /// 弹出提示框
        /// </summary>
        public void JsMessage(string state, string text, int endTime, string linkUrl)
        {
            string msbox = "";
            msbox += "<script type=\"text/javascript\">\n";
            msbox += "ShowMessage(\"" + state + "\",\"" + text + "\"," + endTime + ",\"" + linkUrl + "\")\n";
            msbox += "</script>\n";
            ClientScript.RegisterClientScriptBlock(Page.GetType(), "JsPrint", msbox);
        }



    }
}
