using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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
  public GameObject result;


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
    if (nameLvl == "lvl0" && "good" == PlayerPrefs.GetString("lvl1", "bad")) { SceneManager.LoadScene("Scenes/lvl0", LoadSceneMode.Single); }
    if (nameLvl == "lvl1" && "good" == PlayerPrefs.GetString("lvl2", "bad")) { SceneManager.LoadScene("Scenes/lvl3", LoadSceneMode.Single); }
    if (nameLvl == "lvl2") { SceneManager.LoadScene("Scenes/menu", LoadSceneMode.Single); }
  }
  void TaskOnClickRestart() {

    if (nameLvl == "lvl0") { SceneManager.LoadScene("Scenes/lvl1", LoadSceneMode.Single); }
    if (nameLvl == "lvl1") { SceneManager.LoadScene("Scenes/lvl0", LoadSceneMode.Single); }
    if (nameLvl == "lvl2") { SceneManager.LoadScene("Scenes/lvl3", LoadSceneMode.Single); }
  }

  void TaskOnClickHome() {
    print("ICI");
    SceneManager.LoadScene("Scenes/classiqueMode", LoadSceneMode.Single);
  }
  void Update () {

//
//       if(Input.GetKeyDown(KeyCode.Escape)) {
//         if (canMove == true) {
//           canMove = false;
//           panel.gameObject.SetActive(true);
//         } else {
//           canMove = true;
//           panel.gameObject.SetActive(false);
//         }
//       }
//     if ((nameLvl == "lvl0" || nameLvl == "lvl1") && canMove == true) {
//
//       if (nameLvl == "lvl1" && Input.GetButton("Jump") && isTraslation) {
//         float v = horizontalSpeed * Input.GetAxis("Mouse X");
//         float h = verticalSpeed * Input.GetAxis("Mouse Y");
//         test.transform.Rotate(0, 0, v);
//       }
//       if (nameLvl== "lvl1" && Input.GetButton("Fire2") && isRotaiton) {
//         float v = horizontalSpeed * Input.GetAxis("Mouse X");
//         float h = verticalSpeed * Input.GetAxis("Mouse Y");
//         test.transform.Rotate(0, h, 0);
//       }
//
//       if (nameLvl== "lvl0" && Input.GetButton("Jump") && isRotaiton) {
//         float v = horizontalSpeed * Input.GetAxis("Mouse X");
//         float h = verticalSpeed * Input.GetAxis("Mouse Y");
//         test.transform.Rotate(0, v, 0);
//       }
//       if(nameLvl == "lvl0" && test.transform.rotation.eulerAngles.y <= 360 && test.transform.rotation.eulerAngles.y >= 350) {
//         PlayerPrefs.SetString("lvl1", "good");
//         canMove = false;
//         panel.gameObject.SetActive(true);
//       }
//
//       if(nameLvl ==  "lvl1" && test.transform.rotation.eulerAngles.x >= 70 && test.transform.rotation.eulerAngles.x <= 110  &&
//       (test.transform.rotation.eulerAngles.y <= 20 || test.transform.rotation.eulerAngles.y >= 345) &&
//       (test.transform.rotation.eulerAngles.z <= 10 || test.transform.rotation.eulerAngles.z >= 350)
//       ) {
//
//         // print("x :");
//         // print(test.transform.rotation.eulerAngles.x);
//         // print("y :");
//         // print(test.transform.rotation.eulerAngles.y);
//         //  print("z :");
//         //   print(test.transform.rotation.eulerAngles.z);
//         PlayerPrefs.SetString("lvl2", "good");
//         canMove = false;
//         panel.gameObject.SetActive(true);
//       }
//     }
//     if (nameLvl == "lvl2" && canMove == true) {
//
//       if (Input.GetMouseButtonDown(0))
//       {
//         Debug.Log("Mouse is down");
//
//         RaycastHit hitInfo = new RaycastHit();
//         bool hit = Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo);
//         if (hit)
//         {
//           Debug.Log("Hit " + hitInfo.transform.gameObject.name);
//
//           if (hitInfo.transform.gameObject.name == "logo-2")
//           {
//             tmpCurrent = test1;
//             } else if (hitInfo.transform.gameObject.name == "logo-4") {
//               tmpCurrent = test;
//             }
//           }
//         }
//         if (Input.GetButton("Fire1") && isMove && tmpCurrent != null) {
//           float v = 0.07F * Input.GetAxis("Mouse X") * -1;
//           float h = 0.07F * Input.GetAxis("Mouse Y");
//           tmpCurrent.transform.Translate(v, h, 0);
//
//         }
//         if (Input.GetButton("Jump") && isTraslation && tmpCurrent != null) {
//           float v = horizontalSpeed * Input.GetAxis("Mouse X");
//           float h = verticalSpeed * Input.GetAxis("Mouse Y");
//           tmpCurrent.transform.Rotate(0, v, 0);
//         }
//         if (Input.GetButton("Fire2") && isRotaiton && tmpCurrent != null) {
//           float v = horizontalSpeed * Input.GetAxis("Mouse X");
//           float h = verticalSpeed * Input.GetAxis("Mouse Y");
//           tmpCurrent.transform.Rotate(0, 0, h);
//         }
//         /* THE 2 */
//         if ((test1.transform.rotation.eulerAngles.y <= 10 || test1.transform.rotation.eulerAngles.y >= 350)
//         && (test1.transform.rotation.eulerAngles.x <= 10 || test1.transform.rotation.eulerAngles.x >= 350)
//         && (test1.transform.rotation.eulerAngles.z <= 10 || test1.transform.rotation.eulerAngles.z >= 350)) {
//           /* THE 4 */
//
//           if ((test.transform.rotation.eulerAngles.y <= 10 || test.transform.rotation.eulerAngles.y >= 350)
//           && (test.transform.rotation.eulerAngles.x <= 10 || test.transform.rotation.eulerAngles.x >= 350)
//           && (test.transform.rotation.eulerAngles.z <= 10 || test.transform.rotation.eulerAngles.z >= 350)) {
//
// /* SEE if At the RIGHT PLACE*/
//             if (test.transform.position.x  - 1  >= test1.transform.position.x &&
//                (test.transform.position.y <= test1.transform.position.y + 0.5 &&  test.transform.position.y >= test1.transform.position.y - 0.5)
//                 ) {
//               PlayerPrefs.SetString("lvl2", "good");
//               canMove = false;
//               panel.gameObject.SetActive(true);
//
//             }
//          }
//         }
//       }
    }
  }
