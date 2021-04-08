using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameMenu : MonoBehaviour
{
    public GameObject PauseMenu;
    public GameObject BuildMenu;
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
    }

}
