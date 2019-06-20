using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteController : MonoBehaviour {

    float rotSpeed = 0; //回転速度

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            this.rotSpeed = Random.Range(9.0f, 11.0f);
        }

        //回転速度分、ルーレットを回転させる
        transform.Rotate(0, 0, rotSpeed);
        // transform.localScale=new Vector3( rotSpeed,rotSpeed,1);
        //ルーレットを減速させる
        this.rotSpeed = this.rotSpeed * 0.96f;
        
        /*
        //回転角度を表示
        //Debug.Log(transform.rotation.eulerAngles.z);
        if (transform.rotation.eulerAngles.z >= 30.0f
           && transform.rotation.eulerAngles.z < 90.0f) {
            Debug.Log("大吉");
        }
        else if (transform.rotation.eulerAngles.z >= 90.0f
           && transform.rotation.eulerAngles.z < 150.0f) {
            Debug.Log("大凶");
        }
        else if (transform.rotation.eulerAngles.z >= 150.0f
           && transform.rotation.eulerAngles.z < 210.0f) {
            Debug.Log("小吉");
        }
        else if (transform.rotation.eulerAngles.z >= 210.0f
           && transform.rotation.eulerAngles.z < 270.0f) {
            Debug.Log("末吉");
        }
        else if (transform.rotation.eulerAngles.z >= 270.0f
           && transform.rotation.eulerAngles.z < 330.0f) {
            Debug.Log("中吉");
        }
        else {
            Debug.Log("凶");
        }
        */

        // 配列を使う
        //Debug.Log(transform.rotation.eulerAngles.z.ToString()
        //    + "," + AngleToMessage(transform.rotation.eulerAngles.z));
    }

    /// <summary>
    /// 角度からメッセージに変換
    /// </summary>
    /// <param name="angle">角度</param>
    /// <returns>占いのメッセージ文字列</returns>
    string AngleToMessage(float angle)
    {
        string[] message
            = { "大吉", "大凶", "小吉", "末吉", "中吉", "凶" };
        int index = (((Mathf.CeilToInt(angle) + 330)) % 360) / 60;
        return message[index];
    }
}