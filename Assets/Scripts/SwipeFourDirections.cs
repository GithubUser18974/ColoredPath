using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeFourDirections : MonoBehaviour {

    private bool vTap, vSwipeLeft, vSwipeRight, vSwipeUp, vSwipeDown;
    private bool vIsDraging =false;
    private Vector2 vStartTouch, vSwipeDelta;
    public int vSwipeRatio = 125;

    private void Update()
    {
        vTap = vSwipeUp = vSwipeRight = vSwipeLeft = vSwipeDown = false;
        #region Standalone Inputs
                if (Input.GetMouseButtonDown(0))
                {
                    vTap = true;
                    vIsDraging = true;
                    vStartTouch = Input.mousePosition;
                }
                else if (Input.GetMouseButtonUp(0))
                {
                    Reset();

                }
        #endregion
        #region Mobile Inputs
        if (Input.touchCount > 0)
        {
            if (Input.touches[0].phase == TouchPhase.Began)
            {
                vTap = true;
                vIsDraging = true;
                vStartTouch = Input.touches[0].position;
            }
            else if(Input.touches[0].phase == TouchPhase.Ended|| Input.touches[0].phase == TouchPhase.Canceled)
            {
                Reset();
            }
        }
        #endregion
        //Calculate Distance ( Swipe Dela )
        vSwipeDelta = Vector2.zero;
        if (vIsDraging)
        {
            if (Input.touchCount > 0)
            {
                vSwipeDelta = Input.touches[0].position - vStartTouch;
            }
            else if (Input.GetMouseButtonDown(0))
            {
                vSwipeDelta = (Vector2)Input.mousePosition - vStartTouch;
            }
        }
        if (vSwipeDelta.magnitude > vSwipeRatio)
        {
            float x = vSwipeDelta.x;
            float y = vSwipeDelta.y;
            if (Mathf.Abs(x) > Mathf.Abs(y))
            {
                if (x < 0)
                    vSwipeLeft = true;
                else
                    vSwipeRight = true;
            }
            else
            {
                if (y < 0)
                    vSwipeDown = true;
                else
                    vSwipeUp = true;
            }

            Debug.Log(vSwipeLeft + " " + vSwipeRight + " " + vSwipeUp + " " + vSwipeDown+" "+x+"  "+y);

            Reset();
        }
    }
    private void Reset()
    {
        vStartTouch = vSwipeDelta = Vector2.zero;
        vIsDraging = false;
    }

    public Vector2 mSwipeDelta { get { return vSwipeDelta; } }
    public bool mSwipeLeft { get { return vSwipeLeft; } }
    public bool mSwipeRight { get { return vSwipeRight; } }
    public bool mSwipeUp { get { return vSwipeUp; } }
    public bool mSwipeDown { get { return vSwipeDown; } }
    public bool mTap { get { return vTap; } }
}
