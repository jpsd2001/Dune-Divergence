using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    public Transform target;

    public bool pause = false;
    public GameObject pauseMenu;

    public float sens = 100f;
    float xrot = 0f;

    void Start() 
    {
        Cursor.lockState = CursorLockMode.Locked;
    }


    void Update()
    {
        if(Input.GetKey(KeyCode.Escape) && !pause) pause = true;
        if (pause) {
            Cursor.lockState = CursorLockMode.None;
            pauseMenu.SetActive(true);
            if(Input.GetKey(KeyCode.Escape)) {
                pause = false;
                pauseMenu.SetActive(false);
                Cursor.lockState = CursorLockMode.Locked;
            }
        }
        else {
            float h = Input.GetAxis("Mouse X") * sens * Time.deltaTime;
            float v = Input.GetAxis("Mouse Y") * sens * Time.deltaTime;

            xrot -= v;
            xrot = Mathf.Clamp(xrot, -90f, 90f);

            transform.localRotation = Quaternion.Euler(xrot, 0f, 0f);
            target.Rotate(Vector3.up * h);
        }
    }
}
