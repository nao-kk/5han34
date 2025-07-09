using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Goal2 : MonoBehaviour
{
    public TMP_Text score1;
    public AudioClip sound2;
    private AudioSource audioSource;
    public int score3 = 0;
    public GameObject pacPrefab;
    private int RandomNumber = 0;//�ǉ��@�����_���ɏo�Ă������l��ۑ�����悤
    private int itemswitch = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //�f�o�b�O�p
        RandomGet();//RandomGet���Ăяo��
        itemswith();//itemswith���Ăяo��
    }
    private void OnTriggerEnter(Collider collider)
    {
        Rigidbody rigidbody = GetComponent<Rigidbody>();
        if (collider.gameObject.tag == "pac")
        {
            Destroy(collider.gameObject);
            audioSource = GetComponent<AudioSource>();
            audioSource.PlayOneShot(sound2);
            Debug.Log("1P�̓��_");
            score3++;
            score1.text = score3.ToString();
            RandomItem();//�ǉ�
        }
    }

    private void RandomItem()
    {
        int num = Random.Range(1, 4);   // 1�`3�܂ł̐������烉���_���Ŏ擾����
        RandomNumber = num;//RandomNumber�Ƃ����ϐ��ɐ�قǂ̃����_���ɏo�����l��ۑ�
    }

    //�ǉ�
    private void RandomGet()
    {

        if (RandomNumber == 1)
        {
            Debug.Log("�v���C���[2���A�C�e��1����ɓ��ꂽ");
            itemswitch = 1;// �A�C�e���P���擾
            RandomNumber = 0;//���l��0�ɖ߂�
        }
        else if (RandomNumber == 2)
        {
            Debug.Log("�v���C���[2���A�C�e��2����ɓ��ꂽ");
            itemswitch = 2;// �A�C�e���P���擾
            RandomNumber = 0;//���l��0�ɖ߂�
        }
        else if (RandomNumber == 3)
        {
            Debug.Log("�v���C���[���A�C�e��3����ɓ��ꂽ");
            itemswitch = 3;// �A�C�e���P���擾
            RandomNumber = 0;//���l��0�ɖ߂�
        }
    }

    private void itemswith()
    {
        if (itemswitch == 1)
        {
            if (Input.GetKeyDown(KeyCode.RightShift))
            {
                Debug.Log("�v���C���[2���A�C�e��1���g�p����");
                itemswitch = 0;//���l��0�ɖ߂�
            }
        }
        else if (itemswitch == 2)
        {
            if (Input.GetKeyDown(KeyCode.RightShift))
            {
                Debug.Log("�v���C���[2���A�C�e��2���g�p����");
                itemswitch = 0;//���l��0�ɖ߂�
            }
        }
        else if (itemswitch == 3)
        {
            if (Input.GetKeyDown(KeyCode.RightShift))
            {
                Debug.Log("�v���C���[2���A�C�e��3���g�p����");
                itemswitch = 0;//���l��0�ɖ߂�
            }
        }
    }
}