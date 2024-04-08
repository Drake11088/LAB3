using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Timeline;

public class MenuController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject MenuChinh;
    public GameObject MenuTrangphuc;
    void Start()
    {
        HideMenu();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if(MenuChinh.activeSelf)
            {
                HideMenu();
            }
            else
            {
                ShowMenu();
            }
        }
    }
    void ShowMenu()
    {
        MenuChinh.SetActive(true);
        Time.timeScale = 0f;
    }
    void HideMenu()
    {
        MenuChinh.SetActive(false);
        MenuTrangphuc.SetActive(false);
        Time.timeScale = 1f;
    }
}
