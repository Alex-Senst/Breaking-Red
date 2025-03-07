using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;

    // ��Ч�ļ�
    public AudioClip bgMusicL1;
    public AudioClip bgMusicL2;
    public AudioClip rainSound;
    public AudioClip windSound;
    public AudioClip footstepSound;
    public AudioClip birdSound;
    public AudioClip bugSound;

    private AudioSource audioSource;

    void Awake()
    {
        // ȷ��ֻ��һ�� AudioManager ʵ��
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

        // ��ȡ AudioSource �����������Ч
        audioSource = GetComponent<AudioSource>();
    }

    // ���ű�������
    public void Start()
    {
        audioSource.clip = bgMusicL1;
        audioSource.Play();
    }

    // ����������Ч��������
    public void playWindSound()
    {
        audioSource.clip = windSound;
        audioSource.loop = true;  // ѭ������
        audioSource.Play();
    }

    public void playRainSound()
    {
        audioSource.clip = rainSound;
        audioSource.loop = true;
        audioSource.Play();
    }

    // ���ŽŲ���Ч
    public void playFootstepSound()
    {
        audioSource.PlayOneShot(footstepSound);  // ʹ�� PlayOneShot ����һ�νŲ���
    }

    // ���ų�����Ч����С�������
    public void playBirdSound()
    {
        audioSource.clip = birdSound;
        audioSource.loop = true;
        audioSource.Play();
    }

    public void playBugSound()
    {
        audioSource.clip = bugSound;
        audioSource.loop = true;
        audioSource.Play();
    }

    // ֹͣ��ǰ���ŵ���Ч
    public void stopSound()
    {
        audioSource.Stop();
    }

    // �����Ϊ��ͬ����/�����л���ͬ��Ч
    public void changeWeatherSound(string weatherType)
    {
        stopSound();  // ֹͣ��ǰ��Ч
        if (weatherType == "rain")
        {
            playRainSound();
        }
        else if (weatherType == "wind")
        {
            playWindSound();
        }
    }
}
