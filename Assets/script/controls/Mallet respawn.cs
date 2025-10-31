using UnityEngine;
using UnityEngine.InputSystem;

/// <summary>
/// プレイヤーの入退室の管理クラス（アウトゲーム）
/// </summary>
public class Malletrespawn: MonoBehaviour
{
    // プレイヤーがゲームにJoinするためのInputAction
    [SerializeField] private InputAction playerJoinInputAction = default;
    // PlayerInputがアタッチされているプレイヤーオブジェクト
    [SerializeField] private PlayerInput playerPrefab = default;
    // 最大参加人数
    [SerializeField] private int maxPlayerCount = default;

    // Join済みのデバイス情報
    private InputDevice[] joinedDevices = default;
    // 現在のプレイヤー数
    private int currentPlayerCount = 0;

    public Material MalletMaterial;


    private void Awake()
    {
        // 最大参加可能数で配列を初期化
        joinedDevices = new InputDevice[maxPlayerCount];

        // InputActionを有効化し、コールバックを設定
        playerJoinInputAction.Enable();
        playerJoinInputAction.performed += OnJoin;
    }

    private void OnDestroy()
    {
        playerJoinInputAction.Dispose();
    }

    /// <summary>
    /// デバイスによってJoin要求が発火したときに呼ばれる処理
    /// </summary>
    private void OnJoin(InputAction.CallbackContext context)
    {
        GameObject playerObject = playerPrefab.gameObject;

        // プレイヤー数が最大数に達していたら、処理を終了
        if (currentPlayerCount >= maxPlayerCount)
        {
            Debug.Log("プログラムを終了します");
            return;
        }

        // Join要求元のデバイスが既に参加済みのとき、処理を終了
        foreach (var device in joinedDevices)
        {
            if (context.control.device == device)
            {
                return;
            }
        }

        // PlayerInputを所持した仮想のプレイヤーをインスタンス化
        // ※Join要求元のデバイス情報を紐づけてインスタンスを生成する
        var newPlayer = PlayerInput.Instantiate(
            prefab: playerObject,
            playerIndex: currentPlayerCount,
            pairWithDevice: context.control.device
            );

        if (currentPlayerCount == 1)
        {
            newPlayer.transform.position = new Vector3(-0.7f, 0f, -0.4f); // 好きな座標に変更
        }

        var renderers = newPlayer.GetComponentsInChildren<Renderer>();
        if (currentPlayerCount == 1 && renderers.Length > 0)
        {
            Debug.Log("すべてのRendererのマテリアルを変更します");
            foreach (var r in renderers)
            {
                r.material = MalletMaterial;
            }
        }



        // Joinしたデバイス情報を保存
        joinedDevices[currentPlayerCount] = context.control.device;

        currentPlayerCount++;
    }
}
