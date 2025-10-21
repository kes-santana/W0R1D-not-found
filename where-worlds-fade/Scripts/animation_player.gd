extends AnimationPlayer

@onready var animation_player = $"."

func _ready() -> void:
	animation_player.play("jump")
