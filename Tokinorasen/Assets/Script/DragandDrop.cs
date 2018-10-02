using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragandDrop : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{

    private Vector2 prevPos;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    // ドラック開始時
    public void OnBeginDrag(PointerEventData eventData)
    {
        prevPos = transform.position;
        Debug.Log("drag Start");

    }

    // ドラック中
    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("dragging");
        Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10);
        this.transform.position = Camera.main.ScreenToWorldPoint(mousePosition);
    }

    // ドラック終了時
    public void OnEndDrag(PointerEventData eventData)
    {
        transform.position = prevPos;
        Debug.Log("dragEnd");
    }
}