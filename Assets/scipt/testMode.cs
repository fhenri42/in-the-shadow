using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class testMode : MonoBehaviour {

	public Button lvl0;
	public Button lvl1;
	public Button lvl2;
	public Button lvlBonus;
	public Button charge;
	public Button charge1;
	public Button chargeBonus;
	public Button backMenu;
	// Use this for initialization

	void Start () {
		lvl0.onClick.AddListener(TaskOnClicklvl0);
		lvl1.onClick.AddListener(TaskOnClicklvl1);
		lvl2.onClick.AddListener(TaskOnClicklvl2);
		backMenu.onClick.AddListener(TaskOnClickbackMenu);
		lvlBonus.onClick.AddListener(TaskOnClicklvlBonus);

			lvl0.GetComponent<Image>().color = Color.green;

			lvl1.GetComponent<Image>().color = Color.green;
			charge.GetComponent<Image>().color = Color.green;
			charge1.GetComponent<Image>().color = Color.green;
			lvl2.GetComponent<Image>().color = Color.green;
			lvlBonus.GetComponent<Image>().color = Color.green;
			chargeBonus.GetComponent<Image>().color = Color.green;

	}

	// Update is called once per frame
	void Update () {

	}
	void TaskOnClicklvl0() {
		StaticClass.CrossSceneInformation = "TestMode";
		SceneManager.LoadScene("Scenes/lvl1", LoadSceneMode.Single);
	}
	void TaskOnClicklvl1() {
		StaticClass.CrossSceneInformation = "TestMode";

	SceneManager.LoadScene("Scenes/lvl0", LoadSceneMode.Single);
	}
	void TaskOnClicklvl2() {
		StaticClass.CrossSceneInformation = "TestMode";

		SceneManager.LoadScene("Scenes/lvl3", LoadSceneMode.Single);
	}
	void TaskOnClickbackMenu() {
		StaticClass.CrossSceneInformation = "TestMode";

		 SceneManager.LoadScene("Scenes/menu", LoadSceneMode.Single);
	}

	void TaskOnClicklvlBonus() {
		StaticClass.CrossSceneInformation = "TestMode";
			SceneManager.LoadScene("Scenes/lvlBonus", LoadSceneMode.Single);
	}
}
