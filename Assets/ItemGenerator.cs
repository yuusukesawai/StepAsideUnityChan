﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGenerator : MonoBehaviour {
    //carPrefabを入れる
    public GameObject carPrefab;
    //coinPrefabを入れる
    public GameObject coinPrefab;
    //cornPrefabを入れる
    public GameObject conePrefab;
    //スタート地点
    private int startPos = -160;
    //ゴール地点
    private int goalPos = 120;
    //アイテムを出すx方向の範囲
    private float PosRange = 3.4f;

    private GameObject unitychan;
    
    // Use this for initialization
    void Start()
    {
       this.unitychan = GameObject.Find("unitychan");

    }
    // Update is called once per frame
    void Update()
    {
        

        if (this.unitychan.transform.position.z >= startPos - 50 && startPos < goalPos)
        {

            
                //どのアイテムを出すのかをランダムに設定
                int num = Random.Range(1, 11);
                if (num <= 2)
                {
                    //コーンをx軸方向に一直線に生成
                    for (float j = -1; j <= 1; j += 0.4f)
                    {
                        GameObject cone = Instantiate(conePrefab) as GameObject;
                        cone.transform.position = new Vector3(4 * j, cone.transform.position.y, startPos);
                    }
                
            }
                else
                {
                    for (int j = -1; j <= 1; j++)
                    {
                        //アイテムの種類を決める
                        int item = Random.Range(1, 11);
                        //アイテムを置くz座標のオフセットをランダムに配置
                        int offsetZ = Random.Range(-5, 6);
                        //60％コイン配置、30%車配置、10%何もなし
                        if (1 <= item && item <= 6)
                        {
                            //コインを生成
                            GameObject coin = Instantiate(coinPrefab) as GameObject;
                            coin.transform.position = new Vector3(PosRange * j, coin.transform.position.y, startPos + offsetZ);
                        }
                        else if (7 <= item && item <= 9)
                        {
                            //車を生成
                            GameObject car = Instantiate(carPrefab) as GameObject;
                            carPrefab.transform.position = new Vector3(PosRange * j, car.transform.position.y, startPos + offsetZ);
                        }
                    }
                }
            startPos += 15;
            Debug.Log(this.unitychan.transform.position.z);
        }
    }
}
