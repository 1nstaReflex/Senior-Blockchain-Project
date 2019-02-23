using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Rooms : MonoBehaviour
{
    public GameObject Room420Panel;
    public GameObject Room455Panel;
    // Start is called before the first frame update
    void Start()
    {
        Room420Panel.SetActive(false);
        Room455Panel.SetActive(false);
        Screen.orientation = ScreenOrientation.Portrait;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Press Room 420 to go to Room 420 door page
    public void Room420Pressed()
    {
        Room420Panel.SetActive(true);
    }

    //Press Room 455 to go to Room 455 door page
    public void Room455Pressed()
    {
        Room455Panel.SetActive(true);
    }

    //Press back to return to room list
    public void RoomBackPressed()
    {
        Room420Panel.SetActive(false);
        Room455Panel.SetActive(false);
    }

    //Press back to return to logged homescreen
    public void BackPressed()
    {
        SceneManager.LoadSceneAsync("Logged Homescreen", LoadSceneMode.Single);
    }

    //Press Booking button to begin booking a room
    public void BookPressed()
    {
        SceneManager.LoadScene("Booking", LoadSceneMode.Single);
    }

    //Press Reservations button to show reservations
    public void ReservationsPressed()
    {
        SceneManager.LoadScene("Reservations", LoadSceneMode.Single);
    }
}
