@charset "utf-8";
/* Simple fluid media
   Note: Fluid media requires that you remove the media's height and width attributes from the HTML
   http://www.alistapart.com/articles/fluid-images/ 
*/
img, object, embed, video {
	max-width: 100%;
}

/* IE 6 does not support max-width so default to width 100% */
.ie6 img {
	width:100%;
}

/*
	Dreamweaver Fluid Grid Properties
	----------------------------------
	dw-num-cols-mobile:		4;
	dw-num-cols-tablet:		8;
	dw-num-cols-desktop:	12;
	dw-gutter-percentage:	25;
	
	Inspiration from "Responsive Web Design" by Ethan Marcotte 
	http://www.alistapart.com/articles/responsive-web-design
	
	and Golden Grid System by Joni Korpi
	http://goldengridsystem.com/
*/
.fluid {
	clear: both;
	margin-left: 0;
	width: 100%;
	float: left;
	display: block;
}

.fluidList {
    list-style:none;
    list-style-image:none;
    margin:0;
    padding:0;        
}
body{
	font-size:12px;	
	font-family: Arial,Helvetica,sans-serif;
	color:#666666;
}

/* Mobile Layout: 480px and below. */
  
.gridContainer {
	margin-left: auto;
	margin-right: auto;
	width: 1070px;	
	clear: none;
	float: none;
}
#div1 {
}
.zeroMargin_mobile {
    margin-left: 0;
}
.hide_mobile {
    display: none;
}

.login{
	float:none;
	width:700px;
	height:385px;
	margin:170px auto 0;
	position:relative;
	border:1px solid #000;
	background: url(../images/top.jpg) top left no-repeat;
}
.login2{
	background:url(../images/bottom.jpg) bottom left no-repeat;
	position:absolute;
	bottom:0;
	right:0;
	width:700px;
	height:163px;
}
.title{
	float:right;
	width:410px;
	height:72px;
	background:url(../images/top2.jpg);
	position:absolute;
	top:60px;
	right:26px;
}
.navigation{
	float:left;
	width:100%;
	height:34px;
	margin:184px 0 0 0;
	position:relative;
	display:block;
	background:#EFB600;
	border-top:2px solid #000;
	border-bottom:2px solid #000;
}
.navigation ul{
	float:left;
	width:100%;
	height:34px;
	margin:0;
	padding:0;
	line-height:32px;
	text-align:center;
}
.navigation ul li{
	display:inline-block;
}
.navigation ul li a{
	color: #333333;
    font-family: Arial,Helvetica,sans-serif;
    font-size: 11px;
    font-weight: normal;
    letter-spacing: 0;
    text-decoration: none;
}
.login-box{
	position:absolute;
	width:200px;
	height:124px;
	background:url(../images/login-box.png);
	bottom:22px;
	left:15px;	
}
.login-box table{
	width:90%;
	margin:8px 0 0 5%;
}
.login-box table th, .login-box table td{
	color: #666666;
    font-family: Arial,Helvetica,sans-serif;
    font-size: 11px;
    font-weight: normal;
    letter-spacing: 0;
    line-height: 10px;
    text-decoration: none;
	border:none;
}
.login-box input[type=text], .login-box input[type=password]{
	 border: 1px solid #666666;
    color: #666666;
    font-family: Arial,Helvetica,sans-serif;
    font-size: 11px;
    font-weight: normal;    
    letter-spacing: 0;
    text-decoration: none;
    vertical-align: middle;
	width:80px;
	height:20px;
	padding:0;
	line-height:20px !important;
}
.login-box input[type=submit]
{
    font-family:Arial;
	background:RoyalBlue;
	color:#fff;
	border:none;
	width:48px;
	height:18px;
	font-weight:bold;
	margin-top:3px;
	outline:0;
}
.txt-login
{
    margin-left:16px;
}
header{
	float:left;
	width:100%;
	height:auto;
	margin:0;
	padding:0;
	position:relative;
	display:block;
}
.header{
	float:left;
	width:100%;
	height:55px;
	position:relative;
	display:block;
	background:#000;
	border-bottom:2px solid #cecfce;
}
.logo{
	float:left;
	width:138px;
	height:auto;
	z-index:2;
	position:relative;
	margin:0 0 0 50px;
}
.nav{
	float:left;
	width:100%;
	height:19px;
	position:relative;
	display:block;
	background:#ac0404;
	border-bottom:2px solid #cecfce;	
}
.nav ul{
	float:left;
	width:100%;
	height:19px;
	margin:0;
	padding:0;
	line-height:15px;
	text-align:center;
	position:relative;	
	color: #fff;
}
.nav ul li{
	display:inline-block;
}
.nav ul li a{
	color: #fff;
    font-family: Arial,Helvetica,sans-serif;
    font-size: 11px;
    font-weight: normal;
    letter-spacing: 0;
    text-decoration: none;
}
.nav2{
	float:left;
	width:100%;
	height:22px;
	position:relative;
	display:block;
	background:#f7b200;
	border-bottom:2px solid #cecfce;	
}
.nav2 ul{
	float:left;
	width:100%;
	height:19px;
	margin:0;
	padding:0;
	line-height:22px;
	text-align:center;
	position:relative;	
	color: #333;
}
.nav2 ul li{
	display:inline-block;
}
.nav2 ul li a{
	color: #333;
    font-family: Arial,Helvetica,sans-serif;  
    font-weight: normal;
    letter-spacing: 0;
    text-decoration: none;
}
.nav2 ul li a strong{
	color: #320000 !important;
}
.error-msg2
{
    float:left;
    position:absolute;
    display:block;
    width:100%;
    color:#c20000;
    text-align:center;
    top:10px;

}

.p-child{
	width:auto !important;
	margin:0 auto;
	float:none !important;
	border:none !important;
}
.p-child td{
	border:none;
}
.p-child td input[type=text], .p-child td input[type=password]{
	border: 1px solid #666666;
    color: #666666;
    font-family: Arial,Helvetica,sans-serif;
    font-size: 11px;
    font-weight: normal;    
    letter-spacing: 0;
    text-decoration: none;
    vertical-align: middle;	
	height:20px;
	padding:0;
	line-height:20px !important;
}
.p-child input[type=submit]{
	background:#1e90ff;
	color:#fff;
	border:none;
	width:auto;
	height:auto;
	padding:4px 4px;
	font-family:Arial,Helvetica,sans-serif;
	font-size:14px;
}
.p-child a{
	color:#990000;
	text-decoration:none;
	font-weight:bold;
}
.childreg{
	width:100%;
	margin:0 auto;
}
.childreg td{
	border:none;
}
.childreg td input[type=text], .childreg td input[type=password]{
	border: 1px solid #666666;
    color: #666666;
    font-family: Arial,Helvetica,sans-serif;
    font-size: 11px;
    font-weight: normal;    
    letter-spacing: 0;
    text-decoration: none;
    vertical-align: middle;	
	height:20px;
	padding:0 4;
}
.childreg input[type=submit]{
	background:#1e90ff;
	color:#fff;
	border:none;
	width:auto;
	height:auto;
	padding:4px 8px;
	font-family:Arial,Helvetica,sans-serif;
	font-size:14px;
}
.childreg a{
	color:#990000;
	text-decoration:none;
	font-weight:bold;
}

/*about us start*/
.about{
	float:none;
	width:80%;
	margin:0 auto;
}
.about h2{
	float:left;
	width:96%;
	height:auto;
	padding:5px 2%;
	border-bottom:1px solid #000;
	border-top:1px solid #000;
	background:#AC0404;
	color:#fff;
}
.faq h3{
	float:left;
	width:96%;
	margin:14px 2% 5px 2%;
}
.faq p{
	float:left;
	width:96%;
	margin:0 0 5px 4%;
}
.ca-title{
	color:#FF0055;
	font-weight:bold;
}
/*about us end*/

/*faq start*/
.faq{
	float:none;
	width:80%;
	margin:0 auto;
}
.faq h2{
	float:left;
	width:96%;
	height:auto;
	padding:5px 2%;
	border-bottom:1px solid #000;
	border-top:1px solid #000;
	background:#AC0404;
	color:#fff;
}
.faq h3{
	float:left;
	width:96%;
	margin:14px 2% 5px 2%;
}
.faq p{
	float:left;
	width:96%;
	margin:0 0 5px 4%;
}
/*faq end*/

/*download start*/
.download{
	float:none;
	width:80%;
	margin:0 auto;
}
.d-block{
	float:left;
	width:23%;
	height:auto;
	margin:0 1% 20px 1%;
	padding:0;
	text-align:center;
	border-bottom:1px solid #d4d4d4;
	min-height:150px;
}
/*download end*/

/*mgm start*/
.mgm{
	float:none;
	width:80%;
	margin:0 auto;
}
.mgm h2{
	float:left;
	width:96%;
	height:auto;
	padding:5px 2%;
	border-bottom:1px solid #000;
	border-top:1px solid #000;
	background:#AC0404;
	color:#fff;
}
.mgm p{
	float:left;
	width:96%;
	margin:0 2% 14px 2%;
}
/*mgm end*/


/*logout start*/
.lt
{
    float:left;
    width:100%;
    height:auto;
}
.lt-msg
{
    color: #c71585;
    float: left;
    font-size: 16px;
    margin: 80px 0 30px;
    text-align: center;
    width: 100%;
    font-weight:bold;
}
.lt-return
{
    float:left;
    width:100%;
    font-size:11px;    
    margin:10px 0 30px 0;
    text-align:center;
    text-decoration:none;
    color:#494c50 !important;
}
.lt-close
{
    float:left;
    width:100%;
    font-size:11px;    
    margin:10px 0 30px 0;
    text-align:center;
    text-decoration:none;
}
/*logout end*/

/*error start*/
.error-p
{
    float:left;
    width:100%;
    height:auto;
}
.error-msg
{
    float:left;
    width:100%;   
    font-size:12px;
    font-weight:bold;
    margin:0;
    text-align:center;     
    color:#c20000;   
}
.error-msg ul
{
    margin:0;
}
.error-msg ul li
{
    float:left;
    list-style:none;
    clear:left;
}
.error-close
{
    float:left;
    width:100%;
    font-size:11px;    
    margin:10px 0 30px 0;
    text-align:center;
    text-decoration:none;
}
.error-return
{
    float:left;
    width:100%;
    font-size:11px;    
    margin:10px 0 30px 0;
    text-align:center;
    text-decoration:none;
    color:#494c50 !important;
}
.error-session
{
    margin-top:35px !important;
}
/*error end*/

/*login-error*/
.error-login{
    float:left;
    width:100%;
    color:#cc2125;
    font-size:12px;
    font-weight:bold;
    margin:0;
    text-align:center;
    bottom:2px;
    left:0;
    position:absolute;
    bottom:2px;
    left:0;
    font-family:Verdana !important;
}
.error-login ul
{
    margin:0;
}
.error-login ul li
{
    float:left;
    list-style:none;
    clear:left;
    width:100%;
}
/*login-error end*/

/*rights*/
.rights
{
    float:left;
    width:100%;
    height:50px;
    line-height:50px;
    text-align:center;
    position:relative;
    font-family:Verdana;
    font-size:10px;
    color:#808080;
}
/*rights end*/

/*captcha css*/
.updPnlCaptcha img
{
   float:left;
}
.updPnlCaptcha input[type=image]
{
    float:left;
    width:24px;
    height:24px; 
    margin-left:4px;
}
.button-point
{
    width: 60%!important;
    float: right!important;
}
.button-point td
{
    border:0px;
}

.disableButton{
	background-color: gray !important;
}