using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameMenu : MonoBehaviour
{
    public GameObject PauseMenu;
    public GameObject BuildMenu;
    public GameObject Success;
    public GameObject Failure;
    public CarTest cS;
    public bool paused = false;
    public bool building = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (paused)
            {
                print("CANNOT BUILD WHILE PAUSED");
            }
            else if (building)
            {
                building = false;
                BuildMenu.SetActive(building);
            }
            else
            {
                building = true;
                BuildMenu.SetActive(building);
            }
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            pause();
        }

        if (cS.successCheck)
        {
            Success.SetActive(true);
        }

        if (cS.failureCheck)
        {
            Failure.SetActive(true);
        }
    }

    public void pause()
    {
        if (!paused)
        {
            if (building)
            {
                BuildMenu.SetActive(!building);
            }
            paused = true;
            PauseMenu.SetActive(paused);
        }
        else if (paused)
        {
            BuildMenu.SetActive(building);
            paused = false;
            PauseMenu.SetActive(paused);
        }
    }

    public void test()
    {
        cS.testPhase = true;
    }

    public void reset()
    {
        Success.SetActive(false);
        Failure.SetActive(false);
        cS.positionReset();
    }
}
