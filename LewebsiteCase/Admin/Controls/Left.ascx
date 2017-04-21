<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Left.ascx.cs" Inherits="LewebsiteCase.Admin.Controls.Left" %>

<div id="leftmenu">
    <div class="leftBox">
        <div class="leftBoxTitle">
            <p>管理台</p>
        </div>

        <div class="leftMenu">


            <div class="leftMenuList">
                <div class="leftMenuListTop">
                    <ul>
                        <li>
                            <img src="/Admin/img/leftico04.png" />
                        </li>
                        <li>案例管理</li>
                    </ul>
                </div>
                <div class="leftMenuListLi">
                    <ul>
                        <li><a href="/Admin/CaseInfo/CaseInfo/List.aspx" draggable="false"><span>案例列表</span></a>
                        </li>
                        <li><a href="/Admin/CaseInfo/CaseInfo/Edit.aspx" draggable="false"><span>添加案例</span></a>
                        </li>
                    </ul>
                </div>

            </div>

           

            <div class="leftMenuList">
                <div class="leftMenuListTop">
                    <ul>
                        <li>
                            <img src="/Admin/img/leftico04.png" />
                        </li>
                        <li>系统设置</li>
                    </ul>
                </div>
                <div class="leftMenuListLi">
                    <ul>
                        <li><a href="/Admin/SystemInfo/Company.aspx" draggable="false"><span>网站设置</span></a>
                        </li>

                    </ul>
                </div>

            </div>
        </div>

    </div>
</div>
