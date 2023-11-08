using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BTVN : MonoBehaviour
{
    public GameObject square;
        public GUIStyle buttonStyle;
        public GUIStyle textFileStyle;
        public GUIStyle style;
        public string missileCount;
        public int numberOfMissiles = 0;
    
        private void Start()
        {
            
            
        }
    
        void OnGUI()
        {
            // style.fontSize = 30;
            // // Tạo một background box
            // GUI.Box(new Rect(10,10,350,300), "Loader Menu");
            // // Tạo button đầu tiên, khi người cùng click sẽ load một scene
            // if (GUI.Button(new Rect(20,40,300,50), "Level 1")) {
            //     Application.LoadLevel(1);
            // } 
            // // Tạo button thứ 2
            // if (GUI.Button(new Rect(20,150,300,50), "Level 2")) {
            //     Application.LoadLevel(2);
            // }
    
            
            // buttonStyle.active.background = new Texture2D(150, 120);
            // buttonStyle.fontSize = 40;
            // // Điều chỉnh kích thước khung của button
            // buttonStyle.border = new RectOffset(10, 10, 10, 10);
            // // Đặt giá trị null cho thuộc tính normal.background và hover.background
            // buttonStyle.normal.background = null;
            // buttonStyle.hover.background = null;
            
            if (GUI.Button(new Rect(10, 10, 50, 40), "Fire!"))
            {
                fireMissile();
            }
            
            GUI.TextField (new Rect (600, 10, 80, 40), missileCount, 25);
        }
    
        private void Update()
        {
            // convert biến numberOfMissiles sang kiểu String
            missileCount = numberOfMissiles.ToString();
        }
    
        void fireMissile()
        {
            Vector3 tranform = new Vector3(square.transform.position.x , square.transform.position.y + 1f,
                square.transform.position.z);
            square.transform.position = tranform;
            numberOfMissiles++;
        }
}
