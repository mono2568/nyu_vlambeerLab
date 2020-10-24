using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class UIManager : MonoBehaviour
{

    private Image backGround;
    private Slider sliderR;
    private Slider sliderG;
    private Slider sliderB;

    private Slider sliderMaxTile;
    private Slider sliderRotatePercent1;
    private Slider sliderRotatePercent2;
    private Slider sliderPathMakerPercent;




    // Start is called before the first frame update
    void Start()
    {
        backGround = GameObject.Find("mainBackGround").GetComponent<Image>();
        sliderR = GameObject.Find("SliderR").GetComponent<Slider>();
        sliderG = GameObject.Find("SliderG").GetComponent<Slider>();
        sliderB = GameObject.Find("SliderB").GetComponent<Slider>();
        sliderMaxTile = GameObject.Find("SliderMaxTile").GetComponent<Slider>();
        sliderRotatePercent1 = GameObject.Find("SliderRotatePercent1").GetComponent<Slider>();
        sliderRotatePercent2 = GameObject.Find("SliderRotatePercent2").GetComponent<Slider>();
        sliderPathMakerPercent = GameObject.Find("SliderPathMakerPercent").GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        backGround.color = new Color(sliderR.value, sliderG.value, sliderB.value);
    }

    public void resetScene()
    {
        SceneManager.LoadScene("stageBuild");
        Pathmaker.countTile = 0;
    }

    public void createButton(int materialNum) {
        SceneManager.LoadScene("stageBuild");
        Pathmaker.countTile = 0;
        Pathmaker.materialNum = materialNum;
        Pathmaker.posSum = new Vector3(0, 0, 0);
        Pathmaker.maxTile = (int)(sliderMaxTile.value * 400 + 100);
        Pathmaker.rPercent1 = sliderRotatePercent1.value * 0.8f;
        Pathmaker.rPercent2 = sliderRotatePercent2.value * 0.8f;
        Pathmaker.createPathPercent = sliderRotatePercent2.value * 0.05f + 0.95f;
    }
}
