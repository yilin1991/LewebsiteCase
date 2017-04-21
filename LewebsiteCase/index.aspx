<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="LewebsiteCase.index" %>

<!DOCTYPE html>
<html>

<head>
    <meta charset="utf-8">
    <meta name="viewport" content="initial-scale=1.0, maximum-scale=1.0, user-scalable=no" />
    <title>案例详情页面</title>
    <link rel="stylesheet" type="text/css" href="css/style.css" />

</head>

<body class="body">

    <ul class="caseremark" style="background: rgb(<%= model.BackGround %>);">
        <li class="logo">
            <img src="img/logo.png" /></li>
        <li class="nameinfo">
            <p><%= model.Title %></p>
        </li>
        <li class="line"><span></span></li>
        <li class="remark">
            <p><%= model.SubTitle %></p>
        </li>

    </ul>

    <ul class="casedetail">
        <li class="text">
            <%= model.Content %>

        </li>
        <li class="linkweb">
            <a href="#" style="background: rgb(<%= model.BackGround %>);">查看网站</a>
        </li>
    </ul>

    <ul class="caseimg">
        <li>
            <img src="<%= model.HeaderImg %>" /></li>
        <li>
            <img src="<%= model.Remark %>" /></li>
    </ul>

    <ul class="morecase">
        <li class="morecasebtn">
            <a href="#" style="border-color: rgb(<%= model.BackGround %>); color: rgb(<%= model.BackGround %>)">更多案例</a>
        </li>


        <asp:Repeater runat="server" ID="repList">
            <ItemTemplate>
                <li class="morecaselist" style="background-image: url(<%# Eval("HeaderImg").ToString()%>);">
                    <a href="index.aspx?id=<%# Eval("Id") %>" style="background: rgba(<%# Eval("BackGround").ToString()+","+Eval("Opacity").ToString()%>);">
                        <p class="nameinfo"><%# Eval("Title") %></p>
                        <span class="line"></span>
                        <p class="remark"><%# Eval("SubTitle") %></p>
                    </a>
                </li>
            </ItemTemplate>
        </asp:Repeater>



    </ul>

    <ul class="casefooter">
        <li class="cooperation"><span>想了解更多？</span>
            <a href="#">与我们合作</a>
        </li>
        <li class="title">
            <p>我们的服务</p>
        </li>
        <li class="footline"><span></span></li>
        <li class="service">
            <a href="#">品牌网站设计</a>
            <a href="#">web app 设计</a>
            <a href="#">品牌 & 战略咨询 </a>
            <a href="#">logo & vi 设计</a>
        </li>
        <li class="title">
            <p>联系方式</p>
        </li>
        <li class="footline"><span></span></li>
        <li class="contact">
            <a class="address">
                <p>上海市浦东新区北张家浜路88号左岸88创意园B402室</p>
            </a>
            <a href="tel:021-50110509" class="tel">
                <p>021-5011-0509</p>
            </a>
            <a href="mailto:leadin@leadin.cn" class="email">
                <p>lewebsite@leadin.cn</p>
            </a>
        </li>
    </ul>


    <ul class="menu">
        <li class="default">
            <img src="img/defaultico.png" class="defaultimg" /><img src="img/closeico.png" class="closeimg" /></li>
        <!--<li class="closemenu"><img src="img/closeico.png"/></li>-->
        <li class="menuindex menubtn"><a href="http://www.lewebsite.cn/mobile/index.aspx">
            <img src="img/homeico.png" /></a></li>
        <li class="menuservice menubtn"><a href="http://www.lewebsite.cn/mobile/BasicServices.aspx">
            <img src="img/serviceico.png" /></a></li>
        <li class="menucase menubtn"><a href="http://www.lewebsite.cn/mobile/case.aspx">
            <img src="img/caseico.png" /></a></li>
        <li class="menucontact menubtn"><a href="http://www.lewebsite.cn/mobile/aboutus.aspx">
            <img src="img/contactico.png" /></a></li>
        <li class="menutop menubtn">
            <img src="img/topico.png" /></li>
    </ul>


    <script src="js/jquery-1.11.1.min.js" type="text/javascript" charset="utf-8"></script>

    <script type="text/javascript">

        $(function () {

            $(".default").click(function () {
                event.stopPropagation();
                if ($(".menu").hasClass("active")) {
                    $(".menu").removeClass("active");
                }
                else {

                    $(".menu").addClass("active");
                }
            })



            $(".menutop").click(function () {

                $(".menu").removeClass("active");

                $("html,body").animate({ "scrollTop": "0px" }, 500);


            })


        })


    </script>




</body>

</html>
