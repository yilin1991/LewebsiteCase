/**  版本信息模板在安装目录下，可自行修改。
* CaseInfo.cs
*
* 功 能： N/A
* 类 名： CaseInfo
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2016/12/16 15:08:49   N/A    初版
*
* Copyright (c) 2012 Maticsoft Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：动软卓越（北京）科技有限公司　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/
using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Leadin.DBUtility;//Please add references
namespace Leadin.DAL
{
	/// <summary>
	/// 数据访问类:CaseInfo
	/// </summary>
	public partial class CaseInfo
	{
		public CaseInfo()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("Id", "tb_CaseInfo"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int Id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from tb_CaseInfo");
			strSql.Append(" where Id=@Id");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)
			};
			parameters[0].Value = Id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Leadin.Model.CaseInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into tb_CaseInfo(");
			strSql.Append("Title,SubTitle,TypeId,Content,LinkUrl,HeaderImg,BackGround,Opacity,SortNum,StateInfo,IsRec,IsHot,IsIndex,ReadNum,Remark,AddTime)");
			strSql.Append(" values (");
			strSql.Append("@Title,@SubTitle,@TypeId,@Content,@LinkUrl,@HeaderImg,@BackGround,@Opacity,@SortNum,@StateInfo,@IsRec,@IsHot,@IsIndex,@ReadNum,@Remark,@AddTime)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@Title", SqlDbType.NVarChar,-1),
					new SqlParameter("@SubTitle", SqlDbType.NVarChar,-1),
					new SqlParameter("@TypeId", SqlDbType.NVarChar,100),
					new SqlParameter("@Content", SqlDbType.NVarChar,-1),
					new SqlParameter("@LinkUrl", SqlDbType.NVarChar,200),
					new SqlParameter("@HeaderImg", SqlDbType.NVarChar,500),
					new SqlParameter("@BackGround", SqlDbType.NVarChar,200),
					new SqlParameter("@Opacity", SqlDbType.NVarChar,1000),
					new SqlParameter("@SortNum", SqlDbType.Int,4),
					new SqlParameter("@StateInfo", SqlDbType.Int,4),
					new SqlParameter("@IsRec", SqlDbType.Int,4),
					new SqlParameter("@IsHot", SqlDbType.Int,4),
					new SqlParameter("@IsIndex", SqlDbType.Int,4),
					new SqlParameter("@ReadNum", SqlDbType.Int,4),
					new SqlParameter("@Remark", SqlDbType.NVarChar,-1),
					new SqlParameter("@AddTime", SqlDbType.DateTime)};
			parameters[0].Value = model.Title;
			parameters[1].Value = model.SubTitle;
			parameters[2].Value = model.TypeId;
			parameters[3].Value = model.Content;
			parameters[4].Value = model.LinkUrl;
			parameters[5].Value = model.HeaderImg;
			parameters[6].Value = model.BackGround;
			parameters[7].Value = model.Opacity;
			parameters[8].Value = model.SortNum;
			parameters[9].Value = model.StateInfo;
			parameters[10].Value = model.IsRec;
			parameters[11].Value = model.IsHot;
			parameters[12].Value = model.IsIndex;
			parameters[13].Value = model.ReadNum;
			parameters[14].Value = model.Remark;
			parameters[15].Value = model.AddTime;

			object obj = DbHelperSQL.GetSingle(strSql.ToString(),parameters);
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Leadin.Model.CaseInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update tb_CaseInfo set ");
			strSql.Append("Title=@Title,");
			strSql.Append("SubTitle=@SubTitle,");
			strSql.Append("TypeId=@TypeId,");
			strSql.Append("Content=@Content,");
			strSql.Append("LinkUrl=@LinkUrl,");
			strSql.Append("HeaderImg=@HeaderImg,");
			strSql.Append("BackGround=@BackGround,");
			strSql.Append("Opacity=@Opacity,");
			strSql.Append("SortNum=@SortNum,");
			strSql.Append("StateInfo=@StateInfo,");
			strSql.Append("IsRec=@IsRec,");
			strSql.Append("IsHot=@IsHot,");
			strSql.Append("IsIndex=@IsIndex,");
			strSql.Append("ReadNum=@ReadNum,");
			strSql.Append("Remark=@Remark,");
			strSql.Append("AddTime=@AddTime");
			strSql.Append(" where Id=@Id");
			SqlParameter[] parameters = {
					new SqlParameter("@Title", SqlDbType.NVarChar,-1),
					new SqlParameter("@SubTitle", SqlDbType.NVarChar,-1),
					new SqlParameter("@TypeId", SqlDbType.NVarChar,100),
					new SqlParameter("@Content", SqlDbType.NVarChar,-1),
					new SqlParameter("@LinkUrl", SqlDbType.NVarChar,200),
					new SqlParameter("@HeaderImg", SqlDbType.NVarChar,500),
					new SqlParameter("@BackGround", SqlDbType.NVarChar,200),
					new SqlParameter("@Opacity", SqlDbType.NVarChar,1000),
					new SqlParameter("@SortNum", SqlDbType.Int,4),
					new SqlParameter("@StateInfo", SqlDbType.Int,4),
					new SqlParameter("@IsRec", SqlDbType.Int,4),
					new SqlParameter("@IsHot", SqlDbType.Int,4),
					new SqlParameter("@IsIndex", SqlDbType.Int,4),
					new SqlParameter("@ReadNum", SqlDbType.Int,4),
					new SqlParameter("@Remark", SqlDbType.NVarChar,-1),
					new SqlParameter("@AddTime", SqlDbType.DateTime),
					new SqlParameter("@Id", SqlDbType.Int,4)};
			parameters[0].Value = model.Title;
			parameters[1].Value = model.SubTitle;
			parameters[2].Value = model.TypeId;
			parameters[3].Value = model.Content;
			parameters[4].Value = model.LinkUrl;
			parameters[5].Value = model.HeaderImg;
			parameters[6].Value = model.BackGround;
			parameters[7].Value = model.Opacity;
			parameters[8].Value = model.SortNum;
			parameters[9].Value = model.StateInfo;
			parameters[10].Value = model.IsRec;
			parameters[11].Value = model.IsHot;
			parameters[12].Value = model.IsIndex;
			parameters[13].Value = model.ReadNum;
			parameters[14].Value = model.Remark;
			parameters[15].Value = model.AddTime;
			parameters[16].Value = model.Id;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int Id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from tb_CaseInfo ");
			strSql.Append(" where Id=@Id");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)
			};
			parameters[0].Value = Id;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string Idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from tb_CaseInfo ");
			strSql.Append(" where Id in ("+Idlist + ")  ");
			int rows=DbHelperSQL.ExecuteSql(strSql.ToString());
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Leadin.Model.CaseInfo GetModel(int Id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 Id,Title,SubTitle,TypeId,Content,LinkUrl,HeaderImg,BackGround,Opacity,SortNum,StateInfo,IsRec,IsHot,IsIndex,ReadNum,Remark,AddTime from tb_CaseInfo ");
			strSql.Append(" where Id=@Id");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)
			};
			parameters[0].Value = Id;

			Leadin.Model.CaseInfo model=new Leadin.Model.CaseInfo();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				return DataRowToModel(ds.Tables[0].Rows[0]);
			}
			else
			{
				return null;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Leadin.Model.CaseInfo DataRowToModel(DataRow row)
		{
			Leadin.Model.CaseInfo model=new Leadin.Model.CaseInfo();
			if (row != null)
			{
				if(row["Id"]!=null && row["Id"].ToString()!="")
				{
					model.Id=int.Parse(row["Id"].ToString());
				}
				if(row["Title"]!=null)
				{
					model.Title=row["Title"].ToString();
				}
				if(row["SubTitle"]!=null)
				{
					model.SubTitle=row["SubTitle"].ToString();
				}
				if(row["TypeId"]!=null)
				{
					model.TypeId=row["TypeId"].ToString();
				}
				if(row["Content"]!=null)
				{
					model.Content=row["Content"].ToString();
				}
				if(row["LinkUrl"]!=null)
				{
					model.LinkUrl=row["LinkUrl"].ToString();
				}
				if(row["HeaderImg"]!=null)
				{
					model.HeaderImg=row["HeaderImg"].ToString();
				}
				if(row["BackGround"]!=null)
				{
					model.BackGround=row["BackGround"].ToString();
				}
				if(row["Opacity"]!=null)
				{
					model.Opacity=row["Opacity"].ToString();
				}
				if(row["SortNum"]!=null && row["SortNum"].ToString()!="")
				{
					model.SortNum=int.Parse(row["SortNum"].ToString());
				}
				if(row["StateInfo"]!=null && row["StateInfo"].ToString()!="")
				{
					model.StateInfo=int.Parse(row["StateInfo"].ToString());
				}
				if(row["IsRec"]!=null && row["IsRec"].ToString()!="")
				{
					model.IsRec=int.Parse(row["IsRec"].ToString());
				}
				if(row["IsHot"]!=null && row["IsHot"].ToString()!="")
				{
					model.IsHot=int.Parse(row["IsHot"].ToString());
				}
				if(row["IsIndex"]!=null && row["IsIndex"].ToString()!="")
				{
					model.IsIndex=int.Parse(row["IsIndex"].ToString());
				}
				if(row["ReadNum"]!=null && row["ReadNum"].ToString()!="")
				{
					model.ReadNum=int.Parse(row["ReadNum"].ToString());
				}
				if(row["Remark"]!=null)
				{
					model.Remark=row["Remark"].ToString();
				}
				if(row["AddTime"]!=null && row["AddTime"].ToString()!="")
				{
					model.AddTime=DateTime.Parse(row["AddTime"].ToString());
				}
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select Id,Title,SubTitle,TypeId,Content,LinkUrl,HeaderImg,BackGround,Opacity,SortNum,StateInfo,IsRec,IsHot,IsIndex,ReadNum,Remark,AddTime ");
			strSql.Append(" FROM tb_CaseInfo ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" Id,Title,SubTitle,TypeId,Content,LinkUrl,HeaderImg,BackGround,Opacity,SortNum,StateInfo,IsRec,IsHot,IsIndex,ReadNum,Remark,AddTime ");
			strSql.Append(" FROM tb_CaseInfo ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM tb_CaseInfo ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			object obj = DbHelperSQL.GetSingle(strSql.ToString());
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T.Id desc");
			}
			strSql.Append(")AS Row, T.*  from tb_CaseInfo T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			SqlParameter[] parameters = {
					new SqlParameter("@tblName", SqlDbType.VarChar, 255),
					new SqlParameter("@fldName", SqlDbType.VarChar, 255),
					new SqlParameter("@PageSize", SqlDbType.Int),
					new SqlParameter("@PageIndex", SqlDbType.Int),
					new SqlParameter("@IsReCount", SqlDbType.Bit),
					new SqlParameter("@OrderType", SqlDbType.Bit),
					new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
					};
			parameters[0].Value = "tb_CaseInfo";
			parameters[1].Value = "Id";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

