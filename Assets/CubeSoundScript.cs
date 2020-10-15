using System.Collections;
using UnityEngine;

public class CubeSoundScript : MonoBehaviour
{
    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        //コンポーネントを取得
        audioSource = GetComponent<AudioSource>();
        if (other.gameObject.tag == "GroundTag" || other.gameObject.tag == "CubeTag")
        {
            audioSource.Play();
        }
    }
}
