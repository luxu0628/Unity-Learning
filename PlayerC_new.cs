using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        Atk();
        Move();
        //if (Input.GetKey(KeyCode.W))
        //{
        //    Debug.Log("Äã°´ÏÂÁËW¼ü");
        //}

    }

    void Move()
    {
        Vector3 dir = transform.TransformDirection(new Vector3(Input.GetAxisRaw("Horizontal"),
            0, Input.GetAxisRaw("Vertical")));
        controller.SimpleMove();
        //Horizontal A

        //Vector3 dir = new Vector3(m_Movement.x, 0, m_Movement.y);

        //transform.Translate(dir * walkSpeed * Time.deltaTime, Space.World); //
    }
    void Atk()
    {

    }
}

