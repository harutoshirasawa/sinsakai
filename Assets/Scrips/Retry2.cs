using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Retry2 : MonoBehaviour
{
    private bool firstPush = false;
    // シーンをゲームシーンに移行する処理
    public void PressStart()
    {
        if (!firstPush)
        {
            SceneManager.LoadScene("TestScene");
        }
    }
}
