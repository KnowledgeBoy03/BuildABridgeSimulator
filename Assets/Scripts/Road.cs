using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Road : MonoBehaviour
{
    public int count = 10;
    public Text txt;
    void Update()
    {
        txt.text = "Road: " + count;
    }
}
