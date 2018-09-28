using UnityEngine;
using System.Collections;

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
  public bool isRotaiton;
  public bool isTraslation;
  public bool isMove;
  public bool isSelcet;
  public float horizontalSpeed = 4.0F;
  public float verticalSpeed = 4.0F;
  // Use this for initialization
  void Start () {

  }

  // Update is called once per frame
  void Update () {

    if (nameLvl == "lvl0" || nameLvl == "lvl1") {

    if (Input.GetButton("Fire1") && isMove) {
      float v = 0.02F * Input.GetAxis("Mouse X");
      float h = 0.02F * Input.GetAxis("Mouse Y");
      test.transform.Translate(v, h, 0);

    }
    if ( nameLvl == "lvl0" && Input.GetButton("Jump") && isTraslation) {
      float v = horizontalSpeed * Input.GetAxis("Mouse X");
      float h = verticalSpeed * Input.GetAxis("Mouse Y");
      test.transform.Rotate(0, 0, h);
    }
    if ( nameLvl == "lvl1" && Input.GetButton("Jump") && isTraslation) {
      float v = horizontalSpeed * Input.GetAxis("Mouse X");
      float h = verticalSpeed * Input.GetAxis("Mouse Y");
      test.transform.Rotate(0, 0, v);
    }
    if (Input.GetButton("Fire2") && isRotaiton) {
      float v = horizontalSpeed * Input.GetAxis("Mouse X");
      float h = verticalSpeed * Input.GetAxis("Mouse Y");
      test.transform.Rotate(0, h, 0);
    }

    if(nameLvl == "lvl0" && test.transform.rotation.eulerAngles.y <= 360 && test.transform.rotation.eulerAngles.y >= 350) {
      print("VICTORI");
      PlayerPrefs.SetString("lvl1", "good");
    }

    //TODO etre plus precis
    if(nameLvl == "lvl1"
    && test.transform.rotation.eulerAngles.x <= 100 && test.transform.rotation.eulerAngles.x >= 70
    // &&  test.transform.rotation.eulerAngles.y <= 310 && test.transform.rotation.eulerAngles.y >= 290
    &&  test.transform.rotation.eulerAngles.z <= 80 && test.transform.rotation.eulerAngles.z >= 65) {
      print("VICTORI");
      PlayerPrefs.SetString("lvl2", "good");
    }
  }
     if (nameLvl == "lvl2") {

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
         float v = 0.02F * Input.GetAxis("Mouse X");
         float h = 0.02F * Input.GetAxis("Mouse Y");
         tmpCurrent.transform.Translate(v, h, 0);

       }
       if (Input.GetButton("Jump") && isTraslation && tmpCurrent != null) {
         float v = horizontalSpeed * Input.GetAxis("Mouse X");
         float h = verticalSpeed * Input.GetAxis("Mouse Y");
         tmpCurrent.transform.Rotate(0, 0, h);
       }
       if (Input.GetButton("Fire2") && isRotaiton && tmpCurrent != null) {
         float v = horizontalSpeed * Input.GetAxis("Mouse X");
         float h = verticalSpeed * Input.GetAxis("Mouse Y");
         tmpCurrent.transform.Rotate(0, h, 0);
       }
     }
  }
}
