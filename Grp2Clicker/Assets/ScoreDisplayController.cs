using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreDisplayController : MonoBehaviour {

    public Text scoreDisplay;

	// Use this for initialization
	void Start () {
        scoreDisplay.text = DataManager.clicks.ToString();
	}
	
}
