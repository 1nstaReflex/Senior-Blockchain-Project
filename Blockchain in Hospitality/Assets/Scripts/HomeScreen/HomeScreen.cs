using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HomeScreen : MonoBehaviour
{
    // Initializes the screen orientation
    void Start()
    {
        Screen.orientation = ScreenOrientation.Portrait; 
    }

    // Update is called once per frame
    void Update()
    {
        //Use the native back button on android to exit app
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    public void SignInPressed()
    {
        SceneManager.LoadScene("Login", LoadSceneMode.Additive);
    }
}
