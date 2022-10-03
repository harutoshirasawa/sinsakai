using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//��ŃR���|�[�l���g��ǉ������Y��ăo�O�𔭐����Ȃ����߂̋L�q
[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(CapsuleCollider2D))]
[RequireComponent(typeof(Animator))]
public class PlayerController : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Animator animator;
    [SerializeField] private int moveSpeed;
    [SerializeField] private int jumpForce;
   
   
    private bool _isMoving = false;
    private bool _isJumping = false;
    private bool _isFalling = false;
    private string enemyTag = "Enemy";
    private string enemy2Tag = "Enemy2";
    public bool _go = false;
    
    

    private void Start()
    {
        //�Q�[���I�[�o�[�V�[���������Ă����Ă���
        _go = GameObject.Find("GameOverController").GetComponent<GameOver>();
        
    }


    void Update()
    {

        //�ړ��̏���
        float horizontal = Input.GetAxis("Horizontal");
        //�ړ����̏��������鏈��
        _isMoving = horizontal != 0;
        //�������̏��������鏈��
        _isFalling = rb.velocity.y < -0.5f;
        rb.velocity = new Vector2(horizontal * moveSpeed, rb.velocity.y); //Input.GetAxis(Horizontal)�ō��E�Ɉړ���������͂����Ă���

        if (_isMoving)
        {
            Vector3 scale = gameObject.transform.localScale;
            if (horizontal < 0 && scale.x > 0 || horizontal > 0 && scale.x < 0)
            {
                scale.x *= -1;
            }
            gameObject.transform.localScale = scale;
        }

        //�W�����v�̔���
        if (Input.GetKeyDown(KeyCode.Space) && !_isJumping && !_isFalling)
        {
            Jump();


        }
        //animator�̃p�����[�^�[��ݒ肷�鏈��
        animator.SetBool("IsMoving", _isMoving);
        animator.SetBool("IsJumping",_isJumping);
        animator.SetBool("IsFalling",_isFalling);
    }
    void Jump()
    {
        //�W�����v��������ϐ��ɑ������
        _isJumping = true;
        rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {   
        //�G�Ɠ�������������鏈��
        if (collision.gameObject.tag == enemyTag)

        {
            //���񂾂Ƃ��ɃQ�[���I�[�o�[�ɂ��鏈��
            SceneManager.LoadScene("GameOverScene");

        }
        else if(collision.gameObject.tag == enemy2Tag)
        {
            SceneManager.LoadScene("GameOverScene2");
        }

        //���n����@
        //false�̏ꍇ�W�����v����
        if (collision.gameObject.tag == "Stage")
        {
            _isJumping = false;
        }


    }

    private void OnTriggerEnter2D(Collider2D col)
    {   
        //�G�𓥂񂾂������
        if (col.gameObject.tag == "Enemy")
        {
            Destroy(col.gameObject);
        }
        else if (col.gameObject.tag == "Enemy2")
        {
            Destroy(col.gameObject);
        }

        //�e�q�֌W�@SetParent
        if (col.gameObject.tag == "Floor")
        {
            gameObject.transform.SetParent(col.gameObject.transform);
            _isJumping = false;
        }
    }
    
    private void OnTriggerExit2D(Collider2D col)
    {
        if(col.gameObject.tag =="Floor")
        {
            gameObject.transform.SetParent(null);
            
        }
    }
}




