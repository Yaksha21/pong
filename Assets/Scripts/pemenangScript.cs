using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class pemenangScript : MonoBehaviour
{
    public TextMeshProUGUI win;
    

    // Start is called before the first frame update
    void Start()
    {
        if(scoringScript.score1 > scoringScript.score2)
        {
            win.text = "Player 2 Win!";
        }
        else if(scoringScript.score1 < scoringScript.score2)
        {
            win.text = "Player 2 Win!";
        }
        else
        {
            win.text = "Draw!";
        }
    }

}
