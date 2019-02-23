using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Logged : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Screen.orientation = ScreenOrientation.Portrait;
    }

    // Update is called once per frame
    void Update()
    {
        
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

    //Press Rooms button to show rooms
    public void RoomsPressed()
    {
        SceneManager.LoadScene("Rooms", LoadSceneMode.Single);
    }
}
