using UnityEngine;
using System.Collections;

public class StarGenerator : MonoBehaviour {

    public GameObject starPrefab;

	// Use this for initialization
	void Start () {
	
        for (var i=0; i<100; i++)
        {
            Instantiate(starPrefab);
        }


	}
	
}
