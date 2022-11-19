using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Cat_Lite_Demo : MonoBehaviour
{
    public GameObject target;
    private Vector3 targetPosition;

    public float moveSpeed = 2.0f; // 이동 속도

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        transform.position = new Vector3(target.transform.position.x - 100, 0, target.transform.position.z);

        /*
         * Vector3 move =
             transform.forward * Input.GetAxis("Vertical") +
             transform.right * Input.GetAxis("Horizontal");

        move.y = 0;

        // 이동방향 * 속도 * 프레임단위 시간을 곱해서 카메라의 트랜스폼을 이동
        //transform.Translate(dir * moveSpeed * Time.deltaTime, Space.World);
        transform.position += 100 * move * moveSpeed * Time.deltaTime;
        */


        // 카메라 바라보기
        targetPosition = new Vector3(target.transform.position.x, 0, target.transform.position.z);

        transform.LookAt(targetPosition);
    }

}
