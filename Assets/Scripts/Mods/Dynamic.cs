using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dynamic : MonoBehaviour 
{
    private int time;
    private float counter;
    private string[] games;
    private Text seconds, game;
	void Start () 
    {
        games = new string[6];
        games[0] = "RPG";
        games[1] = "FPS";
        games[2] = "Puzzle";
        games[3] = "Simulation";
        games[4] = "Platform";
        games[5] = "Board Game";
        time = Random.Range(60, 300);
        game = GameObject.Find("Game").GetComponent<Text>();
        game.text = games[Random.Range(0, 6)];
        seconds = GameObject.Find("Seconds").GetComponent<Text>();
    }
	
	void Update () 
    {
        if (time == 0)
        {
            game.text = games[Random.Range(0, 6)];
            time = Random.Range(60, 300);
        }
        if (time > 1)
        {
            seconds.text = time + " segundos";
        }
        else
        {
            seconds.text = time + " segundo";
        }
        if (counter > 1)
        {
            time -= 1;
            counter = 0;
        }
        else
        {
            counter += Time.deltaTime;
        }
	}
}
