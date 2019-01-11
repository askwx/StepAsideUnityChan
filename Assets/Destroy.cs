using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    //unityちゃんのオブジェクト
    private GameObject unitychan;
    //unityちゃんとカメラの距離
    private float difference;


    // Use this for initialization
    void Start()
    {
        //unityちゃんのオブジェクトを取得
        this.unitychan = GameObject.Find("unitychan");
        //unityちゃんとカメラ位置の差を求める
        this.difference = unitychan.transform.position.z - this.transform.position.z;

    }

    // Update is called once per frame
    void Update()
    {
        if (this.gameObject.transform.position.z <= unitychan.transform.position.z)
            Destroy(this.gameObject);

    }
    void OnBecameInvisible()
    {

    }

}



