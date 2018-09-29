using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public static class StaticClass {
  public static string CrossSceneInformation { get; set; }
}
public class move : MonoBehaviour {
  /* TODO
  1) finir 1 lvl
  4) faire 3 lvl de difficulter
  2) faire le Menu (prendre le menu de hotlineMiami le ruch)
  3) faire les 2 mode
  5) Rendre
  */
  public string nameLvl;
  public GameObject test;
  public GameObject test1;
  public GameObject tmpCurrent;
  public GameObject panel;
  //public GameObject result;


  public Button nextGame;
  public Button restartGame;
  public Button backMenu;

  public bool isRotaiton;
  public bool isTraslation;
  public bool isMove;
  public bool isSelcet;
  public float horizontalSpeed;
  public float verticalSpeed;
  private bool canMove;

  // Use this for initialization
  void Start () {
    nextGame.onClick.AddListener(TaskOnClickNext);
    restartGame.onClick.AddListener(TaskOnClickRestart);
    backMenu.onClick.AddListener(TaskOnClickHome);
    panel.gameObject.SetActive(false);
    canMove = true;
  }

  void TaskOnClickNext() {
    if (nameLvl == "lvl0" && "good" == PlayerPrefs.GetString("lvl1", "bad")) { 			StaticClass.CrossSceneInformation = "claMode"; SceneManager.LoadScene("Scenes/lvl0", LoadSceneMode.Single); }
    if (nameLvl == "lvl1" && "good" == PlayerPrefs.GetString("lvl2", "bad")) { 			StaticClass.CrossSceneInformation = "claMode"; SceneManager.LoadScene("Scenes/lvl3", LoadSceneMode.Single); }
    if (nameLvl == "lvl2"  && "good" == PlayerPrefs.GetString("lvlBonus", "bad")) { 			StaticClass.CrossSceneInformation = "claMode"; SceneManager.LoadScene("Scenes/lvlBonus", LoadSceneMode.Single); }
    if (nameLvl == "lvlBonus") { 			StaticClass.CrossSceneInformation = "claMode"; SceneManager.LoadScene("Scenes/menu", LoadSceneMode.Single); }
  }
  void TaskOnClickRestart() {

    if (nameLvl == "lvl0") { 			StaticClass.CrossSceneInformation = "claMode"; SceneManager.LoadScene("Scenes/lvl1", LoadSceneMode.Single); }
    if (nameLvl == "lvl1") { 			StaticClass.CrossSceneInformation = "claMode"; SceneManager.LoadScene("Scenes/lvl0", LoadSceneMode.Single); }
    if (nameLvl == "lvl2") { 			StaticClass.CrossSceneInformation = "claMode"; SceneManager.LoadScene("Scenes/lvl3", LoadSceneMode.Single); }
    if (nameLvl == "lvlBonus") { 			StaticClass.CrossSceneInformation = "claMode"; SceneManager.LoadScene("Scenes/lvlBonus", LoadSceneMode.Single); }
  }

  void TaskOnClickHome() {
    if(StaticClass.CrossSceneInformation =="TestMode") {
      SceneManager.LoadScene("Scenes/testMode", LoadSceneMode.Single);

    } else {
      SceneManager.LoadScene("Scenes/classiqueMode", LoadSceneMode.Single);
    }
  }

  void Update () {

    if(Input.GetKeyDown(KeyCode.Escape)) {
      if (canMove == true) {
        canMove = false;
        panel.gameObject.SetActive(true);
      } else {
        canMove = true;
        panel.gameObject.SetActive(false);
      }
    }
    if ((nameLvl == "lvl0" || nameLvl == "lvl1") && canMove == true) {

      if (nameLvl == "lvl1" && Input.GetButton("Jump") && isTraslation) {
        float v = horizontalSpeed * Input.GetAxis("Mouse X");
        float h = verticalSpeed * Input.GetAxis("Mouse Y");
        test.transform.Rotate(0, 0, v);
      }
      if (nameLvl== "lvl1" && Input.GetButton("Fire2") && isRotaiton) {
        float v = horizontalSpeed * Input.GetAxis("Mouse X");
        float h = verticalSpeed * Input.GetAxis("Mouse Y");
        test.transform.Rotate(0, h, 0);
      }

      if (nameLvl== "lvl0" && Input.GetButton("Jump") && isRotaiton) {
        float v = horizontalSpeed * Input.GetAxis("Mouse X");
        float h = verticalSpeed * Input.GetAxis("Mouse Y");
        test.transform.Rotate(0, v, 0);
      }
      if (nameLvl == "lvl0" && test.transform.rotation.eulerAngles.y <= 360 && test.transform.rotation.eulerAngles.y >= 350) {
        if (StaticClass.CrossSceneInformation != "TestMode") { PlayerPrefs.SetString("lvl1", "good"); }
        canMove = false;
        panel.gameObject.SetActive(true);
      }

      float tmpx = test.transform.eulerAngles.x;
      float tmpy = test.transform.eulerAngles.y;
      float tmpz = test.transform.eulerAngles.z;
      if (tmpx < 0) { tmpx = 360 - tmpx; }
      if (tmpy < 0) { tmpy = 360 - tmpy; }
      if (tmpy < 0) { tmpy = 360 - tmpy; }
      if (nameLvl ==  "lvl1" && tmpx >= 70 && tmpx <= 110  && (tmpy <= 20 || tmpy >= 345) && (tmpz <= 10 || tmpz >= 350)) {
        if (StaticClass.CrossSceneInformation != "TestMode") { PlayerPrefs.SetString("lvl2", "good"); }
        canMove = false;
        panel.gameObject.SetActive(true);
      }

      if (nameLvl ==  "lvl1" && tmpx >= 70 && tmpx <= 110  && (tmpy >= 0  && tmpy <= 60) && (tmpz >= 50 && tmpz <= 70)) {
        if(StaticClass.CrossSceneInformation !="TestMode") { PlayerPrefs.SetString("lvl2", "good"); }
        canMove = false;
        panel.gameObject.SetActive(true);
      }
    }
    if (nameLvl == "lvl2" && canMove == true) {

      if (Input.GetMouseButtonDown(0))
      {
        Debug.Log("Mouse is down");

        RaycastHit hitInfo = new RaycastHit();
        bool hit = Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo);
        if (hit)
        {
          Debug.Log("Hit " + hitInfo.transform.gameObject.name);

          if (hitInfo.transform.gameObject.name == "logo-2")
          {
            tmpCurrent = test1;
            } else if (hitInfo.transform.gameObject.name == "logo-4") {
              tmpCurrent = test;
            }
          }
        }
        if (Input.GetButton("Fire1") && isMove && tmpCurrent != null) {
          float v = 0.07F * Input.GetAxis("Mouse X") * -1;
          float h = 0.07F * Input.GetAxis("Mouse Y");
          tmpCurrent.transform.Translate(v, h, 0);

        }
        if (Input.GetButton("Jump") && isTraslation && tmpCurrent != null) {
          float v = horizontalSpeed * Input.GetAxis("Mouse X");
          float h = verticalSpeed * Input.GetAxis("Mouse Y");
          tmpCurrent.transform.Rotate(0, v, 0);
        }
        if (Input.GetButton("Fire2") && isRotaiton && tmpCurrent != null) {
          float v = horizontalSpeed * Input.GetAxis("Mouse X");
          float h = verticalSpeed * Input.GetAxis("Mouse Y");
          tmpCurrent.transform.Rotate(0, 0, h);
        }
        /* THE 2 */

        /*MAKE SOMME TMP */
        float tmpx = test.transform.eulerAngles.x;
        float tmpy = test.transform.eulerAngles.y;
        float tmpz = test.transform.eulerAngles.z;
        float tmpx1 = test1.transform.eulerAngles.x;
        float tmpy1 = test1.transform.eulerAngles.y;
        float tmpz1 = test1.transform.eulerAngles.z;
        if (tmpx < 0) { tmpx = 360 - tmpx; }
        if (tmpy < 0) { tmpy = 360 - tmpy; }
        if (tmpy < 0) { tmpy = 360 - tmpy; }
        if (tmpx1 < 0) { tmpx1 = 360 - tmpx1; }
        if (tmpy1 < 0) { tmpy1 = 360 - tmpy1; }
        if (tmpz1 < 0) { tmpz1 = 360 - tmpz1; }


        if (((tmpx1 <= 10 || tmpx1 >= 350) && (tmpy1 <= 10 || tmpy1 >= 350) && (tmpz1 <= 10 || tmpz1 >= 350)) || ((tmpx1 <= 10 || tmpx1 >= 350) && (tmpy1 <= 10 || tmpy1 >= 350) && (tmpz1 <= 190 && tmpz1 <= 200))) {

          /* THE 4 */

          if ((tmpy <= 10 || tmpy >= 350) && (tmpx <= 10 || tmpx >= 350) && (tmpz <= 10 || tmpz >= 350)) {
            /* SEE if At the RIGHT PLACE*/
            if (test.transform.position.x  - 1  >= test1.transform.position.x && (test.transform.position.y <= test1.transform.position.y + 0.5 &&  test.transform.position.y >= test1.transform.position.y - 0.5) ) {
              if(StaticClass.CrossSceneInformation !="TestMode") { PlayerPrefs.SetString("lvl2", "good"); }
                canMove = false;
                panel.gameObject.SetActive(true);

              }
            }
          }
        }
        if (nameLvl == "lvlBonus" && canMove == true) {

          if (Input.GetMouseButtonDown(0))
          {
            Debug.Log("Mouse is down");

            RaycastHit hitInfo = new RaycastHit();
            bool hit = Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo);
            if (hit)
            {
              Debug.Log("Hit " + hitInfo.transform.gameObject.name);
              if (hitInfo.transform.gameObject.name == "globe_earth") { tmpCurrent = test1; } else if (hitInfo.transform.gameObject.name == "globe_base") {tmpCurrent = test; }
            }
          }

          if (Input.GetButton("Fire1") && isMove && tmpCurrent != null) {
            float v = 0.07F * Input.GetAxis("Mouse X") * -1;
            float h = 0.07F * Input.GetAxis("Mouse Y");
            tmpCurrent.transform.Translate(v, h, 0);
          }
          if (Input.GetButton("Jump") && isTraslation && tmpCurrent != null) {
            float v = horizontalSpeed * Input.GetAxis("Mouse X");
            float h = verticalSpeed * Input.GetAxis("Mouse Y");
            tmpCurrent.transform.Rotate(0, v, 0);
          }
          if (Input.GetButton("Fire2") && isRotaiton && tmpCurrent != null) {
            float v = horizontalSpeed * Input.GetAxis("Mouse X");
            float h = verticalSpeed * Input.GetAxis("Mouse Y");
            tmpCurrent.transform.Rotate(0, 0, h);
          }

              if ((test.transform.position.y <= test1.transform.position.y + 0.5 &&  test.transform.position.y >= test1.transform.position.y - 0.5) && (test.transform.position.x >= test1.transform.position.x + 3  && test.transform.position.x <= test1.transform.position.x - 3)) {
                // PlayerPrefs.SetString("lvlBonus", "good");
                // canMove = false;
                // panel.gameObject.SetActive(true);
                print("ICI");
              }
        }
      }
    }
