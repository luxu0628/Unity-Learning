using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputC : MonoBehaviour
{
    public static InputC instance; 
    public Vector2 m_Movement;
    public Vector3 m_Camera;
    public bool m_atkTrigger;

    private void Awake()
    {
        instance = this; 
    } 
    void Start()
    { 
    }  
    void Update()
    { 
        //  AD     ����                                  WS   ���¼�ͷ
        m_Movement.Set(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));    
        m_Camera.Set( Input.GetAxis("Mouse X"),Input.GetAxis("Mouse Y"),Input.GetAxis("Mouse ScrollWheel") );
        m_atkTrigger = Input.GetMouseButtonDown(0);

        Debug.Log(m_Camera.z);
        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    Debug.Log("�㰴����A��");
        //}
        //if (Input.GetMouseButton(0))
        //{
        //    Debug.Log("�㰴����������");
        //}
    }

}
