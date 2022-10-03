using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallDownFloor : MonoBehaviour
{
    [Header("スプライトがあるオブジェクト")] public GameObject spriteObj;
    [Header("振動幅")] public float vibrationWidth = 0.05f;
    [Header("振動速度")] public float vibarationSpeed = 30.0f;
    [Header("落ちてくるまでの時間")] public float fallTime = 1.0f;
    [Header("落ちていく速度")] public float fallSpeed = 10.0f;
    [Header("落ちてから戻ってくる時間")] public float rturnTime = 5.0f;
    [Header("振動アニメーション")] public  AnimationCurve curve;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
