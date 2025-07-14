using System.Collections;

using System.Collections.Generic;

using UnityEngine;

public class pack : MonoBehaviour

{

    private float power;

    Rigidbody rb;

    public float bounceFactor = 1f;  // ���˂̋���

    public float forceMultiplier = 10f;  // ���ˌ�ɉ�����ǉ��̗́i����

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

            Vector3 incomingVector = other.relativeVelocity;//���˃x�N�g���̐ݒ�

            Vector3 normal = other.contacts[0].normal;//�Ԃ��������̃x�N�g���ݒ�

            Vector3 reflectedVector = Vector3.Reflect(incomingVector, normal);//���˃x�N�g���̐ݒ�



            Rigidbody rb = GetComponent<Rigidbody>();

            if (rb != null)

            {

                // ���ˌ�̑��x�����߂�

                rb.velocity = reflectedVector;

                rb.AddForce(reflectedVector * forceMultiplier, ForceMode.Impulse);

            }

        }

    }

}

