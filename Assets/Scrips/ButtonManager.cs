using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    public Camera Camera;
    public Camera subCamera;
    public GameObject Canvas;
    // Start is called before the first frame update
    void Start()
    {
     subCamera.enabled = false;   
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //ボタンを押した時の処理
    public void PushButton()
    {
        //もしサブカメラがオフだったら
        if (!subCamera.enabled)
        {
            //サブカメラをオンにして
            subCamera.enabled = true;
 
            //カメラをオフにする
            Camera.enabled = false;
 
            //キャンバスを映すカメラをサブカメラオブジェクトにする
            Canvas.GetComponent<Canvas>().worldCamera = subCamera;
        }
        //もしサブカメラがオンだったら
        else
        {
            //サブカメラをオフにして
            subCamera.enabled = false;
 
            //カメラをオンにする
            Camera.enabled = true;
 
            //キャンバスを映すカメラをカメラオブジェクトにする
            Canvas.GetComponent<Canvas>().worldCamera = Camera;
        }
    }
}
