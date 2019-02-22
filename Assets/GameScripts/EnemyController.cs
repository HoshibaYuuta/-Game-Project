using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    float Epx = 0f;
    float Epy = 0f;

    bool A = true;

    float a = 100;//小さいほど早く進む

    int b;

    float ex;
    float ey;

    bool hantei = true;
    //プレイヤーオブジェクト
    public GameObject player;

    //弾のプレハブオブジェクト
    public GameObject tama;

    //一秒ごとに弾を発射するためのもの
    private float targetTime = 1.0f;
    private float currentTime = 0;

    // Update is called once per frame
    void Update()
    {

        currentTime += Time.deltaTime;
        if (targetTime < currentTime)
        {
            currentTime = 0;

            //敵の座標を変数posに保存
            var pos = this.gameObject.transform.position;

            //弾のプレハブを作成
            var t = Instantiate(tama) as GameObject;

            //弾のプレハブの位置を敵の位置にする
            t.transform.position = pos;

            //敵からプレイヤーに向かうベクトルをつくる
            //プレイヤーの位置から敵の位置（弾の位置）を引く
            Vector2 vec = player.transform.position - pos;

            //弾のRigidBodyコンポネントのvelocityに先程求めたベクトルを入れて力を加える
            t.GetComponent<Rigidbody>().velocity = vec;

            
        }
    }

    void FixedUpdate()
    {

        if (A == false)
        {
            float x = Random.Range(-9, 9);
            float y = Random.Range(5, -2);

            ex = this.gameObject.transform.position.x;
            ey = this.gameObject.transform.position.y;

            ex = (x - ex) / a;
            ey = (y - ey) / a;

            A = true;


        }
        else
        {
            transform.position = new Vector3(transform.position.x + ex, transform.position.y + ey, 0f);
            b++;
            if (b == a)
            {
                A = false;
                b = 0;
            }

        }
    }
}


