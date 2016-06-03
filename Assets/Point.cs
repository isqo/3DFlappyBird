using UnityEngine;
using System.Collections;
using Assets;

public class Point : MonoBehaviour {

    private float GetHitEffect;
    private float targY;
    private Vector3 PointPosition;
    public GUISkin PointSkin;
    public GUISkin PointSkinShadow;

    // Use this for initialization
    void Start () {
        PointPosition = transform.position + new Vector3(Random.Range(-1, 1), 0, Random.Range(-1, 1));
        targY = Screen.height / 2;
    }
	
    void OnGUI()
    {
        targY -= Time.deltaTime * 200;
        Vector3 screenPos2 = Camera.main.GetComponent<Camera > ().WorldToScreenPoint(PointPosition);
        GetHitEffect += Time.deltaTime * 30;
        GUI.color = new Color(1.0f, 1.0f, 1.0f, 1.0f - (GetHitEffect - 50) / 7);
        GUI.skin = PointSkinShadow;
        GUI.Label(new Rect(screenPos2.x + 8, targY - 2, 80, 70), "+" + Score.points.ToString());
        GUI.skin = PointSkin;
        GUI.Label(new Rect(screenPos2.x + 10, targY, 120, 120), "+" + Score.points.ToString());
    }

}
