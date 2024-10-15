using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class JoyStick : MonoBehaviour, IPointerClickHandler, IPointerDownHandler, IPointerUpHandler, IDragHandler
{
    [SerializeField]
    Image backgound;

    [SerializeField]
    Image Handler;

    float joystickRadius;
    Vector2 touchPosition;
    Vector2 moveDir;

    PlayerController playerController;

    private void Start()
    {
        joystickRadius = backgound.gameObject.GetComponent<RectTransform>().sizeDelta.y / 2;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        //Debug.Log("OnPointClick");
    }

     public void OnPointerUp(PointerEventData eventData)
    {
        //Debug.Log("OmPointerUp");
        Handler.transform.position = touchPosition;
        moveDir = Vector2.zero;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        //Debug.Log("OnPointerDown");
        backgound.transform.position = eventData.position;
        Handler.transform.position = eventData.position;
        touchPosition = eventData.position;
    }

    public void OnDrag(PointerEventData eventData)
    {
        //Debug.Log("OnDrag");
        Vector2 touchDir = (eventData.position - touchPosition);

        float moveDist =  Mathf.Min(touchDir.magnitude,joystickRadius);
        moveDir = touchDir.normalized;
        Vector2 newPosition = touchPosition + moveDir * moveDist;
        Handler.transform.position = newPosition;
    }
}