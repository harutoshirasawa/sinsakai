using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Retry : MonoBehaviour
{
    private bool firstPush = false;
    // シーンをゲームシーンに移行する処理
     public void PressStart()
    {　
        //ゲームシーンに戻る
        if (!firstPush)
        {
            SceneManager.LoadScene("GameScene");
        }
    }
}
