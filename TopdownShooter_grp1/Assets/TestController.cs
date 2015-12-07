using UnityEngine;
using System.Collections;

public class TestController : MonoBehaviour {

    public AudioClip[] sounds;
    public AudioSource aSource;

    bool mustReleaseFire = false;

	// Use this for initialization
	void Start () {
        aSource = this.GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
        float fireButtonPressed = Input.GetAxisRaw("Fire1");

        if (fireButtonPressed > 0 && !mustReleaseFire)
        {
            aSource.PlayOneShot(sounds[0]);
            mustReleaseFire = true;
        }

        if (fireButtonPressed == 0 && mustReleaseFire)
        {
            mustReleaseFire = false;
        }

	}
}
