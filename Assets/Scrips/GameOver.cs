using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameOver : MonoBehaviour
{
    private bool firstPush = false;


    public void PressStart()
    {
        if (!firstPush)
        {
            //�^�C�g���V�[���ֈڍs
            SceneManager.LoadScene("TitleScene");

        }
    }

}
