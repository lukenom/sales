$PBExportHeader$w_help.srw
forward
global type w_help from w_base
end type
type cb_1 from commandbutton within w_help
end type
type wb_website from webbrowser within w_help
end type
end forward

global type w_help from w_base
integer width = 4119
integer height = 2716
boolean border = true
windowtype windowtype = child!
windowstate windowstate = normal!
cb_1 cb_1
wb_website wb_website
end type
global w_help w_help

on w_help.create
int iCurrent
call super::create
this.cb_1=create cb_1
this.wb_website=create wb_website
iCurrent=UpperBound(this.Control)
this.Control[iCurrent+1]=this.cb_1
this.Control[iCurrent+2]=this.wb_website
end on

on w_help.destroy
call super::destroy
destroy(this.cb_1)
destroy(this.wb_website)
end on

event open;call super::open;
string ls_dir,ls_name,ls_file
ls_name="readme.md"
ls_file=GetCurrentDirectory ( ) + "\" + ls_name


wb_website.navigate(ls_file)	//https://docs.appeon.com/appeon_online_help/snapdevelop2019/features_list/



end event

event resize;call super::resize;
wb_website.width = newwidth
wb_website.height = newheight
end event

type cb_1 from commandbutton within w_help
integer x = 402
integer y = 1320
integer width = 521
integer height = 132
integer taborder = 10
integer textsize = -12
integer weight = 400
fontcharset fontcharset = ansi!
fontpitch fontpitch = variable!
fontfamily fontfamily = swiss!
string facename = "Tahoma"
string text = "myHelpButton"
end type

event clicked;messagebox('Welcome', 'Todays the day!')
end event

type wb_website from webbrowser within w_help
integer width = 2976
integer height = 1268
string defaulturl = "https://www.appeon.com/elevate"
boolean border = false
borderstyle borderstyle = stylebox!
end type

