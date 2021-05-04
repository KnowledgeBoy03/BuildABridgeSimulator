using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameMenu : MonoBehaviour
{
    public GameObject PauseMenu;
    public GameObject BuildMenu;
    public GameObject Success;
    public GameObject Failure;
    public GameObject carWeight;
    public GameObject carryCapObj;
    public CarTest cS;
    public TextMeshProUGUI carryText;
    private GameObject[] bridgeObjects;
    private int carryCap;
    public bool paused = false;
    public bool building = false;

    private void Start()
    {
        carryCap = 24;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (paused || cS.testPhase)
            {
                print("CANNOT BUILD WHILE PAUSED OR TESTING");
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
            if (cS.testPhase)
            {
                print("CANNOT PAUSE WHILE TESTING");
            }
            else
            {
                pause();
            }
        }

        if (cS.testPhase)
        {
            building = false;
            BuildMenu.SetActive(building);
            paused = false;
            PauseMenu.SetActive(paused);
        }

        if (cS.successCheck)
        {
            Success.SetActive(true);
        }

        if (cS.failureCheck)
        {
            Failure.SetActive(true);
        }

        if (cS.bridgeFailed)
        {
            for (int i = 0; i < bridgeObjects.Length; i++)
            {
                Destroy(bridgeObjects[i]);
            }
        }

        try
        {
            bridgeObjects = GameObject.FindGameObjectsWithTag("Bridge");
            Calculate();
        }
        catch
        {
            print("Nothing built yet");
        }
        carryText.text = "Carrying Capacity: " + carryCap;
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
            carryCapObj.SetActive(false);
            carWeight.SetActive(false);
            PauseMenu.SetActive(paused);
        }
        else if (paused)
        {
            BuildMenu.SetActive(building);
            carryCapObj.SetActive(true);
            carWeight.SetActive(true);
            paused = false;
            PauseMenu.SetActive(paused);
        }
    }

    public void test()
    {
        cS.testPhase = true;
        cS.weightLim = carryCap;
    }

    public void reset()
    {
        Success.SetActive(false);
        Failure.SetActive(false);
        cS.positionReset();
    }

    private void Calculate()
    {
        int roadCount = 0;
        int woodCount = 0;
        int steelCount = 0;
        int ropeCount = 0;
        for (int i = 0; i < bridgeObjects.Length; i++)
        {
            switch (bridgeObjects[i].name)
            {
                case "Road(Clone)":
                    roadCount++;
                    break;
                case "Wooden Beam(Clone)":
                    woodCount++;
                    break;
                case "Steel Beam(Clone)":
                    steelCount++;
                    break;
                case "Rope(Clone)":
                    ropeCount++;
                    break;
            }
        }

        carryCap = 24 - (4*roadCount) + (3*woodCount) + (6*steelCount) + (1*ropeCount);
    }
}
