using UnityEngine;
using System.Collections;
using UnityEngine.UI;

// using UnityEngine.SceneManagement;


public class clasiqueMode : MonoBehaviour {

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
		print("ICIC");
		// SceneManager.LoadScene("Scenes/lvl1", LoadSceneMode.Single);
	}
	void TaskOnClicklvl1() {
		string goodtogo = PlayerPrefs.GetString("lvl1", "bad");
		if (goodtogo == "good") {
			//LoadScene
			print("yes all good");
		}
		print(goodtogo);
		// SceneManager.LoadScene("Scenes/lvl0", LoadSceneMode.Single);
	}
	void TaskOnClicklvl2() {
		string goodtogo = PlayerPrefs.GetString("lvl2", "bad");
		if (goodtogo == "good") {
			//LoadScene
		}
		// SceneManager.LoadScene("Scenes/lvl2", LoadSceneMode.Single);
	}
}
