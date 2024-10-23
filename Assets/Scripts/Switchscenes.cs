using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Switchscenes : MonoBehaviour
{
    // Start is called before the first frame update
    public void ChangeScene() {
        Debug.Log("Changing");
        SceneManager.LoadScene(sceneName:"Map_1");
    }
    public void MenuScene() {
        Debug.Log("Changing");
        SceneManager.LoadScene(sceneName:"Start");
    }
}
