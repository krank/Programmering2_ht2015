using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameManagerController : MonoBehaviour
{

    public Text clicks;
    public Text countDown;

    public float timer = 10f;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        countDown.text = timer.ToString();

        if (timer < 0)
        {
            Application.LoadLevel("Score");
        }
    }

    public void AddClick()
    {
        DataStorage.clicks++;

        clicks.text = DataStorage.clicks.ToString();

    }
}
