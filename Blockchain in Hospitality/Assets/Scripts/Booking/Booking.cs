using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Booking : MonoBehaviour
{
    public GameObject RoomResultsPanel;
    public GameObject RoomDetailsPanel;
    public GameObject BookRoomPanel;
    // Start is called before the first frame update
    void Start()
    {
        RoomResultsPanel.SetActive(false);
        RoomDetailsPanel.SetActive(false);
        BookRoomPanel.SetActive(false);
        Screen.orientation = ScreenOrientation.Portrait;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Press find rooms button to show list of available rooms
    public void FindRoomPressed()
    {
        RoomResultsPanel.SetActive(true);
    }

    //Press back button to return to previous screen
    public void BookingBackPressed()
    {
        SceneManager.LoadScene("Logged Homescreen", LoadSceneMode.Single);
    }
    public void ResultsBackPressed()
    {
        RoomResultsPanel.SetActive(false);
    }
    public void DetailsBackPressed()
    {
        RoomDetailsPanel.SetActive(false);
    }
    public void PaymentBackPressed()
    {
        BookRoomPanel.SetActive(false);
    }

    //Press a room to view it's details
    public void RoomPressed()
    {
        RoomDetailsPanel.SetActive(true);
    }
    
    //Press a rate to proceed to payment screen
    public void RatePressed()
    {
        BookRoomPanel.SetActive(true);
    }

    //Press book now to book the room
    public void BookNowPressed()
    {
        SceneManager.LoadSceneAsync("Logged Homescreen", LoadSceneMode.Single);
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
