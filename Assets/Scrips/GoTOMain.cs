using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToMain : MonoBehaviour
{
    // シーンをゲームシーンに移行する処理
    void Start()
    {
        //ゲームシーンに移行
        SceneManager.LoadScene("GameScene");
        
    }

   
}
