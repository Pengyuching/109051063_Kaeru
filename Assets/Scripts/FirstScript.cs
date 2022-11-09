using UnityEngine;

namespace Kaeru
{
    /// <summary>
    /// 第一個程式
    /// </summary>
    public class FirstScript : MonoBehaviour
    {
        #region 事件區域
        // 喚醒事件：遊戲開始時執行一次
        private void Awake()
        {
            // 輸出(訊息)；
            print("快樂啾啾～");
        }

        // 開始事件：在 Awake 後執行一次
        private void Start()
        {
            print("<color=magenta>開始事件</color>");
        }

        //更新事件：在 Start 後執行，執行次數約　60 FPS
        private void Update()
        {
            print("<color=red>更新事件！</color>");
        }
        #endregion

    }
}


