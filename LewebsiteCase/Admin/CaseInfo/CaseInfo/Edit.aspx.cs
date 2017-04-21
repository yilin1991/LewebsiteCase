using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LewebsiteCase.Admin.CaseInfo.CaseInfo
{
    public partial class Edit1 : Leadin.Web.UI.ManagePage
    {

        Leadin.BLL.CaseInfo bll = new Leadin.BLL.CaseInfo();


        int id;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (int.TryParse(Request.Params["id"], out id))
                {
                    BindDetail(id);
                }
            }
        }

        void BindDetail(int caseid)
        {
            Leadin.Model.CaseInfo model = bll.GetModel(caseid);

            string[] strRGB = model.BackGround.Split(',');
            txtBGColorA.Text = model.Opacity;
            txtBGColorR.Text = strRGB[0];
            txtBGColorG.Text = strRGB[1];
            txtBGColorB.Text = strRGB[2];
            txtContent.Text = model.Content;
            txtContentImg.Text = model.Remark;
            txtHeaderImg.Text = model.HeaderImg;
            txtTitle.Text = model.Title;
            txtSubTitle.Text = model.SubTitle;
            txtSortNum.Text = model.SortNum.ToString();
            ckRec.Checked = model.IsRec == 1 ? true : false;
            ckState.Checked = model.StateInfo == 1 ? true : false;
            txtLinkUrl.Text = model.LinkUrl;

        }


        protected void btnOk_Click(object sender, EventArgs e)
        {
            Leadin.Model.CaseInfo model = new Leadin.Model.CaseInfo();

            bool IsEdit = string.IsNullOrEmpty(Request.Params["id"]);

            if (!IsEdit)
            {
                model = bll.GetModel(int.Parse(Request.Params["id"]));
            }

            model.BackGround = txtBGColorR.Text + "," + txtBGColorG.Text + "," + txtBGColorB.Text;
            model.Content = txtContent.Text;
            model.HeaderImg = txtHeaderImg.Text;
            model.IsRec = ckRec.Checked ? 1 : 0;
            model.LinkUrl = txtLinkUrl.Text;
            model.Opacity = txtBGColorA.Text;
            model.Remark = txtContentImg.Text;
            model.SortNum = int.Parse(txtSortNum.Text);
            model.StateInfo = ckState.Checked ? 1 : 0;
            model.SubTitle = txtSubTitle.Text;
            model.Title = txtTitle.Text;

            if (IsEdit)
            {

                if (bll.Add(model) > 0)
                {
                    JsMessage("success", "案例发布成功！", 1000, "List.aspx");
                }
                else
                {
                    JsMessage("error", "案例发布失败，请检查您的输入！", 1000, "back");
                }
            }
            else
            {
                if (bll.Update(model))
                {
                    JsMessage("success", "案例信息编辑成功！", 1000, "List.aspx");
                }
                else
                {
                    JsMessage("error", "案例信息编辑失败，请检查您的输入！", 1000, "back");
                }
            }



        }
    }
}