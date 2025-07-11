using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField, Header("移動速度")]
    private float moveSpeed = 30.0f;

    private Rigidbody rb;
    private Vector2 moveInput;
    private MyControls controls;

    private void Awake()
    {
        controls = new MyControls();
        // Rigidbodyコンポーネントを取得
        rb = GetComponent<Rigidbody>();

        // MyControlsのインスタンスを作成
        controls = new MyControls();
        Debug.Log("スタートチェック");




    }
    void Start()
    {
        Onable();
        //controls.player.move.performed + = OnMovePerformed;
    }
    private void Onable()
    {
        //InputアクションをONにする
        controls.Enable();
    }

    private void OnDisable()
    {
        //InputアクションをOFFにする
        controls.Disable();
    }


    //Moveの入力を受け取り、Rigidbodyを使ってボールを動かす
    private void FixedUpdate()
    {
        OnMovePerformed(controls.Player1.Move.ReadValue<Vector2>());
        
        //Debug.Log("入力待機中");
        // 前後左右への移動を処理
        if (rb != null)
        {
            Vector3 move = new Vector3(moveInput.x, 0, moveInput.y) * moveSpeed * Time.fixedDeltaTime;
            rb.MovePosition(rb.position + move);
            //Debug.Log(rb.position + move);
        }
    }

    private void OnMovePerformed(Vector2 context)
    {
        // Moveアクションの値を取得
        moveInput = context;
        Debug.Log("動き");
    }

    private void OnMoveCanceled(InputAction.CallbackContext context)
    {
        // Moveの入力が無くなったら移動を止める
        moveInput = Vector2.zero;

    }
}
