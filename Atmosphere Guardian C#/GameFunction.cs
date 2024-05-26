using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using UnityEditor.SceneManagement;

public class GameFunction : MonoBehaviour
{
    public GameObject Enemy;        // �ŧi����AEnemy
    public float time;              // �p��ɶ�

    public Text ScoreText;          // �ŧiText�AScoreText
    public int Score = 0;
    // �]�w�AInstance�A����L�{����Ū�� GameFunction.cs �̪��F��
    public static GameFunction Instance;

    public GameObject GameStartInterface;
    public GameObject GameTitle;    // �ŧi GameTitle ����
    public GameObject GameOverTitle;// �ŧi GameOverTitle ����
    public GameObject PlayButton;   // �ŧi PlayButton ����
    static public bool IsPlaying = false;
    static public bool InHomePage = true;

    public GameObject RestartButton;// �ŧi �}�l�C����r���D ����
    public GameObject QuitButton;   // �ŧi �h�X��r���D ����

    public GameObject SetButton;    // �ŧi �]�w���s ����
    public GameObject MajorSoundSlider;
    public GameObject GameSoundSlider;
    public GameObject SoundEffectSlider;
    public GameObject SoundImage;
    public GameObject SettingInterface;
    public GameObject CloseButton;
    public GameObject SoundText;

    // Start is called before the first frame update
    void Start()
    {
        Instance = this;            // ���wInstance�o�ӵ{��

        GameStartInterface.SetActive(true);
        GameTitle.SetActive(true);  
        GameOverTitle.SetActive(false);

        RestartButton.SetActive(false);
        QuitButton.SetActive(false);

        SetButton.SetActive(true);
        MajorSoundSlider.SetActive(false);
        GameSoundSlider.SetActive(false);
        SoundEffectSlider.SetActive(false);
        SoundImage.SetActive(false);
        SettingInterface.SetActive(false);
        CloseButton.SetActive(false);
        SoundText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;     // �W�[�ɶ�
        if (time > 1.0f && IsPlaying == true)
        {
            // �ŧi��m�AX : 2.5 ~ -2.5
            Vector3 pos = new Vector3(Random.Range(-5.5f, 5.5f), 4.5f, 0);
            // �ͦ��ĤH
            Instantiate(Enemy, pos, transform.rotation);
            time = 0f;
        }
    }

    public void AddScore()
    {
        Score += 10;                // �[����
        // ���ScoreText�����e
        ScoreText.text = "Score : " + Score;
    }

    public void GameStart()
    {
        IsPlaying = true;           // true �C�����b�i�椤
        InHomePage = false;

        GameStartInterface.SetActive(false);
        GameTitle.SetActive(false); // false �����
        PlayButton.SetActive(false); 
    }

    public void GameOver()      
    {
        IsPlaying = false;          // ����ͥ~�P�H
        GameOverTitle.SetActive(true);

        RestartButton.SetActive(true); 
        QuitButton.SetActive(true); 
    }

    //[System.Obsolete]
    public void ResetGame()         // RestartButton���\��
    {
        // Ū�����d(�wŪ�������d)
        Application.LoadLevel(Application.loadedLevel);
        //EditorSceneManager.LoadScene("Scen");
    }

    public void QuitGame()          // QuitButton���\��
    {
        Application.Quit();         // ���}���ε{��
    }

    public void SettingUp()
    {
        IsPlaying = false;
        
        MajorSoundSlider.SetActive(true);
        GameSoundSlider.SetActive(true);
        SoundEffectSlider.SetActive(true);
        SoundImage.SetActive(true);
        SettingInterface.SetActive(true);
        CloseButton.SetActive(true);
        SoundText.SetActive(true);
    }

    public void SettingDown()
    {
        MajorSoundSlider.SetActive(false);
        GameSoundSlider.SetActive(false);
        SoundEffectSlider.SetActive(false);
        SoundImage.SetActive(false);
        SettingInterface.SetActive(false);
        CloseButton.SetActive(false);
        SoundText.SetActive(false);

        if(InHomePage == false)
        {
            IsPlaying = true;
        }
    }
}
