using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject menuChinh;
    public PlayerData playerData;
    public Text Level;
    public Text Score;
    void Start()
    {
        HideMenu();
        LoadPlayerData();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (menuChinh.activeSelf)
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
        menuChinh.SetActive(true);
        Time.timeScale = 0f; // D?ng th?i gian trong trò ch?i khi hi?n th? menu
    }

    void HideMenu()
    {
        menuChinh.SetActive(false);
        Time.timeScale = 1f; // Khôi ph?c th?i gian khi ?n menu
    }

    void LoadPlayerData()
    {
        // ??c d? li?u ng??i ch?i t? file l?u tr?
        if (PlayerPrefs.HasKey("PlayerLevel"))
        {
            playerData.playerLevel = PlayerPrefs.GetInt("PlayerLevel");
            playerData.playerScore = PlayerPrefs.GetInt("PlayerScore");
            Level.text = "Level:" + (playerData.playerLevel).ToString();
            Score.text = "Score:" + (playerData.playerScore).ToString();
            //Debug.Log("Player data loaded.");
            Debug.Log("PlayerLevel" + playerData.playerLevel);
            Debug.Log("playerScore" + playerData.playerScore);
        }
        else
        {
            //Debug.LogWarning("Player data not found. Starting with default values.");
            // Gán giá tr? m?c ??nh n?u không tìm th?y d? li?u ng??i ch?i
            playerData.playerLevel = 0;
            playerData.playerScore = 0;
        }

    }
}