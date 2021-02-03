using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MultiAction : MonoBehaviour
{
    public Image m_valider;
    public Image m_fakebackground;
    public float waitTime;
    public bool m_ActiveValidate;
    public string m_failConnect;
    public string m_createAccount;
    public string m_questionMarkLink;
    public string m_lolLink;

    public GameObject m_mask;
    public AudioSource m_MainSound;
    public bool m_startsong;
    public Toggle m_toggleSong;
    
    public Image m_background;
    public Sprite m_wal1;
    public Sprite m_wal2;
    public Sprite m_wal3;
    public Sprite m_wal4;
    // Start is called before the first frame update
    void Start()
    {
        m_ActiveValidate = false;
        m_startsong = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            m_ActiveValidate = true;
            m_fakebackground.GetComponent<Image>().enabled = true;
        }

        if (m_ActiveValidate)
        {
            m_valider.fillAmount += 0.5f / waitTime * Time.deltaTime;
        }

        float m_maskValue = m_mask.GetComponent<CanvasGroup>().alpha;
        

        if (m_startsong == false)
        {
            if (m_maskValue > 0.8f)
            {
                m_startsong = true;
                StartCoroutine(PlayMainSong());
            }
        }
    }

    IEnumerator PlayMainSong()
    {
        m_MainSound.Play();
        yield return null;
    }

    public void MuteOnOffSong()
    {
        if (m_toggleSong.isOn) 
        {
            m_MainSound.mute = false;
        }
        else
        {
            m_MainSound.mute = true;
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
