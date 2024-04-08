using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class InfoManager : MonoBehaviour
{
    public Text info;
    string Name = "Duc Long";

    void Start()
    {

    }

    void Update()
    {
        info.text = "Ten nguoi choi:  " + Name;
    }
}