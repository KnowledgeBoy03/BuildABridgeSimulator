using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WoodBeam : MonoBehaviour
{
    public int count = 20;
    public Text txt;
    void Update()
    {
        txt.text = "Wooden Beams: " + count;
    }
}
