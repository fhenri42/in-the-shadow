using UnityEngine;
using System.Collections;
using UnityEngine.UI;

// using UnityEngine.SceneManagement;


public class testMode : MonoBehaviour {

	public Button lvl0;
	public Button lvl1;
	public Button lvl2;
	// Use this for initialization
	
	void Start () {
		lvl0.onClick.AddListener(TaskOnClicklvl0);
		lvl1.onClick.AddListener(TaskOnClicklvl1);
		lvl2.onClick.AddListener(TaskOnClicklvl2);
	}

	// Update is called once per frame
	void Update () {

	}
	void TaskOnClicklvl0() {
		// SceneManager.LoadScene("Scenes/lvl1", LoadSceneMode.Single);
	}
	void TaskOnClicklvl1() {
		// SceneManager.LoadScene("Scenes/lvl0", LoadSceneMode.Single);
	}
	void TaskOnClicklvl2() {
		// SceneManager.LoadScene("Scenes/lvl2", LoadSceneMode.Single);
	}
}
