using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rope : MonoBehaviour
{
    public int count = 15;
    public Text txt;
    void Update()
    {
        txt.text = "Rope: " + count;
    }
}