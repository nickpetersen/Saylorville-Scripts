using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class MyGUI : MonoBehaviour 
{
	public CameraMover MyCameraMover;

	public Button m_YourFirstButton, m_YourSecondButton, m_YourThirdButton;
	void Start()
	{
		m_YourFirstButton.onClick.AddListener(TaskOnClick);
		m_YourSecondButton.onClick.AddListener(TaskOnClick);
		m_YourThirdButton.onClick.AddListener(TaskOnClick);
	}

	void OnMouseClick(){
		this.MyCameraMover.StartCoroutine(this.MyCameraMover.MoveToPosition(1, 1f));
 	}	

	void TaskOnClick()
    {
			Debug.Log("Your First Button");
    }

	// Old code
	void OnGUI()
	{
		if (GUILayout.Button("Move to 0"))
		{
			this.MyCameraMover.StartCoroutine(this.MyCameraMover.MoveToPosition(0, 1f));
		}
		if (GUILayout.Button("Move to 1"))
		{
			this.MyCameraMover.StartCoroutine(this.MyCameraMover.MoveToPosition(1, 1f));
		}
		if (GUILayout.Button("Move to 2"))
		{
			this.MyCameraMover.StartCoroutine(this.MyCameraMover.MoveToPosition(2, 1f));
		}
	}
}
