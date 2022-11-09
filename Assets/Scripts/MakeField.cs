using UnityEngine;

namespace Kaeru
{
    /// <summary>
    /// 欄位
    /// </summary>
    public class MakeField : MonoBehaviour
    {
        // 私人：private
        // 公開：public

        // 整數 int
        // 浮點數 float

        // 字串 string
        // 布林值 bool

        // 標題
        [Header("血量")]
        public int hp = 999;

        // 提示
        [Tooltip("玩家遊玩時間。")]
        public float time = 10.5f;

        // 數值專用
        // 數值範圍 [Range(最小值，最大值)]
        // 不支援 int 與 float 以外的資料類型
        // 序列化欄位：顯示私人欄位 [SerializeField]
    }

}

