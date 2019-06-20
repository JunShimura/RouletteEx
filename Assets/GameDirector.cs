using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // UI部品を使うために必要!

public class GameDirector : MonoBehaviour {

    Transform roulette;
    Text fortune;

    void Start()
    {
        this.roulette = GameObject.Find("Roulette").transform;
        this.fortune = GameObject.Find("Fortune").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        float r = roulette.transform.rotation.eulerAngles.z;

        //回転角度を表示
        if (r >= 30.0f && r < 90.0f) {
            fortune.text = "大吉";
        }
        else if (r >= 90.0f
           && r < 150.0f) {
            fortune.text = "大凶";
        }
        else if (r >= 150.0f
           && r < 210.0f) {
            fortune.text = "小吉";
        }
        else if (r >= 210.0f
           && r < 270.0f) {
            fortune.text = "末吉";
        }
        else if (r >= 270.0f
           && r < 330.0f) {
            fortune.text = "中吉";
        }
        else {
            fortune.text = "凶";
        }
    }
}
