using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class clasiqueMode : MonoBehaviour {

	public Button lvl0;
	public Button lvl1;
	public Button lvl2;
	public Button lvlBonus;
	public Button charge;
	public Button charge1;
	public Button chargeBonus;
	public Button backMenu;

	void Start () {
		lvl0.onClick.AddListener(TaskOnClicklvl0);
		lvl1.onClick.AddListener(TaskOnClicklvl1);
		lvl2.onClick.AddListener(TaskOnClicklvl2);
		lvlBonus.onClick.AddListener(TaskOnClicklvlBonus);
		backMenu.onClick.AddListener(TaskOnClickbackMenu);

		lvl0.GetComponent<Image>().color = Color.green;
		if ("good" == PlayerPrefs.GetString("lvl1", "bad")) {
			lvl1.GetComponent<Image>().color = Color.green;
			charge.GetComponent<Image>().color = Color.green;
		} else {
			lvl1.GetComponent<Image>().color = Color.red;
			lvl1.GetComponent<Button>().interactable = false;
		}

		if ("good" == PlayerPrefs.GetString("lvl2", "bad")) {
			charge1.GetComponent<Image>().color = Color.green;
			lvl2.GetComponent<Image>().color = Color.green;
		} else {
			lvl2.GetComponent<Image>().color = Color.red;
			lvl2.GetComponent<Button>().interactable = false;
		}

		if ("good" == PlayerPrefs.GetString("lvlBonus", "bad")) {
			chargeBonus.GetComponent<Image>().color = Color.green;
			lvlBonus.GetComponent<Image>().color = Color.green;
		} else {
			lvlBonus.GetComponent<Image>().color = Color.red;
			lvlBonus.GetComponent<Button>().interactable = false;
		}
	}

	void Update () { }

	void TaskOnClicklvl0() {
		print("ICIC");
		SceneManager.LoadScene("Scenes/lvl1", LoadSceneMode.Single);
	}
	void TaskOnClicklvl1() {
		string goodtogo = PlayerPrefs.GetString("lvl1", "bad");
		if (goodtogo == "good") {
			print("yes all good");
			SceneManager.LoadScene("Scenes/lvl0", LoadSceneMode.Single);
		}
	}
	void TaskOnClicklvl2() {
		string goodtogo = PlayerPrefs.GetString("lvl2", "bad");
		if (goodtogo == "good") {
			SceneManager.LoadScene("Scenes/lvl3", LoadSceneMode.Single);
		}
	}
	void TaskOnClicklvlBonus() {
		string goodtogo = PlayerPrefs.GetString("lvlBonus", "bad");
		if (goodtogo == "good") {
			SceneManager.LoadScene("Scenes/lvlBonus", LoadSceneMode.Single);
		}
	}
	void TaskOnClickbackMenu() {
		SceneManager.LoadScene("Scenes/menu", LoadSceneMode.Single);
	}
}
