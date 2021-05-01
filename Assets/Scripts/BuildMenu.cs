using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildMenu : MonoBehaviour
{
    public BuildManager buildManager;
    
    public void WoodenBeamButton()
    {
        buildManager.BuildWoodenBeam();
    }
    public void SteelBeamButton()
    {
        buildManager.BuildSteelBeam();
    }
    public void RoadButton()
    {
        buildManager.BuildRoad();
    }
    public void RopeButton()
    {
        buildManager.BuildRope();
    }
}
