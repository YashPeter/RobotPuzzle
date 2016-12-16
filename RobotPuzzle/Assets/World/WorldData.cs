using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class WorldData {
    int currentplayer;
    Player[] playables;
    Action<int, int, int, int> upf;
    Action<int, float, float, int> upp;

    public WorldData(Action<int, int, int, int> upf, Action<int, float, float, int> upp) {
        playables = new Player[6];
        currentplayer = 1;
        this.upf = upf;
        this.upp = upp;

	}


    public void AddPlayer()
    {
        playables[currentplayer - 1] = new Player(0, 0, 5, currentplayer,upf,upp);

    }

	
	
}
