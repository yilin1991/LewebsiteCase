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
namespace Leadin.Model
{
	/// <summary>
	/// CaseInfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class CaseInfo
	{
		public CaseInfo()
		{}
		#region Model
		private int _id;
		private string _title;
		private string _subtitle;
		private string _typeid;
		private string _content;
		private string _linkurl;
		private string _headerimg;
		private string _background;
		private string _opacity;
		private int _sortnum=1000;
		private int _stateinfo=1;
		private int _isrec=1;
		private int _ishot=1;
		private int _isindex=1;
		private int _readnum=0;
		private string _remark;
		private DateTime _addtime= DateTime.Now;
		/// <summary>
		/// 
		/// </summary>
		public int Id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Title
		{
			set{ _title=value;}
			get{return _title;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SubTitle
		{
			set{ _subtitle=value;}
			get{return _subtitle;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TypeId
		{
			set{ _typeid=value;}
			get{return _typeid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Content
		{
			set{ _content=value;}
			get{return _content;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LinkUrl
		{
			set{ _linkurl=value;}
			get{return _linkurl;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string HeaderImg
		{
			set{ _headerimg=value;}
			get{return _headerimg;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BackGround
		{
			set{ _background=value;}
			get{return _background;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Opacity
		{
			set{ _opacity=value;}
			get{return _opacity;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int SortNum
		{
			set{ _sortnum=value;}
			get{return _sortnum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int StateInfo
		{
			set{ _stateinfo=value;}
			get{return _stateinfo;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int IsRec
		{
			set{ _isrec=value;}
			get{return _isrec;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int IsHot
		{
			set{ _ishot=value;}
			get{return _ishot;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int IsIndex
		{
			set{ _isindex=value;}
			get{return _isindex;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int ReadNum
		{
			set{ _readnum=value;}
			get{return _readnum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Remark
		{
			set{ _remark=value;}
			get{return _remark;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime AddTime
		{
			set{ _addtime=value;}
			get{return _addtime;}
		}
		#endregion Model

	}
}

