using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goals : MonoBehaviour
{
    public bool left;
    public GameObject score_manager;
    score_control scores;

    // Start is called before the first frame update
    void Start()
    {
        scores = score_manager.GetComponent<score_control>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider coll)
    {
        if (left)
        {
            scores.rscore++;
            scores.scored = true;
            scores.player = "Right Player";
        }
        else
        {
            scores.lscore++;
            scores.scored = true;
            scores.player = "Left Player";
        }
    }
}
