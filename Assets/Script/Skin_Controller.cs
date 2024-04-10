using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrangPhucController : MonoBehaviour
{
    public GameObject trangPhuc;
    
    void Start()
    {
        
        UnityEngine.UI.Button button = GetComponent<UnityEngine.UI.Button>();
        button.onClick.AddListener(OnClick);
    }

    void OnClick()
    {
        ShowMenu();
        
    }
    public void ShowMenu()
    {
        trangPhuc.SetActive(true);
    }
}