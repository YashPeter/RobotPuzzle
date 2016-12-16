using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PlayerDisplay: MonoBehaviour{
	public Sprite frame1;
	public Sprite frame2;
	public Sprite frame3;
	public Sprite frame4;
	public GameObject playerx;
	public SpriteRenderer spriteR;


	void Start(){
		playerx = new GameObject ();

		SpriteRenderer tempx = playerx.AddComponent<SpriteRenderer> ();
		spriteR = playerx.GetComponent<SpriteRenderer> ();
		spriteR.sprite = frame1;
		playerx.transform.position = new Vector2 (0,0);
		Debug.Log ("test");
	}

	public void updateFrame(int frame){
		switch (frame) {
		case 0:
			spriteR.sprite = frame1;   
			break;
		case 1:
			spriteR.sprite = frame2;   
			break;
		case 2:
			spriteR.sprite = frame3;   
			break;
		case 3:
			spriteR.sprite = frame4;   
			break;
		}
	}

	public void move(float x, float y){
		playerx.transform.position = new Vector2 (x,y);
	}


	




}
