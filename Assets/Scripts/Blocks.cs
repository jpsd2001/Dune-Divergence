using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blocks : MonoBehaviour
{
    public GameObject[] active;
    public bool pause = false;
    public AudioSource src;
    public AudioClip sfx;
    // Update is called once per frame
    void Update()
    {   
        if(Input.GetKeyDown(KeyCode.Tab) && !pause) {
            pause = true;
        }
        else if(Input.GetKeyDown(KeyCode.Tab) && pause) {
            pause = false;
        }
        if(!pause) {
            if(Input.GetMouseButtonDown(0)) {
                for(int i = 0; i < active.Length; i++) {
                    if(active[i].activeSelf == true) {
                        src.clip = sfx;
                        src.Play();
                        //Debug.Log("active");
                        active[i].SetActive(false);
                    }
                    else {
                        //Debug.Log("inactive");
                        active[i].SetActive(true);
                    }
                }
            }
        }
    }
}
