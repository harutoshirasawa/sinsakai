using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Title : MonoBehaviour
{
    //�X�^�[�g�V�[������Q�[���V�[���ֈڍs����
    private bool firstPush = false;

    //�X�^�[�g�{�^���������ꂽ��Ă΂��
    public void PressStart()
    {
        if(!firstPush)
        {
            //�����Ɏ��̃V�[���֍s�����߂�����
            SceneManager.LoadScene("GameScene");
        }
    }
}
