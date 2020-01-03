using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class FadeExtension
{
    // Start is called before the first frame update
    public static void Fade(this Transform transform)
    {
        transform.gameObject.AddComponent<ParticleSystem>();
        
    }

}
