﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
//controls the visuals of the player only//
public class PlayerController : MonoBehaviour
{
    //Importing Sprites into the main class
    public Sprite p1l1;
    public Sprite p1l2;
    public Sprite p1l3;
    public Sprite p1l4;
    public Sprite p1l5;

    public Sprite p1r1;
    public Sprite p1r2;
    public Sprite p1r3;
    public Sprite p1r4;
    public Sprite p1r5;

    public Sprite p1u1;
    public Sprite p1u2;
    public Sprite p1u3;
    public Sprite p1u4;
    public Sprite p1u5;

    public Sprite p1d1;
    public Sprite p1d2;
    public Sprite p1d3;
    public Sprite p1d4;
    public Sprite p1d5;
    // Use this for initialization

    public static PlayerController Instance { get; protected set; }

    public Action<int, int, int, int> upf;
    public Action<int, float, float, int> upp;
	GameObject[] playerdisplay;
	SpriteRenderer[] playersprite;

    void Start()
	{   Debug.Log ("playercontroller started");
		playerdisplay = new GameObject[6];
		playersprite = new SpriteRenderer[6];
        Instance = this;
        upf = changeGivenPlayerFrame;
        upp = translateGivenPlayerFrame;
        //return WorldController.Instance.World.*insertmethod*
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Action<int, int, int, int> returnUPF()
    {
        return upf;
    }

    public Action<int, float, float, int> returnUPP()
    {
        return upp;
    }

    public void changeGivenPlayerFrame(int arraypos, int frame, int direction, int currplay)
    {
		Debug.Log("upf");
		if (playerdisplay [arraypos] == null) {
			playerdisplay [arraypos] = new GameObject ();
			playerdisplay [arraypos].AddComponent<SpriteRenderer> ();
			playersprite [arraypos] = new SpriteRenderer ();
			playersprite [arraypos] = playerdisplay [arraypos].GetComponent<SpriteRenderer> ();
		}
		switch (frame) {
		case 1:
			switch (direction) {
			case 0:
				playersprite [arraypos].sprite = p1d1;
				break;

			case 1:
				playersprite [arraypos].sprite = p1r2;
				break;

			case 2:
				playersprite [arraypos].sprite = p1u3;
				break;

			case 3:
				playersprite [arraypos].sprite = p1l4;
				break;

			}

			break;

		case 2:
			switch (direction) {
			case 0:
				playersprite [arraypos].sprite = p1d2;
				break;

			case 1:
				playersprite [arraypos].sprite = p1r2;
				break;

			case 2:
				playersprite [arraypos].sprite = p1u2;
				break;

			case 3:
				playersprite [arraypos].sprite = p1l2;
				break;

			}
			break;

		case 3:
			switch (direction) {
			case 0:
				playersprite [arraypos].sprite = p1d3;
				break;

			case 1:
				playersprite [arraypos].sprite = p1r3;
				break;

			case 2:
				playersprite [arraypos].sprite = p1u3;
				break;

			case 3:
				playersprite [arraypos].sprite = p1l3;
				break;

			}
			break;

		case 4:
			switch (direction) {
			case 0:
				playersprite [arraypos].sprite = p1d4;
				break;

			case 1:
				playersprite [arraypos].sprite = p1r4;
				break;

			case 2:
				playersprite [arraypos].sprite = p1u4;
				break;

			case 3:
				playersprite [arraypos].sprite = p1l4;
				break;

			}
			break;

		case 5:
			switch (direction) {
			case 0:
				playersprite [arraypos].sprite = p1d5;
				break;

			case 1:
				playersprite [arraypos].sprite = p1r5;
				break;

			case 2:
				playersprite [arraypos].sprite = p1u5;
				break;

			case 3:
				playersprite [arraypos].sprite = p1l5;
				break;

			}
			break;
		}
    }

    public void translateGivenPlayerFrame(int arraypos, float x, float y, int currplay)
    {
		Debug.Log(y);
		playerdisplay [arraypos].transform.position = new Vector3 (x, y, 0);

    }
}