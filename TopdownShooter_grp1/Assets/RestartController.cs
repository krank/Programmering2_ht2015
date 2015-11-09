using UnityEngine;
using System.Collections;

public class RestartController : MonoBehaviour {

    public void RestartScene()
    {
        Application.LoadLevel(Application.loadedLevelName);
    }
}
