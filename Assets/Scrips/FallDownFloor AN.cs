using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallDownFloor : MonoBehaviour
{
    [Header("�X�v���C�g������I�u�W�F�N�g")] public GameObject spriteObj;
    [Header("�U����")] public float vibrationWidth = 0.05f;
    [Header("�U�����x")] public float vibarationSpeed = 30.0f;
    [Header("�����Ă���܂ł̎���")] public float fallTime = 1.0f;
    [Header("�����Ă������x")] public float fallSpeed = 10.0f;
    [Header("�����Ă���߂��Ă��鎞��")] public float rturnTime = 5.0f;
    [Header("�U���A�j���[�V����")] public  AnimationCurve curve;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
