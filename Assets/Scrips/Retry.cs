using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Retry : MonoBehaviour
{
    private bool firstPush = false;
    // �V�[�����Q�[���V�[���Ɉڍs���鏈��
     public void PressStart()
    {�@
        //�Q�[���V�[���ɖ߂�
        if (!firstPush)
        {
            SceneManager.LoadScene("GameScene");
        }
    }
}
