using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Reservations : MonoBehaviour
{
    public GameObject ReservationOptionsPanel;
    public GameObject CancellationPanel;
    // Start is called before the first frame update
    void Start()
    {
        ReservationOptionsPanel.SetActive(false);
        CancellationPanel.SetActive(false);
        Screen.orientation = ScreenOrientation.Portrait;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Press reserved room to display further options
    public void ReservationPressed()
    {
        ReservationOptionsPanel.SetActive(true);
    }

    //Press Check-In button to check into the room
    public void CheckInPressed()
    {
        ReservationOptionsPanel.SetActive(false);
    }

    //Press cancel reservation to open cancellation window
    public void CancelPressed()
    {
        CancellationPanel.SetActive(true);
        ReservationOptionsPanel.SetActive(false);
    }

    //Confirm room cancellation
    public void ConfirmCancelPressed()
    {
        CancellationPanel.SetActive(false);
    }

    //keep room reservation
    public void KeepReservationPressed()
    {
        CancellationPanel.SetActive(false);
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

    //Press Rooms button to show rooms
    public void RoomsPressed()
    {
        SceneManager.LoadScene("Rooms", LoadSceneMode.Single);
    }
}
