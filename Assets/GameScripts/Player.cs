using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    bool inv = true;

    public GameObject baria;
    // 移動スピード
    public float speed = 5;

    public static float r;

    void Start()
    {
        r = baria.GetComponent<MeshFilter>().mesh.bounds.size.x * baria.transform.localScale.x / 2;
    }

    void Update()
    {
        Transform playerpos = this.gameObject.GetComponent<Transform>();

        // 右・左
        float x = Input.GetAxisRaw("Horizontal");

        // 上・下
        float y = Input.GetAxisRaw("Vertical");

        // 移動する向きを求める
        Vector3 direction = new Vector3(x, y, 0).normalized;

        // 移動する向きとスピードを代入する
        GetComponent<Rigidbody>().velocity = direction * speed;

        //スペースキーが押されたらバリア発動
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (inv == true)
            {
                inv = false;
                // コルーチンを実行  
                StartCoroutine("Barrier");

            }
        }

    }

    // コルーチン  
    private IEnumerator Barrier()
    {
        this.baria.SetActive(true);

        yield return new WaitForSeconds(0.1f);

        this.baria.SetActive(false);

        yield return new WaitForSeconds(1.0f);

        inv = true;
    }

}