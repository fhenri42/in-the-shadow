using UnityEngine;
using System.Collections;
using UnityEngine.UI;
 // using UnityEngine.SceneManagement;


public class menu : MonoBehaviour {

	public Button clasiqueMode;
	public Button testMode;
	public Button resetGame;

	// Use this for initialization
	void Start () {
		clasiqueMode.onClick.AddListener(TaskOnClick);
		testMode.onClick.AddListener(TaskOnClickTest);
		resetGame.onClick.AddListener(TaskOnClickReset);

	}

	// Update is called once per frame
	void Update () {
	}
	void TaskOnClick() {
		// SceneManager.LoadScene("Scenes/clasiqueMode", LoadSceneMode.Single);

		print("MDDDr");
	}
	void TaskOnClickTest() {
	 // SceneManager.LoadScene("Scenes/testMode", LoadSceneMode.Single);
		print("MDDDr");
	}
	void TaskOnClickReset() {
		print("ici");
		PlayerPrefs.DeleteAll();

	}
}
