using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public enum MoveDirection
{
	Left, Right, Up, Down
}

public class ImputManager : MonoBehaviour 
{

	private GameManager gm;

	void Awake()
	{
		gm = GameObject.FindObjectOfType<GameManager> ();
	}

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		
		if (Input.GetKeyDown (KeyCode.RightArrow)) 
		{
			//right move
			gm.Move(MoveDirection.Right);
		}
		else if (Input.GetKeyDown (KeyCode.LeftArrow)) 
		{
			//Left move
			gm.Move(MoveDirection.Left);
		}
		else if (Input.GetKeyDown (KeyCode.UpArrow)) 
		{
			//Up move
			gm.Move(MoveDirection.Up);
		}
		else if (Input.GetKeyDown (KeyCode.DownArrow)) 
		{
			//Down move
			gm.Move(MoveDirection.Down);
		}
	}
		
}
