using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SteelBeam : MonoBehaviour
{
    public int count = 4;
    public Text txt;
    void Update()
    {
        txt.text = "Steel Beams: " + count;
    }
}
