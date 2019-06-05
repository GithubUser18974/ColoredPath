using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FairZone : MonoBehaviour {
    private byte vFairZoneTransparency = 90;
    [SerializeField]
    private GameObject coloredWall1;
    [SerializeField]
    private GameObject coloredWall2;
    [SerializeField]
    private Renderer[] road1;
    [SerializeField]
    private Renderer[] road2;
    [SerializeField]
    private Renderer[] Zone1;
    [SerializeField]
    private Renderer[] Zone2;
    private static int mChange = 0;
    private Image mPanelBG1;
    private Image mPanelBG2;
    [SerializeField]
    private Renderer chrone;
    /// <summary>
    /// //////////////////////////////////      New code
    /// </summary>
    /// 
    private Color32[] cArr1,cArr2;

    // Use this for initialization
    void Start () {

        cArr1 = new Color32[3];
        cArr2 = new Color32[3];

        mPanelBG1 = coloredWall1.GetComponent<Image>();
        mPanelBG2 = coloredWall2.GetComponent<Image>();
        randomMChange();
        GroundColor();
        mColorZone_1();
        mColorZone_2();
        chrone.material.color = road1[0].material.color;
        cArr2 = cArr1;

    }


    public void mColorZone_1()
    {
        mFairZoneElement_1();
        ZoneColor_1();
        
        
    }
    public void mColorZone_2()
    {
        mFairZoneElement_2();
        ZoneColor_2();

    }
    void mFairZoneElement_1()
    {
        int tmp = randomMChange_0_3();
        mPanelBG1.color =new Color32( cArr2[tmp].r, cArr2[tmp].g, cArr2[tmp].b, vFairZoneTransparency);
    }
    void mFairZoneElement_2()
    {
        int tmp = randomMChange_0_3();
        mPanelBG2.color = new Color32(cArr2[tmp].r, cArr2[tmp].g, cArr2[tmp].b, vFairZoneTransparency);
    }
    void GroundColor()
    {   
             if (mChange == 1)
        {
            cArr1[0] = new Color32(255, 234, 43, 255);
            cArr1[1] = new Color32(36, 255, 46, 255);
            cArr1[2] = new Color32(255, 36, 130, 255);

            road1[0].material.color = cArr1[0];
            road1[1].material.color = cArr1[1];
            road1[2].material.color = cArr1[2];

            reshuffle(cArr1);

            road2[0].material.color = cArr1[0];
            road2[1].material.color = cArr1[1];
            road2[2].material.color = cArr1[2];

        }
        else if (mChange == 2)
        {
            cArr1[0] = new Color32(33, 35, 96, 255);
            cArr1[1] = new Color32(23, 117, 255, 255);
            cArr1[2] = new Color32(0, 255, 247, 255);

            road1[0].material.color = cArr1[0];
            road1[1].material.color = cArr1[1];
            road1[2].material.color = cArr1[2];

            reshuffle(cArr1);

            road2[0].material.color = cArr1[0];
            road2[1].material.color = cArr1[1];
            road2[2].material.color = cArr1[2];
        }
        else if (mChange == 3)
        {
            cArr1[0] = new Color32(63, 136, 197, 255);
            cArr1[1] = new Color32(215, 38, 56, 255);
            cArr1[2] = new Color32(80, 80, 87, 255);

            road1[0].material.color = cArr1[0];
            road1[1].material.color = cArr1[1];
            road1[2].material.color = cArr1[2];

            reshuffle(cArr1);

            road2[0].material.color = cArr1[0];
            road2[1].material.color = cArr1[1];
            road2[2].material.color = cArr1[2];
        }
        else if (mChange == 4)
        {
            cArr1[0] = new Color32(85, 53, 85, 255);
            cArr1[1] = new Color32(117, 91, 105, 255);
            cArr1[2] = new Color32(173, 241, 210, 255);

            road1[0].material.color = cArr1[0];
            road1[1].material.color = cArr1[1];
            road1[2].material.color = cArr1[2];

            reshuffle(cArr1);

            road2[0].material.color = cArr1[0];
            road2[1].material.color = cArr1[1];
            road2[2].material.color = cArr1[2];
        }
        else if (mChange == 5)
        {
            cArr1[0] = new Color32(216, 220, 255, 255);
            cArr1[1] = new Color32(167, 101, 113, 255);
            cArr1[2] = new Color32(86, 86, 118, 255);

            road1[0].material.color = cArr1[0];
            road1[1].material.color = cArr1[1];
            road1[2].material.color = cArr1[2];

            reshuffle(cArr1);

            road2[0].material.color = cArr1[0];
            road2[1].material.color = cArr1[1];
            road2[2].material.color = cArr1[2];

        }
        else if (mChange == 6)
        {
            cArr1[0] = new Color32(210, 60, 119, 255);
            cArr1[1] = new Color32(118, 53, 133, 255);
            cArr1[2] = new Color32(25, 45, 146, 255);

            road1[0].material.color = cArr1[0];
            road1[1].material.color = cArr1[1];
            road1[2].material.color = cArr1[2];

            reshuffle(cArr1);

            road2[0].material.color = cArr1[0];
            road2[1].material.color = cArr1[1];
            road2[2].material.color = cArr1[2];
        }
        else if (mChange == 7)
        {
            cArr1[0] = new Color32(42, 41, 41, 255);
            cArr1[1] = new Color32(24, 189, 207, 255);
            cArr1[2] = new Color32(65, 108, 178, 255);

            road1[0].material.color = cArr1[0];
            road1[1].material.color = cArr1[1];
            road1[2].material.color = cArr1[2];

            reshuffle(cArr1);

            road2[0].material.color = cArr1[0];
            road2[1].material.color = cArr1[1];
            road2[2].material.color = cArr1[2];
        }
        else if (mChange == 8)
        {
            cArr1[0] = new Color32(234, 230, 158, 255);
            cArr1[1] = new Color32(191, 219, 129, 255);
            cArr1[2] = new Color32(26, 71, 24, 255);

            road1[0].material.color = cArr1[0];
            road1[1].material.color = cArr1[1];
            road1[2].material.color = cArr1[2];

            reshuffle(cArr1);

            road2[0].material.color = cArr1[0];
            road2[1].material.color = cArr1[1];
            road2[2].material.color = cArr1[2];
        }
        else if (mChange == 9)
        {
            cArr1[0] = new Color32(236, 227, 205, 255);
            cArr1[1] = new Color32(221, 171, 184, 255);
            cArr1[2] = new Color32(91, 120, 68  , 255);

            road1[0].material.color = cArr1[0];
            road1[1].material.color = cArr1[1];
            road1[2].material.color = cArr1[2];

            reshuffle(cArr1);

            road2[0].material.color = cArr1[0];
            road2[1].material.color = cArr1[1];
            road2[2].material.color = cArr1[2];
        }
        else if (mChange == 10)
        {
            cArr1[0] = new Color32(98, 181, 57, 255);
            cArr1[1] = new Color32(208, 128, 174, 255);
            cArr1[2] = new Color32(228, 237, 185, 255);

            road1[0].material.color = cArr1[0];
            road1[1].material.color = cArr1[1];
            road1[2].material.color = cArr1[2];

            reshuffle(cArr1);

            road2[0].material.color = cArr1[0];
            road2[1].material.color = cArr1[1];
            road2[2].material.color = cArr1[2];
        }
        else if (mChange == 11)
        {
            cArr1[0] = new Color32(0, 64, 255, 255);
            cArr1[1] = new Color32(119, 170, 255,255);
            cArr1[2] = new Color32(187, 238, 255, 255);

            road1[0].material.color = cArr1[0];
            road1[1].material.color = cArr1[1];
            road1[2].material.color = cArr1[2];

            reshuffle(cArr1);

            road2[0].material.color = cArr1[0];
            road2[1].material.color = cArr1[1];
            road2[2].material.color = cArr1[2];
        }
        else if (mChange == 12)
        {
            cArr1[0] = new Color32(255, 0, 231, 255);
            cArr1[1] = new Color32(0, 255, 56, 255);
            cArr1[2] = new Color32(252, 119, 2, 255);

            road1[0].material.color = cArr1[0];
            road1[1].material.color = cArr1[1];
            road1[2].material.color = cArr1[2];

            reshuffle(cArr1);

            road2[0].material.color = cArr1[0];
            road2[1].material.color = cArr1[1];
            road2[2].material.color = cArr1[2];
        }
        else if (mChange == 13)
        {
            cArr1[0] = new Color32(246, 191, 30, 255);
            cArr1[1] = new Color32(44, 176, 221, 255);
            cArr1[2] = new Color32(68, 74, 251, 255);

            road1[0].material.color = cArr1[0];
            road1[1].material.color = cArr1[1];
            road1[2].material.color = cArr1[2];

            reshuffle(cArr1);

            road2[0].material.color = cArr1[0];
            road2[1].material.color = cArr1[1];
            road2[2].material.color = cArr1[2];
        }
        else if (mChange == 14)
        {
            road1[0].material.color = cArr1[0];
            road1[1].material.color = cArr1[1];
            road1[2].material.color = cArr1[2];

            reshuffle(cArr1);

            road2[0].material.color = cArr1[0];
            road2[1].material.color = cArr1[1];
            road2[2].material.color = cArr1[2];
        }
        else if (mChange == 15)
        {
            road1[0].material.color = cArr1[0];
            road1[1].material.color = cArr1[1];
            road1[2].material.color = cArr1[2];

            reshuffle(cArr1);

            road2[0].material.color = cArr1[0];
            road2[1].material.color = cArr1[1];
            road2[2].material.color = cArr1[2];
        }
    }
    void randomMChange()
    {
        mChange = Random.Range(1, 6);
    }
    int  randomMChange_0_3()
    {
        return Random.Range(0, 3);
    }
    void ZoneColor_1()
    {
            Zone1[0].material.SetColor("_Color", new Color(mPanelBG1.color.r, mPanelBG1.color.g, mPanelBG1.color.b, 1));
    }
    void ZoneColor_2()
    {
        Zone2[0].material.SetColor("_Color", new Color(mPanelBG2.color.r, mPanelBG2.color.g, mPanelBG2.color.b, 1));
    }
    void reshuffle(Color32[] texts)
    {
        // Knuth shuffle algorithm :: courtesy of Wikipedia :)
        for (int t = 0; t < texts.Length; t++)
        {
            Color32 tmp = texts[t];
            int r = Random.Range(t, texts.Length);
            texts[t] = texts[r];
            texts[r] = tmp;
        }
    }
}
