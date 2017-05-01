using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;


public class ExampleWindow : EditorWindow
{
    public string[] strArray = { "One", "Two", "Three", "Four" };
    public int selectiChoice = 0;
    public string s1 = "Super Cool Coders";
    public float f1, f2, f3, f4;
    public bool myBool = false;
    public Texture myTexture;
    public GUISkin mySkin;


    [MenuItem("CW/EX")]
    static void DisaplyWindow()
    {
        GetWindow<ExampleWindow>(true);
    }

    private void OnEnable()
    {
        myTexture =(Texture) EditorGUIUtility.Load("Blur.jpg");
        mySkin = (GUISkin)EditorGUIUtility.Load("ms.guiskin");
    }
    private void OnGUI()
    {

        float colSize = position.width / 10;
        GUI.skin = mySkin;
        GUI.DrawTexture(new Rect(0, 0, position.width, position.height), myTexture);
        GUILayout.Label(s1);
        s1 = GUILayout.TextArea(s1);
        selectiChoice = EditorGUILayout.IntSlider(selectiChoice,1,10);
        f1 = EditorGUILayout.FloatField(f1);
        if(GUILayout.Button("Button"))
        {
            myBool = !myBool;
        }
        myBool = EditorGUILayout.Toggle(myBool);
           

       /* GUILayout.Label("Example Window");
        s1 = GUILayout.TextField(s1);
        GUILayout.Space(10);
        GUILayout.Label("Sliders");


        GUILayout.BeginHorizontal();
        GUILayout.Label("f1", GUILayout.MaxWidth(colSize / 2));
        f1 = GUILayout.HorizontalSlider(f1, 0, 10);
        f1 = EditorGUILayout.FloatField(f1, GUILayout.MaxWidth(colSize));



        GUILayout.Label("f3", GUILayout.MaxWidth(colSize / 2));
        f3 = GUILayout.HorizontalSlider(f1, 0, 10);
        f3 = EditorGUILayout.FloatField(f3, GUILayout.MaxWidth(colSize));
        GUILayout.EndHorizontal();
        GUILayout.BeginVertical();
        GUILayout.EndVertical();


        GUILayout.BeginHorizontal();
        GUILayout.Label("f2", GUILayout.MaxWidth(colSize / 2));
        f2 = GUILayout.HorizontalSlider(f2, 0, 10);
        f2 = EditorGUILayout.FloatField(f2, GUILayout.MaxWidth(colSize));


        GUILayout.Label("f1", GUILayout.MaxWidth(colSize / 2));
        f4 = GUILayout.HorizontalSlider(f4, 0, 10);
        f4 = EditorGUILayout.FloatField(f4, GUILayout.MaxWidth(colSize));
        GUILayout.EndHorizontal();


        GUILayout.Space(10);
        
       selectiChoice= GUILayout.SelectionGrid(selectiChoice, strArray, 4);*/
    }


}
