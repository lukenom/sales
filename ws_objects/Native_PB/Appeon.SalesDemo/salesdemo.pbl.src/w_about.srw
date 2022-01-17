﻿$PBExportHeader$w_about.srw
forward
global type w_about from w_base
end type
type cb_1 from commandbutton within w_about
end type
type st_6 from statictext within w_about
end type
type st_5 from statictext within w_about
end type
type st_4 from statictext within w_about
end type
type st_3 from statictext within w_about
end type
type st_2 from statictext within w_about
end type
type st_1 from statictext within w_about
end type
type p_1 from picture within w_about
end type
end forward

global type w_about from w_base
string tag = "about"
integer width = 1792
integer height = 1232
boolean titlebar = true
string title = "About"
boolean controlmenu = true
boolean border = true
windowtype windowtype = response!
windowstate windowstate = normal!
string icon = "image\about.ico"
cb_1 cb_1
st_6 st_6
st_5 st_5
st_4 st_4
st_3 st_3
st_2 st_2
st_1 st_1
p_1 p_1
end type
global w_about w_about

on w_about.create
int iCurrent
call super::create
this.cb_1=create cb_1
this.st_6=create st_6
this.st_5=create st_5
this.st_4=create st_4
this.st_3=create st_3
this.st_2=create st_2
this.st_1=create st_1
this.p_1=create p_1
iCurrent=UpperBound(this.Control)
this.Control[iCurrent+1]=this.cb_1
this.Control[iCurrent+2]=this.st_6
this.Control[iCurrent+3]=this.st_5
this.Control[iCurrent+4]=this.st_4
this.Control[iCurrent+5]=this.st_3
this.Control[iCurrent+6]=this.st_2
this.Control[iCurrent+7]=this.st_1
this.Control[iCurrent+8]=this.p_1
end on

on w_about.destroy
call super::destroy
destroy(this.cb_1)
destroy(this.st_6)
destroy(this.st_5)
destroy(this.st_4)
destroy(this.st_3)
destroy(this.st_2)
destroy(this.st_1)
destroy(this.p_1)
end on

event open;call super::open;string ls_version,ls_detailversion
environment env
integer rtn

rtn = GetEnvironment(env)

IF rtn <> 1 THEN RETURN
choose case env.pbfixesrevision
	case 0
		ls_detailversion = ''
	case 1
		ls_detailversion = 'R2'
	case 2
		ls_detailversion = 'R3'
end choose
st_4.text = 'Version: PB20' + string(env.pbmajorrevision)+ls_detailversion + ' ' + string(env.pbbuildnumber)
end event

type cb_1 from commandbutton within w_about
integer x = 1170
integer y = 832
integer width = 457
integer height = 132
integer taborder = 10
integer textsize = -12
integer weight = 400
fontcharset fontcharset = ansi!
fontpitch fontpitch = variable!
fontfamily fontfamily = swiss!
string facename = "Tahoma"
string text = "Button"
end type

event clicked;messagebox('Welcome', 'Todays the day!')
end event

type st_6 from statictext within w_about
integer x = 366
integer y = 740
integer width = 1001
integer height = 76
integer textsize = -10
integer weight = 400
fontcharset fontcharset = ansi!
fontpitch fontpitch = variable!
fontfamily fontfamily = swiss!
string facename = "Tahoma"
long textcolor = 33554432
long backcolor = 67108864
string text = "Author: Monson"
boolean focusrectangle = false
end type

type st_5 from statictext within w_about
integer x = 366
integer y = 620
integer width = 1001
integer height = 76
integer textsize = -10
integer weight = 400
fontcharset fontcharset = ansi!
fontpitch fontpitch = variable!
fontfamily fontfamily = swiss!
string facename = "Tahoma"
long textcolor = 33554432
long backcolor = 67108864
string text = "Language: English"
boolean focusrectangle = false
end type

type st_4 from statictext within w_about
integer x = 366
integer y = 500
integer width = 1001
integer height = 76
integer textsize = -10
integer weight = 400
fontcharset fontcharset = ansi!
fontpitch fontpitch = variable!
fontfamily fontfamily = swiss!
string facename = "Tahoma"
long textcolor = 33554432
long backcolor = 67108864
string text = "Version: 2021"
boolean focusrectangle = false
end type

type st_3 from statictext within w_about
integer x = 366
integer y = 380
integer width = 1001
integer height = 76
integer textsize = -10
integer weight = 400
fontcharset fontcharset = ansi!
fontpitch fontpitch = variable!
fontfamily fontfamily = swiss!
string facename = "Tahoma"
long textcolor = 33554432
long backcolor = 67108864
string text = "Product name: PowerBuilder"
boolean focusrectangle = false
end type

type st_2 from statictext within w_about
integer x = 82
integer y = 968
integer width = 1426
integer height = 84
integer textsize = -12
integer weight = 400
fontcharset fontcharset = ansi!
fontpitch fontpitch = variable!
fontfamily fontfamily = swiss!
string facename = "Tahoma"
long textcolor = 33554432
long backcolor = 67108864
string text = "Copyright © Appeon. All rights reserved."
boolean focusrectangle = false
end type

type st_1 from statictext within w_about
integer x = 370
integer y = 140
integer width = 919
integer height = 104
integer textsize = -16
integer weight = 400
fontcharset fontcharset = ansi!
fontpitch fontpitch = variable!
fontfamily fontfamily = swiss!
string facename = "Tahoma"
long textcolor = 33554432
long backcolor = 67108864
string text = "WayPoint CRM Demo"
boolean focusrectangle = false
end type

type p_1 from picture within w_about
integer x = 82
integer y = 124
integer width = 192
integer height = 176
string picturename = "image\about.png"
boolean focusrectangle = false
end type

