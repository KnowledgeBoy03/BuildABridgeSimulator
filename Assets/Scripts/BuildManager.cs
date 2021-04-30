using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildManager : MonoBehaviour
{
    public GameObject foundation;
    public GameObject road;
    public GameObject w_beam;
    public GameObject s_beam;

    public BuildSystem buildSystem;
    
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.H) && !buildSystem.isBuilding)
        {
            buildSystem.NewBuild(foundation);
        }

        if (Input.GetKeyDown(KeyCode.J) && !buildSystem.isBuilding)
        {
            buildSystem.NewBuild(road);
        }
        
        if (Input.GetKeyDown(KeyCode.K) && !buildSystem.isBuilding)
        {
            buildSystem.NewBuild(w_beam);
        }

        if (Input.GetKeyDown(KeyCode.L) && !buildSystem.isBuilding)
        {
            buildSystem.NewBuild(s_beam);
        }
    }
}
