using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Login : MonoBehaviour
{
    public GameObject verificationPanel;

    // Inititialization
    void Start()
    {
        verificationPanel.SetActive(false);
        Screen.orientation = ScreenOrientation.Portrait;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Pressing login button makes verification panel pop-up
    public void LoginPressed()
    {
        verificationPanel.SetActive(true);
    }

    //Press back button to return to homescreen
    public void BackPressed()
    {
        SceneManager.LoadScene("Homescreen", LoadSceneMode.Single);
    }

    //Confirm verification code and go to logged homescreen
    public void ContinuePressed()
    {
        SceneManager.LoadScene("Logged Homescreen", LoadSceneMode.Single);
    }

    //Cancel verification and return to sign-in screen
    public void CancelPressed()
    {
        verificationPanel.SetActive(false);
    }
}
