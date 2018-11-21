using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MoveTo : MonoBehaviour {

	public CameraMover MyCameraMover;
	void OnMouseDown(){
		this.MyCameraMover.StartCoroutine(this.MyCameraMover.MoveToPosition(1, 1f));
 	}	
}
