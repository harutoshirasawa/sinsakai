using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Retry2 : MonoBehaviour
{
    private bool firstPush = false;
    // �V�[�����Q�[���V�[���Ɉڍs���鏈��
    public void PressStart()
    {
        if (!firstPush)
        {
            SceneManager.LoadScene("TestScene");
        }
    }
}
