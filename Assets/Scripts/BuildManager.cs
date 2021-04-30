using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildManager : MonoBehaviour
{
    public GameObject road;
    public GameObject w_beam;
    public GameObject s_beam;
    public GameObject rope;

    public BuildSystem buildSystem;

    public void BuildRoad()
    {
        if (!buildSystem.isBuilding)
        {
            buildSystem.NewBuild(road);
        }
    }
    
    public void BuildWoodBeam()
    {
        if (!buildSystem.isBuilding)
        {
            buildSystem.NewBuild(w_beam);
        }
    }
    
    public void BuildSteelBeam()
    {
        if (!buildSystem.isBuilding)
        {
            buildSystem.NewBuild(s_beam);
        }
    }
    
    public void BuildRope()
    {
        if (!buildSystem.isBuilding)
        {
            buildSystem.NewBuild(rope);
        }
    }
}
