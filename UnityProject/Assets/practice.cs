
using UnityEngine;

public class practice : MonoBehaviour
{
    [Header("移動速度"), Range(0, 100)]
    public float Speed = 50;
    [Header("跳躍高度"), Range(200, 1000)]
    public int Jump = 700;
    [Header("對話內容")]
    public string Talk;
    [Header("是否取得雞蛋")]
    public bool Egg = false;


    public void Start()
    {
        print("遊戲開始!");
    }

    private void Update()
    {
        print(Talk);
    }
}
