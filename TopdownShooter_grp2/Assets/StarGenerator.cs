using UnityEngine;
using System.Collections;

public class StarGenerator : MonoBehaviour
{

    public GameObject star;

    // Use this for initialization
    void Start()
    {
        for (int i = 0; i < 100; i++)
        {
            Instantiate(star);
        }
    }

}
