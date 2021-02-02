using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MultiAction : MonoBehaviour
{
    public Image m_valider;
    public float waitTime;
    public bool m_ActiveValidate;
    public string m_failConnect;
    public string m_createAccount;
    public string m_questionMarkLink;
    public string m_lolLink;

    public Image m_background;
    public Sprite m_wal1;
    public Sprite m_wal2;
    public Sprite m_wal3;
    public Sprite m_wal4;
    // Start is called before the first frame update
    void Start()
    {
        m_ActiveValidate = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            m_ActiveValidate = true;
        }

        if (m_ActiveValidate)
        {
            m_valider.fillAmount += 0.5f / waitTime * Time.deltaTime;
        }
    }

    public void FailConnectLol()
    {
        Application.OpenURL(m_failConnect);
    }

    public void CreateAccount()
    {
        Application.OpenURL(m_createAccount);
    }

    public void QuestionMarkUrl()
    {
        Application.OpenURL(m_questionMarkLink);
    }

    public void LeagueLink()
    {
        Application.OpenURL(m_lolLink);
    }

    public void Wall()
    {
        m_background.sprite = m_wal1;
    }

    public void Wall2()
    {
        m_background.sprite = m_wal2;
    }

    public void Wall3()
    {
        m_background.sprite = m_wal3;
    }

    public void Wall4()
    {
        m_background.sprite = m_wal4;
    }
}
