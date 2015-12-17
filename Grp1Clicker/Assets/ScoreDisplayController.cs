using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreDisplayController : MonoBehaviour
{

    private Text score;

    // Use this for initialization
    void Start()
    {

        score = GetComponent<Text>();
        score.text = DataStorage.clicks.ToString();

    }

    // Update is called once per frame
    void Update()
    {

    }
}
