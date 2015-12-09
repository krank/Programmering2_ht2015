using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ClickController : MonoBehaviour
{

    public Text clicks;
    public Text countDown;

    public float timer = 10;

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
        DataManager.clicks += 1;
        clicks.text = DataManager.clicks.ToString();
    }
}
