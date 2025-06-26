using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody))]
public class pack : MonoBehaviour

{
    Rigidbody rb;
    public float fprce;//パックを移動させるために加える力
    private BoxCollider col;
    PhysicMaterial material, iceMaterial;

    // Start is called before the first frame update
    void Start()
    {
      rb = gameObject.GetComponent<Rigidbody>();//Rigidbodyを取得
        rb.constraints = RigidbodyConstraints.FreezeRotation;//パックを回転させない。
        GetComponent<BoxCollider>();//BoxColliderの取得
        material = new PhysicMaterial();//ステージのphysicalマテリアルを生成。
        material.staticFriction = 1;//ステージの静止摩擦係数を設定。
        material.dynamicFriction = 1;//ステージの動摩擦係数を設定。
        col.material = material;//ステージ用physicmマテリアルをColliderに追加する。

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
