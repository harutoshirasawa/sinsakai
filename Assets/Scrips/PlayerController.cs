using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//後でコンポーネントを追加をし忘れてバグを発生しないための記述
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
        //ゲームオーバーシーンを見つけてもってくる
        _go = GameObject.Find("GameOverController").GetComponent<GameOver>();
        
    }


    void Update()
    {

        //移動の処理
        float horizontal = Input.GetAxis("Horizontal");
        //移動中の情報を代入する処理
        _isMoving = horizontal != 0;
        //落下中の情報を代入する処理
        _isFalling = rb.velocity.y < -0.5f;
        rb.velocity = new Vector2(horizontal * moveSpeed, rb.velocity.y); //Input.GetAxis(Horizontal)で左右に移動させる入力をしている

        if (_isMoving)
        {
            Vector3 scale = gameObject.transform.localScale;
            if (horizontal < 0 && scale.x > 0 || horizontal > 0 && scale.x < 0)
            {
                scale.x *= -1;
            }
            gameObject.transform.localScale = scale;
        }

        //ジャンプの判定
        if (Input.GetKeyDown(KeyCode.Space) && !_isJumping && !_isFalling)
        {
            Jump();


        }
        //animatorのパラメーターを設定する処理
        animator.SetBool("IsMoving", _isMoving);
        animator.SetBool("IsJumping",_isJumping);
        animator.SetBool("IsFalling",_isFalling);
    }
    void Jump()
    {
        //ジャンプした情報を変数に代入する
        _isJumping = true;
        rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {   
        //敵と当たったら消える処理
        if (collision.gameObject.tag == enemyTag)

        {
            //死んだときにゲームオーバーにする処理
            SceneManager.LoadScene("GameOverScene");

        }
        else if(collision.gameObject.tag == enemy2Tag)
        {
            SceneManager.LoadScene("GameOverScene2");
        }

        //着地判定　
        //falseの場合ジャンプする
        if (collision.gameObject.tag == "Stage")
        {
            _isJumping = false;
        }


    }

    private void OnTriggerEnter2D(Collider2D col)
    {   
        //敵を踏んだら消える
        if (col.gameObject.tag == "Enemy")
        {
            Destroy(col.gameObject);
        }
        else if (col.gameObject.tag == "Enemy2")
        {
            Destroy(col.gameObject);
        }

        //親子関係　SetParent
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




