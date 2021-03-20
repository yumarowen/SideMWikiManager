extends Control


var CardMaker = 'res://CardMaker/CardMaker.tscn'
var CSTMaker = 'res://CSTMaker/CSTMaker.tscn'
var EventMaker = 'res://EventMaker/EventMaker.tscn'


# Called when the node enters the scene tree for the first time.
func _ready():
	pass # Replace with function body.


# Called every frame. 'delta' is the elapsed time since the previous frame.
#func _process(delta):
#	pass


func _on_EventMaker_Pressed():
	get_tree().change_scene(EventMaker)


func _on_CardMaker_pressed():
	get_tree().change_scene(CardMaker)


func _on_CSTMaker_pressed():
	get_tree().change_scene(CSTMaker)
