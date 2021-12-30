﻿$PBExportHeader$salesdemo.sra
$PBExportComments$Generated Application Object
forward
global type salesdemo from application
end type
global transaction sqlca
global dynamicdescriptionarea sqlda
global dynamicstagingarea sqlsa
global error error
global message message
end forward

global variables

//Service Type
Constant Int WEBAPI_DATASTORE = 1
Constant Int WEBAPI_MODELSTORE = 2
Constant Int WEBAPI_SQLMODELMAPPER = 3
Boolean gb_expand = True

String gs_msg_title = "Sales CRM Demo"


end variables

global type salesdemo from application
string appname = "salesdemo"
string displayname = "SalesDemo"
string themepath = "C:\Program Files (x86)\Appeon\PowerBuilder 21.0\IDE\theme"
string themename = "Flat Design Blue"
boolean nativepdfvalid = false
boolean nativepdfincludecustomfont = false
string nativepdfappname = ""
long richtextedittype = 3
long richtexteditx64type = 3
long richtexteditversion = 2
string richtexteditkey = ""
string appicon = ".\image\crm.ico"
string appruntimeversion = "21.0.0.1311"
boolean manualsession = false
boolean unsupportedapierror = true
end type
global salesdemo salesdemo

on salesdemo.create
appname="salesdemo"
message=create message
sqlca=create transaction
sqlda=create dynamicdescriptionarea
sqlsa=create dynamicstagingarea
error=create error
end on

on salesdemo.destroy
destroy(sqlca)
destroy(sqlda)
destroy(sqlsa)
destroy(error)
destroy(message)
end on

event open;String  ls_theme
ls_theme = ProfileString("apisetup.ini", "Setup", "Theme", "Flat Design Blue")
IF ls_theme <> "Do Not Use Themes" THEN
	applytheme(GetCurrentDirectory( ) + "\Theme\" + ls_theme)
END IF


//// Profile PB Postgres V2019R3
//SQLCA.DBMS = "ODBC"
//SQLCA.AutoCommit = False
//SQLCA.DBParm = "ConnectString='DSN=PB Postgres V2021',TrimSpaces='Yes'"


// Profile test
SQLCA.DBMS = "MSOLEDBSQL SQL Server"
SQLCA.LogPass = "sql1$9f^1"
SQLCA.ServerName = "ITL-LMONSON"
SQLCA.LogId = "pbdev"
SQLCA.AutoCommit = False
SQLCA.DBParm = "Database='adventureworks2012'"


Connect Using SQLCA;

if sqlca.sqlcode = 0 then
   open(w_main)
else
	messagebox('Information','Connect database fail: '+ sqlca.sqlerrtext)
end if


end event

event systemerror;Choose Case error.Number
        Case 220  to 229 //Session Error
                 MessageBox ("Session Error", "Number:" + String(error.Number) + "~r~nText:" + error.Text )
        Case 230  to 239 //License Error
                 MessageBox ("License Error", "Number:" + String(error.Number) + "~r~nText:" + error.Text )
        Case 240  to 249 //Token Error
                 MessageBox ("Token Error", "Number:" + String(error.Number) + "~r~nText:" + error.Text )
        Case Else
                 MessageBox ("SystemError", "Number:" + String(error.Number) + "~r~nText:" + error.Text )
End Choose

end event

