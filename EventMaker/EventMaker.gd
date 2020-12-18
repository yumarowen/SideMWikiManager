extends Control

var EventTemplate =  'res://EventMaker/SideMoba Event Template.txt'
var EventTemplateFile
var EventTemplateContent
var NewEventFile

var group = ButtonGroup.new()
var IdolList = 'res://EventMaker/IdolList.txt'
var IdolListContent
var IdolListFile

var EventType
var SkipWarnings = false

var InstanceBox = preload("res://IDOL2.tscn")
var New_Box

var Idol1 = ""
var Idol2 = ""
var Idol3 = ""
var Idol4 = ""
var Idol5 = ""

onready var IDOL1EDIT = find_node("IDOL1")
onready var IDOL2EDIT = find_node("IDOL2")
onready var IDOL3EDIT = find_node("IDOL3")
onready var IDOL4EDIT = find_node("IDOL4")
onready var IDOL5EDIT = find_node("IDOL5")
onready var EventIDEdit = find_node("EventIDEdit")
onready var EventNameEdit = find_node("EventNameEdit")
onready var EventYearEdit = find_node("EventYearEdit")
onready var EventTypeEdit = find_node("EventTypeEdit")
onready var EventStartDateEdit = find_node("EventStartDateEdit")
onready var EventFinishDateEdit = find_node("EventFinishDateEdit")
onready var LogInfo = find_node("ErrorWarning")
onready var GachaNameEdit = find_node("GachaNameEdit")
onready var IdolPopUp = find_node("WindowDialog")

func _init():
	Global.connect("ButtonPressed", self, "OnUdolListButtonPress")
	
	EventTemplateFile = File.new()
	EventTemplateFile.open(EventTemplate,File.READ)
	EventTemplateContent = EventTemplateFile.get_as_text()
	
	IdolListFile = File.new()
	IdolListFile.open(IdolList,File.READ)
	IdolListContent = IdolListFile.get_as_text()

	NewEventFile = File.new()

func _ready():
	_init_EVENT_TYPE_LIST()
	_init_IDOL_LIST()

func _on_Button_pressed():
	generate_Event()

func generate_Event():
	if EventIDEdit.text.is_valid_integer():
		NewEventFile.open('res://EventMaker/Event'+EventIDEdit.text+'.txt',File.WRITE)
		replace_EVENT_ID(EventIDEdit.text)
		replace_EVENT_NAME()
		replace_EVENT_YEAR()
		replace_EVENT_START_DATE()
		replace_EVENT_FINISH_DATE()
		replace_EVENT_TYPE()
		replace_idols()
		replace_GACHA_NAME()
		NewEventFile.store_string(EventTemplateContent)
		NewEventFile.close()
		LogInfo.text = 'Event Code has been generated!'
		reset_file()
	else:
		LogInfo.text = "Event ID is invalid"

func replace_EVENT_ID(text):
		EventTemplateContent = EventTemplateContent.replace("EVENT_ID",EventIDEdit.text)

func replace_EVENT_NAME():
	if EventNameEdit.text != "":
		EventTemplateContent = EventTemplateContent.replace("EVENT_NAME",EventNameEdit.text)
		replace_EVENT_YEAR()

func replace_EVENT_YEAR():
	if EventYearEdit.text.is_valid_integer():
		EventTemplateContent = EventTemplateContent.replace("EVENT_YEAR",EventYearEdit.text)

func replace_EVENT_START_DATE():
	if EventStartDateEdit.text != "":
		EventTemplateContent = EventTemplateContent.replace("START_DATE",EventStartDateEdit.text)

func replace_EVENT_FINISH_DATE():
	if EventFinishDateEdit.text != "":
		EventTemplateContent = EventTemplateContent.replace("FINISH_DATE",EventFinishDateEdit.text)
	
func replace_EVENT_TYPE():
	match EventTypeEdit.get_selected_id():
		0:
			EventType = "L"
		1:
			EventType = "M"
		2:
			EventType = "B"
		3:
			EventType = "T"
		3:
			EventType = "LP"
		_:
			EventType = ""
			LogInfo.text = "Event Type is invalid"
	if EventType != "":
		EventTemplateContent = EventTemplateContent.replace("EVENT_TYPE",EventType)

func replace_GACHA_NAME():
	if GachaNameEdit.text != "":
		EventTemplateContent = EventTemplateContent.replace("GACHA_NAME",GachaNameEdit.text)

func _init_IDOL_LIST():
	var index = 1
	while !IdolListFile.eof_reached():
		var line = IdolListFile.get_line()
		line += ""
		New_Box = InstanceBox.instance()
		New_Box.setup(line)
		$WindowDialog/MarginContainer/ScrollContainer/VBoxContainer.add_child(New_Box)
		#.add_radio_check_item(line)

func _init_EVENT_TYPE_LIST():
	EventTypeEdit.add_item("Live")
	EventTypeEdit.add_item("Marathon")
	EventTypeEdit.add_item("Bingo")
	EventTypeEdit.add_item("Team")
	EventTypeEdit.add_item("Live Produce")

func replace_idols():
	if not Idol1 == "":
		EventTemplateContent = EventTemplateContent.replace("IDOL1","[[File:" + Idol1 + "-icon.png|50px|link="+ Idol1 + "]]")
	else:
		EventTemplateContent = EventTemplateContent.replace("IDOL1","")
	if not Idol2 == "":
		EventTemplateContent = EventTemplateContent.replace("IDOL2","[[File:" + Idol2 + "-icon.png|50px|link="+ Idol2 + "]]")
	else:
		EventTemplateContent = EventTemplateContent.replace("IDOL2","")
	if not Idol3 == "":
		EventTemplateContent = EventTemplateContent.replace("IDOL3","[[File:" + Idol3 + "-icon.png|50px|link="+ Idol3 + "]]<br>")
	else:
		EventTemplateContent = EventTemplateContent.replace("IDOL3","")
	if not Idol4 == "":
		EventTemplateContent = EventTemplateContent.replace("IDOL4","[[File:" + Idol4 + "-icon.png|50px|link="+ Idol4 + "]]")
	else:
		EventTemplateContent = EventTemplateContent.replace("IDOL4","")
	if not Idol5 == "":
		EventTemplateContent = EventTemplateContent.replace("IDOL5","[[File:" + Idol5 + "-icon.png|50px|link="+ Idol5 + "]]")
	else:
		EventTemplateContent = EventTemplateContent.replace("IDOL5","")

func OnUdolListButtonPress(Name, IdolNum):
	match IdolNum:
		1:
			Idol1 = Name
			print(Idol1)
			IDOL1EDIT.text = Name
		2:
			Idol2 = Name
			IDOL2EDIT.text = Name
		3:
			Idol3 = Name
			IDOL3EDIT.text = Name
		4:
			Idol4 = Name
			IDOL4EDIT.text = Name
		5:
			Idol5 = Name
			IDOL5EDIT.text = Name

	IdolPopUp.hide()
	pass

func _on_IDOL1_pressed():
	Global.emit_signal("ChangeIdolNumber",1)
	IdolPopUp.show()

func _on_IDOL2_pressed():
	Global.emit_signal("ChangeIdolNumber",2)
	IdolPopUp.show()


func _on_IDOL3_pressed():
	Global.emit_signal("ChangeIdolNumber",3)
	IdolPopUp.show()

func _on_IDOL4_pressed():
	Global.emit_signal("ChangeIdolNumber",4)
	IdolPopUp.show()

func _on_IDOL5_pressed():
	Global.emit_signal("ChangeIdolNumber",5)
	IdolPopUp.show()

func reset_file():
	EventTemplateContent = EventTemplateFile.get_as_text()
