using System.Collections;

using System.Collections.Generic;

using UnityEngine;

public class pack : MonoBehaviour

{

    private float power;

    Rigidbody rb;

    public float bounceFactor = 1f;  // 反射の強さ

    public float forceMultiplier = 10f;  // 反射後に加える追加の力（強さ

    // Start is called before the first frame update

    void Start()

    {

        power = 10.0f;

        rb = GetComponent<Rigidbody>();

        rb.AddForce(transform.up * power, ForceMode.Impulse);

    }

    void OnCollisionEnter(Collision other)

    {

        if (other.gameObject.CompareTag("ace8Surface8"))

        {

            //float randomDir =Random.Range(-power,power);

            //rb.velocity = Vector3.zero;

            //rb.AddForce(randomDir, -power, 0, ForceMode.Impulse);

            Vector3 incomingVector = other.relativeVelocity;//入射ベクトルの設定

            Vector3 normal = other.contacts[0].normal;//ぶつかった時のベクトル設定

            Vector3 reflectedVector = Vector3.Reflect(incomingVector, normal);//反射ベクトルの設定



            Rigidbody rb = GetComponent<Rigidbody>();

            if (rb != null)

            {

                // 反射後の速度を決める

                rb.velocity = reflectedVector;

                rb.AddForce(reflectedVector * forceMultiplier, ForceMode.Impulse);

            }

        }

    }

}

