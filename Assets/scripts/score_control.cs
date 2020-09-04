using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class score_control : MonoBehaviour
{
    public bool scored;
    public int lscore;
    public int rscore;
    public string player = "";

    // Start is called before the first frame update
    void Start()
    {
        lscore = 0;
        rscore = 0;
        scored = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (scored)
        {
            Debug.Log(player + " scored!" + " The current score is " + lscore + " to " + rscore);

            if ((lscore > 10) ^ (rscore > 10))
            {
                Debug.Log("Game Over! " + player + " wins!  Final score: " + lscore + " - " + rscore);
                lscore = 0;
                rscore = 0;
            }

            scored = false;
        }
    }
}
