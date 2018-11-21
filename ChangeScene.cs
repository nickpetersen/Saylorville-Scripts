using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ChangeScene : MonoBehaviour {

	// Update is called once per frame
	void Update () {

		// Touch doesn't work yet
		// if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
        // {
        //     SceneManager.LoadScene("Main");
        // }

		if (Input.GetMouseButtonDown(0)) SceneManager.LoadScene("Main");

	}
}
