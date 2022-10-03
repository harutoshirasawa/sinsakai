using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageControler : MonoBehaviour
{
    [Header("プレイヤーゲームオブジェクト")] public GameObject playerObj;
    [Header("コンティニュー")]public GameObject[] countinuePoint;
    
    // Start is called before the first frame update
    void Start()
    {
        if (playerObj != null && countinuePoint != null && countinuePoint.Length > 0)
        {
            playerObj.transform.position = countinuePoint[0].transform.position;
        }
        else
        {
            Debug.Log("設定が足りていないよ");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
