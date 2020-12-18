extends HBoxContainer

export(String) var Name2
onready var Box = get_node("CheckBox")
var IDOL_NUM = 1

func setup(Name):
	Name2 = Name
	$CheckBox.toggle_mode = false
	$CheckBox.text = Name2
	$CheckBox.icon = load("res://EventMaker/icons/"+Name2+".png")

func change_idol_number(number):
	IDOL_NUM = number

func _ready():
	Global.connect("ChangeIdolNumber",self,"change_idol_number")

func _on_CheckBox_pressed():
	$CheckBox.pressed == false
	print(Name2)
	print(IDOL_NUM)
	Global.emit_signal("ButtonPressed", Name2, IDOL_NUM)
