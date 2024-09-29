using UnityEngine;
using UnityEngine.UI;

public class SubscriberManager : MonoBehaviour
{
    public Text subscriberText;  // 登録者数を表示するテキスト
    private int subscribers = 0;  // 初期登録者数

    // ボタンがクリックされたときに呼ばれるメソッド
    public void OnClick()
    {
        subscribers++;  // クリックごとに1増える
        subscriberText.text = "Subscribers: " + subscribers.ToString();  // テキストを更新
    }
}
