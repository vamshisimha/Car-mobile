using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;
public class Car_enter : MonoBehaviour
{

    public GameObject Car_Cam;
    public GameObject player;
    public GameObject car;
    bool entered;
    public bool canEnter = false;
    public GameObject playerUi;
    public GameObject CarUI;
    public GameObject Enter_button;
    public GameObject Exit_Buitton;


    void Start()
    {
        playerUi.SetActive(true);
        CarUI.SetActive(false);

        player.SetActive(true);
        Car_Cam.SetActive(false);
        car.GetComponent<CarAudio>().enabled = false;
        car.GetComponent<CarController>().enabled = false;
        player.transform.parent = this.gameObject.transform;
        car.GetComponent<CarUserControl>().enabled = false;
        playerUi.SetActive(true);
        CarUI.SetActive(false);
        Exit_Buitton.SetActive(false);
        Enter_button.SetActive(false);
    }


    void Update()
    {
        if (canEnter == true)
        {
            if (entered==true)
            {


                player.SetActive(false);
                Car_Cam.SetActive(true);
                car.GetComponent<CarAudio>().enabled = true;
                car.GetComponent<CarController>().enabled = true;
                player.transform.parent = car.gameObject.transform;
                car.GetComponent<CarUserControl>().enabled = true;
                playerUi.SetActive(false);
                CarUI.SetActive(true);
                //Exit_Buitton.SetActive(true);
                Enter_button.SetActive(false);
            }
        }
    }
    void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Player")
        {
            Enter_button.SetActive(true);
            canEnter = true;
        }
    }


    void OnTriggerExit(Collider other)
    {
        Enter_button.SetActive(false);
       
            canEnter = false;
        
    }

    public void enter()
    
    {
        entered = true;
    }

}
