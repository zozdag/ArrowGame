using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class manager : MonoBehaviour
{
    public GameObject Arrow;
    float Guc = 4000.0f;
    Transform Camera;
    public Image GucBar;
    public static int Puan = 0;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Camera = GameObject.Find("Main Camera").GetComponent<Transform>();
        GucBar = GameObject.Find("GucBar").GetComponent<Image>();
        
    }

    // Update is called once per frame
    void Update()
    {
        AtisYap();
    }

    public void AtisYap()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject newArrow;
            
             newArrow = Instantiate(Arrow, Camera.position,Quaternion.LookRotation(Camera.forward));
            
            Guc *= GucBar.fillAmount;
            newArrow.GetComponent<Rigidbody>().AddForce(Camera.transform.forward * Guc);
            Guc = 4000.0f;
        }
    }
}
