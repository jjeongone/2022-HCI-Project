using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LaserPoint : MonoBehaviour
{
    private LineRenderer laser;
    private RaycastHit collidedObject;
    private GameObject currentObject;
    public float raycastDistance = 1000f;
    // Start is called before the first frame update
    void Start()
    {
        laser = this.gameObject.AddComponent<LineRenderer>();

        Material material = new Material(Shader.Find("Standard"));
        material.color = new Color(0, 195, 255, 0.5f);
        laser.material = material;
        laser.positionCount = 2;
        laser.startWidth = 0.01f;
        laser.endWidth = 0.10f;
    }

    // Update is called once per frame
    void Update()
    {
        laser.SetPosition(0, transform.position);
        Debug.DrawRay(transform.position, transform.forward * raycastDistance, Color.green, 0.5f);
        if (Physics.Raycast(transform.position, transform.forward, out collidedObject, raycastDistance))
        {
            laser.SetPosition(1, collidedObject.point);
 
            // 충돌 객체의 태그가 Button인 경우
            if (collidedObject.collider.gameObject.CompareTag("Button"))
            {
                // 오큘러스 고 리모콘에 큰 동그라미 부분을 누를 경우
                if (OVRInput.GetDown(OVRInput.Button.One))
                {
                    // 버튼에 등록된 onClick 메소드를 실행한다.
                    collidedObject.collider.gameObject.GetComponent<Button>().onClick.Invoke();
                }
 
                else
                {
                    collidedObject.collider.gameObject.GetComponent<Button>().OnPointerEnter(null);
                    currentObject = collidedObject.collider.gameObject;
                }
            }
            else
            {
                // 레이저에 감지된 것이 없기 때문에 레이저 초기 설정 길이만큼 길게 만든다.
                laser.SetPosition(1, transform.position + (transform.forward * raycastDistance));
    
                // 최근 감지된 오브젝트가 Button인 경우
                // 버튼은 현재 눌려있는 상태이므로 이것을 풀어준다.
                if(currentObject != null)
                {
                    currentObject.GetComponent<Button>().OnPointerExit(null);
                    currentObject = null;
                }
            }
        }
    }

    private void LateUpdate() 
    {
         // 버튼을 누를 경우        
        if (OVRInput.GetDown(OVRInput.Button.One))
        {
            laser.material.color = new Color(255, 255, 255, 0.5f);
        }
 
        // 버튼을 뗄 경우          
        else if (OVRInput.GetUp(OVRInput.Button.One))
        {
            laser.material.color = new Color(0, 195, 255, 0.5f);
        }
    }
}
