using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;



[RequireComponent(typeof(AudioSource))]
public class Collector : MonoBehaviour
{

    public AudioClip impact;
    public AudioSource audioSource;

    public TextMeshProUGUI _points;
    public Text points;
    public int pumpkinPoints;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        SetCountText();
    }
    public void SetCountText()
    {
        _points.text = pumpkinPoints.ToString();
        points.text = pumpkinPoints.ToString();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private IEnumerator OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "pumpkin")
        {
            audioSource.PlayOneShot(impact, 0.7F); pumpkinPoints += 1;
            SetCountText();
            col.gameObject.transform.localScale = new Vector3(0, 0, 0);
            yield return new WaitForSeconds(2);
            col.gameObject.transform.localScale = new Vector3(50, 50, 50);
        }
    }
}
