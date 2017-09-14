using System.Collections;
using UnityEngine;

public class FollowPlayer : MonoBehaviour 
{
	// プレイヤーの Transform
	public Transform Player;
	private Vector3 offset;

	private void Start(){
		offset = GetComponent<Transform> ().position - Player.position;
	}

	private void Update ()
	{
		// Camera の座標に Player の座標を代入する     
		GetComponent<Transform>().position = Player.position + offset;
	}
}