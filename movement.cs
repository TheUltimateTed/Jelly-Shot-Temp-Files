using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {
	
	private CharacterController player;

	public float Speed;
	
	void Start () {
		player = GetComponent<CharacterController> ();
	}
	
	void Update () {
		Vector3 Move = Vector3.zero;
		Move.x = Input.GetAxis ("Horizontal") * Speed;
		player.Move(Move * Time.deltaTime);
	}
}