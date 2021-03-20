extends Node

signal ButtonPressed(Name, IdolNumber)
signal ChangeIdolNumber(number)
# Declare member variables here. Examples:
# var a = 2
# var b = "text"

#CardMakerSwitch
var CardJPN
var CardENG
var CardDescJPN
var CardDescENG
var CardCost
var SkillENG
var SkillJPN
var SkillEffJPN
var SkillEffENG
var Note1
var Note2
var Note3
var Note4
var Note5

# Called when the node enters the scene tree for the first time.
func _ready():
	OS.center_window()


# Called every frame. 'delta' is the elapsed time since the previous frame.
#func _process(delta):
#	pass
