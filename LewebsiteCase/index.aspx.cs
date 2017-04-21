using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LewebsiteCase
{
    public partial class index : System.Web.UI.Page
    {
        public Leadin.Model.CaseInfo model = new Leadin.Model.CaseInfo();

        Leadin.BLL.CaseInfo bll = new Leadin.BLL.CaseInfo();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindDetail();
             
            }
        }


        void BindDetail()
        {
            int id;
            if (!int.TryParse(Request.Params["id"], out id))
            {


           
                System.Data.DataSet ds = bll.GetList(0,"","SortNum desc");


                if (ds.Tables[0].Rows.Count > 0)
                {
                    id = int.Parse(ds.Tables[0].Rows[0]["Id"].ToString());
                }
               


            }


            model = bll.GetModel(id);

            repList.DataSource = bll.GetList(0, "StateInfo=1 and IsRec=1 and Id!="+id, "SortNum desc,Id Desc");
            repList.DataBind();

        }




    }
};