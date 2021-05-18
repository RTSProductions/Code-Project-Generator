using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GenerateCode : MonoBehaviour
{
    public TextMeshProUGUI text;

    public string[] Project;

    public string[] ProjectType;

    public string[] ExtraInfo;

    public string[] launge;

    // Start is called before the first frame update
    void Start()
    {
        text.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    //generating new idea
    public void GenerateIdea()
    {
        int index = Random.Range(0, Project.Length);

        string Text = "Make A";

        Text += Project[index];

        index = Random.Range(0, ProjectType.Length);

        Text += ProjectType[index];

        index = Random.Range(0, ExtraInfo.Length);

        Text += ExtraInfo[index];

        index = Random.Range(0, launge.Length);

        Text += launge[index];

        text.text = Text;

    }
}
