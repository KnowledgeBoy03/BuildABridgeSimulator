using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rope : MonoBehaviour
{
    private int count = 0;
    public Text txt;
    void Update()
    {
        txt.text = "Rope: " + count;
    }
}