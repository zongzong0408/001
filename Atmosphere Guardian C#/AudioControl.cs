using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioControl : MonoBehaviour
{
    public AudioMixer audioMixer;           // ���� Mixer �ܶq                                     

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetMasterVolume(float volume)       // ����D���q�����
    {
        audioMixer.SetFloat("MasterVolume", volume);
        // MasterVolume ���S�X�Ӫ� Master ���Ѽ�
    }

    public void SetGameSoundVolume(float volume)        // ����I�����֭��q�����
    {
        audioMixer.SetFloat("GameSoundVolume", volume);
        // MusicVolume ���S�X�Ӫ� Music ���Ѽ�
    }

    public void SetSoundEffectVolume(float volume)  // ����ĭ��q�����
    {
        audioMixer.SetFloat("SoundEffectVolume", volume);
        // SoundEffectVolume ���S�X�Ӫ� SoundEffect ���Ѽ�
    }
}
