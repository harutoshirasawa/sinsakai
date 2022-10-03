using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GotoTitle : MonoBehaviour
{
    private bool firstPush = false;
    public void PressStart()
    {
        if (!firstPush)
        {
            //ここに次のシーンへ行く命令を書く
            SceneManager.LoadScene("TitleScene");
        }    
    }

}
