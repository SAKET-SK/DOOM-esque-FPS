using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour {

    void Awake()
    {
        // To show cursor after First Person Controller
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    public void OnPlay () {
		SceneManager.LoadScene ("Level1");
	}
}
