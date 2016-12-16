using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Player{
    //inciating positions, direct, frame and limit frame, type of player for referencing sprites//
	float posx;
	float posy;
	int direction;
	int frame;
	int framelimit;
    int pt;
    playernum type;

    // enum //
    public enum playernum {Player1, Player2, Player3, Player4, Player5, Player6 };

    //actions//
    Action<int, int, int, int> upf;
    Action<int, float, float, int> upp;


    //constructor//
    public Player(float posx, float posy, int framelimit, int pt, Action<int, int, int, int> upf, Action<int, float, float, int> upp)
    {
		this.posx = posx;
		this.posy = posy;
		direction = 0;
		frame = 1;
		this.framelimit = frame;
        this.upf = upf;
        this.upp = upp;
        this.pt = pt;
		Debug.Log ("player inicilized");
		this.iniciate ();
       


        //switch case to set enum type//
        switch (pt)
        {
            case 1:
                type = playernum.Player1;
                break;
            case 2:
                type = playernum.Player2;
                break;
            case 3:
                type = playernum.Player3;
                break;
            case 4:
                type = playernum.Player4;
                break;
            case 5:
                type = playernum.Player5;
                break;
            case 6:
                type = playernum.Player6;
                break;
        }
	}
	public float getposx(){
		return posx;
	}

	public float getposy(){
		return posy;
	}

	public float getdirection(){
		return direction;
	}

	public float getframe(){
		return frame;
	}

	public void iniciate(){
		upf(pt - 1, frame, direction, pt);
		upp(pt - 1, posx, posy, pt);
	}

    //moves the player depending on their direction//
	public void move(){
		switch (direction) {
		case 0:
			posy -= 1;
			updateframe ();
		break;	
		case 1:
			posx += 1;
			updateframe ();
			break;	
		case 2:
			posy += 1;
			updateframe ();
			break;	
		case 3:
			posx -= 1;
			updateframe ();
			break;	
		}
	}

	public void updateframe(){
		if (frame == framelimit) {
			frame = 1;
            upf(pt- 1, frame, direction, pt);
            upp(pt - 1, posx, posy, pt);
		} else {
			frame += 1;
            upf(pt - 1, frame, direction, pt);
            upp(pt - 1, posx, posy, pt);
        }
	}

	public void setdirection(int direction){
		this.direction = direction;
	}
}
