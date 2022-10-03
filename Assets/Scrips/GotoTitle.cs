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
            //‚±‚±‚ÉŸ‚ÌƒV[ƒ“‚Ös‚­–½—ß‚ğ‘‚­
            SceneManager.LoadScene("TitleScene");
        }    
    }

}
