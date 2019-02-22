using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollition : MonoBehaviour
{
    bool nushi;

    public GameObject Baria;

    public GameObject player;

    //スピード変数
    public static int speed = 2;

    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        transform.LookAt(player.transform.position);
        this.gameObject.GetComponent<Rigidbody>().velocity = transform.forward.normalized* speed;
        rb = GetComponent<Rigidbody>();

    }

    void OnTriggerEnter(Collider other)
    {
        //左右の壁にあったったら
        if (other.gameObject.tag == "Wall")
        {
            //xを反転
            rb.velocity = new Vector3(-rb.velocity.x, rb.velocity.y, 0);
        }
        //上下の壁にあたったら
        if (other.gameObject.tag == "Wall2")
        {
            //yを反転
            rb.velocity = new Vector3(rb.velocity.x, -rb.velocity.y, 0);

        }

        //タグによる当たり判定　タグがバリア
        if (other.gameObject.tag == "Baria")
        {           
            nushi = true;
        }

        //タグによる当たり判定　タグがプレイヤ
        if(other.gameObject.tag == "Player")
        {
            //ボールを消す
            Destroy(gameObject);

            //HPDownを呼び出す
            HpDown.OnHpDown();
        }

        //持っている条件が真＆タグがエネミー
        if (nushi == true && other.gameObject.tag == "Enemy")
        {
            //ボールを消す
            Destroy(gameObject);

            //HPDownを呼び出す
            EnHpDown.OnEHpDown();
        }
    }

    //持ち主の真偽判定
    public void Motinushi(bool i)
    {
        nushi = i;
    }

    void Update()
    {
        if (Baria.activeInHierarchy)
        {
            //玉の中心座標
            Vector3 Tp = transform.position;

            //プレイヤの中心座標
            Vector3 Pp = this.player.transform.position;

            //ベクトルを検知
            Vector3 dir = Tp - Pp;

            //
            float d = dir.magnitude;

            //バリアの半径
            float r1 = Player.r;

            //ベクトル値がバリアの半径以下
            if (d < r1)
            {
                //ベクトルの方向に反射
                rb.velocity = dir.normalized * 10;
            }
        }
    }
}
