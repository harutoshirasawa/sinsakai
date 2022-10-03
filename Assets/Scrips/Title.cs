using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Title : MonoBehaviour
{
    //スタートシーンからゲームシーンへ移行する
    private bool firstPush = false;

    //スタートボタンを押されたら呼ばれる
    public void PressStart()
    {
        if(!firstPush)
        {
            //ここに次のシーンへ行く命令を書く
            SceneManager.LoadScene("GameScene");
        }
    }
}
