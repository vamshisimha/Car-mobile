using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class Car_exit : MonoBehaviour
{

    public GameObject Car_Cam;
    public GameObject player;
    public GameObject car;
    public GameObject enter_trigger;
    bool exit=false;
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
        Enter_button.SetActive(false); ;
    }

    // Update is called once per frame
    void Update()
    {

        if (exit==true)
        {
            player.SetActive(true);
            Car_Cam.SetActive(false);
            car.GetComponent<CarAudio>().enabled = false;
            car.GetComponent<CarController>().enabled = false;
            car.GetComponent<CarUserControl>().enabled = false;
            player.transform.parent = null;
            playerUi.SetActive(true);
            CarUI.SetActive(false);
            Exit_Buitton.SetActive(true);
            Enter_button.SetActive(false);

        }

    }

    IEnumerator EnterAgain()
    {
        yield return new WaitForSeconds(0.5f);
        enter_trigger.GetComponent<BoxCollider>().enabled = true;
        this.gameObject.SetActive(false);
    }

    public void exited()
    {
        exit=true;
    }


}
