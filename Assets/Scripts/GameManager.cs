using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
    public Text vScoreText;
    public PlayerMovement vPlayerMovement;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (PlayerPrefs.GetInt("isover") == 1)
        {
            mUpdateScore();
        }
	}
    void mUpdateScore()
    {
      vScoreText.text="Your Score : "+vPlayerMovement.mgetScore();
    }
}
