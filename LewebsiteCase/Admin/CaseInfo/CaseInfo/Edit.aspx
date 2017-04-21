<%@ Page Language="C#" AutoEventWireup="true" ValidateRequest="false"  CodeBehind="Edit.aspx.cs" Inherits="LewebsiteCase.Admin.CaseInfo.CaseInfo.Edit1" %>

<%@ Register Src="~/Admin/Controls/Header.ascx" TagPrefix="uc1" TagName="Header" %>
<%@ Register Src="~/Admin/Controls/Left.ascx" TagPrefix="uc1" TagName="Left" %>




<!DOCTYPE html>
<html>

<head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <title>领意文化管理系统平台</title>
    <link rel="stylesheet" type="text/css" href="/Admin/css/style.css" />
    <link rel="stylesheet" type="text/css" href="/Admin/css/index.css" />
    <link rel="stylesheet" type="text/css" href="/Admin/css/font-awesome.min.css" />
    <link rel="stylesheet" type="text/css" href="/Admin/css/inputStyle.css" />
    <link href="/Admin/css/upload.css" rel="stylesheet" />
    <link href="/Admin/css/message.css" rel="stylesheet" />

    <script src="/Admin/js/jquery-1.11.1.min.js" charset="utf-8"></script>
    <script src="/Admin/js/jquery.message.js"></script>
    <script src="/Admin/js/laydate.js"></script>
</head>

<body>
    <form class="form-horizontal" id="myfrom" runat="server">
        <!-- 头部 Begin -->
        <uc1:Header runat="server" id="Header" />
        <!-- 头部 End -->

        <!--正文 Begin-->
        <div id="main">

            <!--左侧导航 Begin-->
            <uc1:Left runat="server" id="Left" />
            <!--左侧导航 End-->

            <!--页面内容 Begin-->
            <div id="pagemain">

                <div class="mapMenu">
                    <ul>
                        <li>位置：</li>
                        <li><a href="/Admin/index.aspx">首页</a></li>
                        <li>></li>
                        <li><a href="../CaseInfo/List.aspx">案例管理</a></li>
                        <li>></li>

                        <li>编辑案例</li>
                    </ul>
                </div>

                <div class="contentBox">

                    <div class="editTop">
                        <span>基本信息</span>
                    </div>
                    <div class="editForm">



                        <div class="control-group">
                            <label class="control-label" for="txtTitle">案例名称</label>
                            <div class="controls">
                                <asp:TextBox runat="server" ID="txtTitle" CssClass="inputWidth2" datatype="*" nullmsg="请输入案例名称！" errormsg="案例名称不能为空！"></asp:TextBox>
                                <span class="help-inline">请填写文章标题！</span>
                            </div>
                        </div>
                        <div class="control-group">
                            <label class="control-label" for="txtSubTitle">案例副名称</label>
                            <div class="controls">
                                <asp:TextBox runat="server" ID="txtSubTitle"  datatype="*" nullmsg="请输入案例副名称！" errormsg="案例副名称不能为空！" CssClass="inputWidth2"></asp:TextBox>
                                 <span class="help-inline">请填写案例副名称！</span>
                            </div>
                        </div>
                        <div class="control-group">
                            <label class="control-label" for="txtLinkUrl" >链接地址</label>
                            <div class="controls">
                                <asp:TextBox runat="server" ID="txtLinkUrl" CssClass="inputWidth2"></asp:TextBox>
                               
                            </div>
                        </div>
                       
                        <div class="control-group">
                            <label class="control-label" for="txtfileico1">案例头图</label>
                            <div class="controls ">

                                <ul class="filebox">
                                    <li class="txtfilename">
                                        <asp:TextBox runat="server" ID="txtHeaderImg" CssClass="inputWidth2"></asp:TextBox></li>
                                    <li class="btnfilea"><a href="javascript:void(0)" onclick="btnfileaclick($(this))" class="btnfilebtn">上传图片</a></li>
                                    <li class="fileinput">
                                        <input type="file" name="fileheaderico" id="fileheaderico" onchange="fileonchange($(this),'myfrom')" /></li>
                                </ul>
                            </div>
                        </div>         
                         <div class="control-group">
                            <label class="control-label" for="txtfileico1">案例头图</label>
                            <div class="controls ">

                                <ul class="filebox">
                                    <li class="txtfilename">
                                        <asp:TextBox runat="server" ID="txtContentImg" CssClass="inputWidth2"></asp:TextBox></li>
                                    <li class="btnfilea"><a href="javascript:void(0)" onclick="btnfileaclick($(this))" class="btnfilebtn">上传图片</a></li>
                                    <li class="fileinput">
                                        <input type="file" name="filecontentimg" id="filecontentimg" onchange="fileonchange($(this),'myfrom')" /></li>
                                </ul>
                            </div>
                        </div>   
                         <div class="control-group">
                            <label class="control-label" for="txtBGColor">背景颜色</label>
                            <div class="controls">
                               R:&nbsp; <asp:TextBox runat="server" ID="txtBGColorR" Width="40" Text="0"  datatype="n" nullmsg="请输入背景颜色R值！" errormsg="请输入背景颜色R值为0-255的正整数！" ></asp:TextBox>&nbsp;&nbsp;&nbsp;
                               G:&nbsp; <asp:TextBox runat="server" ID="txtBGColorG" Width="40" Text="0"  datatype="n" nullmsg="请输入背景颜色G值！" errormsg="请输入背景颜色R值为0-255的正整数！"></asp:TextBox>&nbsp;&nbsp;&nbsp;
                               B:&nbsp; <asp:TextBox runat="server" ID="txtBGColorB" Width="40" Text="0"  datatype="n" nullmsg="请输入背景颜色B值！" errormsg="请输入背景颜色R值为0-255的正整数！"></asp:TextBox>&nbsp;&nbsp;&nbsp;
                               A:&nbsp; <asp:TextBox runat="server" ID="txtBGColorA" Width="40" Text="0.9"  datatype="*" nullmsg="请输入背景颜色A值！" errormsg="请输入背景颜色R值为0-1的一位小数！"></asp:TextBox>
                                <span class="help-inline">请填写正确的背景颜色（RGBA值）！</span>
                            </div>
                        </div>
                        
                        <div class="control-group">
                            <label class="control-label" for="txtContent">案例简介</label>
                            <div class="controls">
                                <asp:TextBox runat="server" ID="txtContent" TextMode="MultiLine" CssClass="inputWidth4 inputHeight2"></asp:TextBox>
                            </div>
                        </div>

                        <div class="control-group">
                            <label class="control-label" for="txtSortNum">案例排序</label>
                            <div class="controls">
                                <asp:TextBox runat="server" ID="txtSortNum"  datatype="n" Text="1000" nullmsg="请输入案例排序！" errormsg="案例按数字从打到小的顺序整数排序！" CssClass="inputWidth1"></asp:TextBox>
                                 <span class="help-inline">请输入案例排序！</span>
                            </div>
                        </div>

                        <div class="control-group">
                            <label class="control-label">案例属性</label>
                            <div class="controls">
                                <label class="checkbox">
                                    <asp:CheckBox runat="server" ID="ckRec" Checked="true" />推荐
                                </label>
                            </div>
                        </div>
                        <div class="control-group">
                            <label class="control-label" for="ckState">案例状态</label>
                            <div class="controls">
                                <label class="checkbox">
                                    <asp:CheckBox runat="server" ID="ckState" Checked="true" />勾选表示显示
                                </label>
                            </div>
                        </div>
                        <div class="form-actions">
                            <asp:Button runat="server" ID="btnOk" CssClass="btn" Text="确认提交" OnClick="btnOk_Click" />
                            <input type="reset" class="btn" value="重置" />
                        </div>
                    </div>
                </div>

                <!--页面内容 End-->

            </div>
            <!--正文 End-->
        </div>

        <script src="/Admin/js/jquery.admin.js" charset="utf-8"></script>
        <script src="/Admin/js/Validform_v5.3.2.js"></script>
        <script src="/Admin/js/jquery.form.min.js"></script>
        <script src="/Admin/js/jquery.uploadfile.js"></script>
        <script src="/Admin/js/jquery.leadinupload.js"></script>
        <script src="/kindeditor-4.1.10/kindeditor.js"></script>
        <script src="/kindeditor-4.1.10/lang/zh_CN.js"></script>
        <script>

            $(function () {

                $(".form-horizontal").Validform({
                    tiptype: function (msg, o, cssctl) {
                        //msg：提示信息;
                        //o:{obj:*,type:*,curform:*}, obj指向的是当前验证的表单元素（或表单对象），type指示提示的状态，值为1、2、3、4， 1：正在检测/提交数据，2：通过验证，3：验证失败，4：提示ignore状态, curform为当前form对象;
                        //cssctl:内置的提示信息样式控制函数，该函数需传入两个参数：显示提示信息的对象 和 当前提示的状态（既形参o中的type）;
                        if (!o.obj.is("form")) {//验证表单元素时o.obj为该表单元素，全部验证通过提交表单时o.obj为该表单对象;
                            var objtip = o.obj.siblings(".help-inline");
                            if (o.type == 2) {

                                objtip.removeClass("error").addClass("success");
                            }
                            else if (o.type == 3) {
                                objtip.removeClass("success").addClass("error");
                            }
                            cssctl(objtip, o.type);
                            objtip.text(msg);
                        } else {
                            var objtip = o.obj.find("#msgdemo");
                            cssctl(objtip, o.type);
                            objtip.text(msg);
                        }
                    }


                });

                SetLeftMenu("案例管理", "添加案例");



                KindEditor.ready(function (K) {
                    var editor1 = K.create('#txtContent', {
                        cssPath: '/kindeditor-4.1.10/plugins/code/prettify.css',
                        uploadJson: '/Tools/upload_json.ashx',
                        fileManagerJson: '/kindeditor-4.1.10/asp.net/file_manager_json.ashx',
                        allowFileManager: true
                    });


                    var editor1 = K.create('#txtEngContent', {
                        cssPath: '/kindeditor-4.1.10/plugins/code/prettify.css',
                        uploadJson: '/Tools/upload_json.ashx',
                        fileManagerJson: '/kindeditor-4.1.10/asp.net/file_manager_json.ashx',
                        allowFileManager: true
                    });
                });



            })

        </script>


    </form>
</body>

</html>

