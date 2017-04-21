using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Data;

namespace LewebsiteCase.Admin.CaseInfo.CaseInfo
{
    public partial class List : Leadin.Web.UI.ManagePage
    {
        public int pagesize=10;
        public int page;
        public int pcount;
        public StringBuilder strUrl = new StringBuilder();

        Leadin.BLL.CaseInfo bll = new Leadin.BLL.CaseInfo();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindRepList();
            }
        }


        void BindRepList()
        {
            StringBuilder strWhere = new StringBuilder();
            strWhere.Append("1=1");

            if (!string.IsNullOrEmpty(Request.Params["key"]))
            {
                strWhere.Append(" and (Title like '%" + Request.Params["key"] + "%' or SubTitle like '%" + Request.Params["key"] + "%')");
                txtKey.Text = Request.Params["key"];
                strUrl.Append("&key=" + Request.Params["key"]);
            }


            if (!int.TryParse(Request.Params["page"], out page))

            {
                page = 0;
            }

            pcount = bll.GetRecordCount(strWhere.ToString());
            repList.DataSource = bll.GetListByPage(strWhere.ToString(), "SortNum desc,Id desc", pagesize * page + 1, pagesize * page + pagesize);
            repList.DataBind();
        }


        protected void btnSearch_Click(object sender, EventArgs e)
        {
            Response.Redirect("List.aspx?key=" + txtKey.Text);
        }

        protected void btnAllList_Click(object sender, EventArgs e)
        {
            Response.Redirect("List.aspx");
        }

        protected void lbtndel_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < repList.Items.Count; i++)
            {
                CheckBox ckSelect = repList.Items[i].FindControl("ckSelect") as CheckBox;
                if (ckSelect.Checked)
                {
                    HiddenField hidid = repList.Items[i].FindControl("hidid") as HiddenField;
                    bll.Delete(int.Parse(hidid.Value));
                }
            }
            BindRepList();
        }
        

        protected void repList_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "lbtnState")//修改状态
            {
                HiddenField hidid = e.Item.FindControl("hidid") as HiddenField;

                Leadin.Model.CaseInfo model = bll.GetModel(int.Parse(hidid.Value));

                if (model.StateInfo == 1)
                {
                    model.StateInfo = 0;
                }
                else
                {
                    model.StateInfo = 1;
                }

                bll.Update(model);
            }
            if (e.CommandName == "lbtnRec")//修改状态
            {
                HiddenField hidid = e.Item.FindControl("hidid") as HiddenField;

                Leadin.Model.CaseInfo model = bll.GetModel(int.Parse(hidid.Value));

                if (model.IsRec == 1)
                {
                    model.IsRec = 0;
                }
                else
                {
                    model.IsRec = 1;
                }

                bll.Update(model);
            }

            BindRepList();
        }
    }
}