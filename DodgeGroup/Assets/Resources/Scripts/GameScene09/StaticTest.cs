using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class StaticT
{
    public int m_hp = 10;
    public static int m_tot = 0;

    public StaticT(int hp)
    {
        m_hp = hp;
        m_tot += m_hp;
    }
}

public class StaticTest : MonoBehaviour
{
    [SerializeField]
    Text m_text;
    int[] m_Score = new int[3];

    int Sum = 0;

    [SerializeField]
    Button m_BtnStart;
    [SerializeField]
    Button m_btnReset;


    private void Start()
    {
        m_BtnStart.onClick.AddListener(OnClickedStart);
        m_btnReset.onClick.AddListener(OnClickedReset);
        Initialize();
    }

    private void Initialize()
    {
        Result();
    }



    void OnClickedStart()
    {
        StaticT a = new StaticT(90);
        m_text.text += $"Score = {a.m_hp}, Total = {StaticT.m_tot}\n";
        StaticT b = new StaticT(80);
        m_text.text += $"Score = {b.m_hp}, Total = {StaticT.m_tot}\n";
        StaticT c = new StaticT(70);
        m_text.text += $"Score = {c.m_hp}, Total = {StaticT.m_tot}\n";
    }
    void OnClickedReset()
    {
        Result();
    }

    void Result()
    {
        StaticT a = new StaticT(90);
        m_text.text += $"Score = {a.m_hp}, Total = {StaticT.m_tot}\n";
        StaticT b = new StaticT(80);
        m_text.text += $"Score = {b.m_hp}, Total = {StaticT.m_tot}\n";
        StaticT c = new StaticT(95);
        m_text.text += $"Score = {c.m_hp}, Total = {StaticT.m_tot}\n";
    }
}
