using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public GameObject Player;
    public float m_speed = 5f;
    //Vector3 tempPoint = new Vector3(0, 0, 0);

    void Update()
    {
        //PlayerMove_FollowMouse();
        PlayerMove_KeyTransform2();
    }

    public void PlayerMove_KeyTransform2()
    {
        float horizontal = Input.GetAxis("Horizontal"); //A D
        float vertical = Input.GetAxis("Vertical"); //W S
        Player.transform.Translate(Vector3.forward * vertical * m_speed * Time.deltaTime);//W S
        Player.transform.Translate(Vector3.right * horizontal * m_speed * Time.deltaTime);//A D
    }
    
    /*public void PlayerMove_FollowMouse()
    {
        if (Input.GetMouseButtonDown(1))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;
            if (Physics.Raycast(ray, out hitInfo))
            {
                tempPoint = hitInfo.point;
            }
        }
        float step = 10 * Time.deltaTime;
        Player.transform.localPosition = Vector3.MoveTowards(Player.transform.localPosition, tempPoint, step);
        Player.transform.LookAt(tempPoint);
    }*/
}
