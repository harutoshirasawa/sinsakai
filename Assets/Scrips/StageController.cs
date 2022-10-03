using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageControler : MonoBehaviour
{
    [Header("�v���C���[�Q�[���I�u�W�F�N�g")] public GameObject playerObj;
    [Header("�R���e�B�j���[")]public GameObject[] countinuePoint;
    
    // Start is called before the first frame update
    void Start()
    {
        if (playerObj != null && countinuePoint != null && countinuePoint.Length > 0)
        {
            playerObj.transform.position = countinuePoint[0].transform.position;
        }
        else
        {
            Debug.Log("�ݒ肪����Ă��Ȃ���");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
