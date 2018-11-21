using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class MoveToGarden : MonoBehaviour {

	public CameraMover MyCameraMover;
	void OnMouseDown(){
		// Move to the location
		this.MyCameraMover.StartCoroutine(this.MyCameraMover.MoveToPosition(2, 1f));
		Debug.Log("Start");
		// Add another Coroutine
		// Go into the detail scene after the camera has finished the movement
		DoLast();
 	}	
	 void DoLast()
	 {
		 Debug.Log("DoLast");
		 // SceneManager.LoadScene("Detail");
	 }
}
