using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sousa : MonoBehaviour
{
    private bool firstPush = false;
    // �V�[�����Q�[���V�[���Ɉڍs���鏈��
    public void PressStart()
    {
        if(!firstPush)
        {
            SceneManager.LoadScene("TestScene");
        }
    }
}
