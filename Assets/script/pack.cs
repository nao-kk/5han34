using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody))]
public class pack : MonoBehaviour

{
    Rigidbody rb;
    public float fprce;//�p�b�N���ړ������邽�߂ɉ������
    private BoxCollider col;
    PhysicMaterial material, iceMaterial;

    // Start is called before the first frame update
    void Start()
    {
      rb = gameObject.GetComponent<Rigidbody>();//Rigidbody���擾
        rb.constraints = RigidbodyConstraints.FreezeRotation;//�p�b�N����]�����Ȃ��B
        GetComponent<BoxCollider>();//BoxCollider�̎擾
        material = new PhysicMaterial();//�X�e�[�W��physical�}�e���A���𐶐��B
        material.staticFriction = 1;//�X�e�[�W�̐Î~���C�W����ݒ�B
        material.dynamicFriction = 1;//�X�e�[�W�̓����C�W����ݒ�B
        col.material = material;//�X�e�[�W�pphysicm�}�e���A����Collider�ɒǉ�����B

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
