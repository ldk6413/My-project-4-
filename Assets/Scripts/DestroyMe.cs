using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyMe : MonoBehaviour
{
    public float limitSec = 2; // �� �� : Inspector�� ����

    void Start()
    { // ó���� �����Ѵ�
        Destroy(this.gameObject, limitSec); // ���� �� �Ŀ� �Ҹ��ϴ� ���� 
    }
}
