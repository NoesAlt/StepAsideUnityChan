using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCameraController : MonoBehaviour {


    //Unityちゃんのオブジェクト
    private GameObject unitychan;
    //Unityちゃんとカメラの距離
    private float difference;







    //車のオブジェクト
    private GameObject car;
    //車とカメラの距離
    private float difference1;

    //コインのオブジェクト
    private GameObject coin;
    //コインとカメラの距離
    private float difference2;

    //カラーコーンのオブジェクト
    private GameObject cone;
    //カラーコーンとカメラの距離
    private float difference3;


    // Use this for initialization
    void Start()
    {
        //Unityちゃんのオブジェクトを取得
        this.unitychan = GameObject.Find("unitychan");
        //Unityちゃんとカメラの位置（z座標）の差を求める
        this.difference = unitychan.transform.position.z - this.transform.position.z;










        //車のオブジェクトを取得
        this.car = GameObject.Find("CarPrefab");
        //車とカメラの位置の差を求める
        this.difference1 = car.transform.position.z - this.transform.position.z;

        //コインのオブジェクトを取得
        this.coin = GameObject.Find("CoinPrefab");
        //コインとカメラの位置の差を求める
        this.difference2 = coin.transform.position.z - this.transform.position.z;

        //カラーコーンのオブジェクトを取得
        this.cone = GameObject.Find("TrafficConePrefab");
        //カラーコーンとカメラの位置の差を求める
        this.difference3 = cone.transform.position.z - this.transform.position.z;



    }

    // Update is called once per frame
    void Update()
    {
        //Unityちゃんの位置に合わせてカメラの位置を移動
        this.transform.position = new Vector3(0, this.transform.position.y, this.unitychan.transform.position.z - difference);




        //各アイテムとカメラの差が負の時ぶっ壊す
        if(difference1 < 0 || difference2 < 0 || difference3 < 0)
        {
            Destroy(this.gameObject);         
        }
    }
}
