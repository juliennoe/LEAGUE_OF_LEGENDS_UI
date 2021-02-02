using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeButton : MonoBehaviour
{
    [SerializeField]
    private Image m_messageWhite;
    [SerializeField]
    private Image m_text;

    [SerializeField]
    private Image m_notificationWhite;
    [SerializeField]
    private Image m_coeur;
    [SerializeField]
    private Text m_count;

    [SerializeField]
    private Image m_smartphoneWhite;
    [SerializeField]
    private Image m_phone;

    [SerializeField]
    private float waitTime;
    private float m_timer;
    public float DelayAmount = 1; // Second count
    public int GoldValue = 0;

    [SerializeField]
    private bool m_ActiveMessage = false;
    [SerializeField]
    private bool m_ActiveNotification = false;
    [SerializeField]
    private bool m_ActivePhone = false;

    public Animator a_phone;

    void Start()
    {
        m_messageWhite.fillAmount = 1.0f;
        m_text.fillAmount = 0f;
    }

    void Update()
    {
        if (m_ActivePhone)
        {
            m_smartphoneWhite.fillAmount -= 1.5f / waitTime * Time.deltaTime;
            m_phone.fillAmount += 1.5f / waitTime * Time.deltaTime;

        }
        else
        {
            m_smartphoneWhite.fillAmount += 1.0f / waitTime * Time.deltaTime;
            m_phone.fillAmount -= 2.0f / waitTime * Time.deltaTime;
        }

        if (m_ActiveMessage)
        {
            m_messageWhite.fillAmount -= 0.5f / waitTime * Time.deltaTime;
            m_text.fillAmount += 1.5f / waitTime* Time.deltaTime;

        }
        else
        {
            m_messageWhite.fillAmount += 1.0f / waitTime * Time.deltaTime;
            m_text.fillAmount -= 2.0f / waitTime * Time.deltaTime;
        }

        if (m_ActiveNotification)
        {
            m_notificationWhite.fillAmount -= 1.0f / waitTime * Time.deltaTime;
            m_coeur.fillAmount += 1.5f / waitTime * Time.deltaTime;

            m_timer += Time.deltaTime * 100;

            if (m_timer >= DelayAmount)
            {
                m_timer = 0f;
                if(GoldValue < 99)
                {
                    GoldValue++;
                    m_count.text = GoldValue.ToString();
                }
              
            }
        }
        else
        {
            GoldValue = 0;
            m_notificationWhite.fillAmount += 1.0f / waitTime * Time.deltaTime;
            m_coeur.fillAmount -= 2.0f / waitTime * Time.deltaTime;
            m_count.text = 0.ToString();
        }
    }

    public void ActiveMessage()
    {
        m_ActiveMessage = !m_ActiveMessage;
    }

    public void ActiveNotification()
    {
        m_ActiveNotification = !m_ActiveNotification;
    }

    public void ActivePhone()
    {
        m_ActivePhone = !m_ActivePhone;
    }

    public void ClickMessage()
    {
        a_phone.Play("CLICK_PHONE");
    }
   
}

