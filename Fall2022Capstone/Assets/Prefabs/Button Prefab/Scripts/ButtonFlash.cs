using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonFlash : MonoBehaviour
{
    [SerializeField]
    private GameObject buttonCap;
    private Renderer buttonCapRenderer;

    void Start() {
        buttonCapRenderer = buttonCap.GetComponent<Renderer>();
        StartCoroutine(Fade());
    }

	IEnumerator Fade() {
        while (true) {
            for (float ft = 1f; ft >= 0; ft -= 0.05f) {
                buttonCapRenderer.material.SetColor("_BaseColor", new Color(ft, 1, ft, 1));
                yield return new WaitForSeconds(.1f);
            }
            for (float ft = 0f; ft <= 1; ft += 0.05f) {
                buttonCapRenderer.material.SetColor("_BaseColor", new Color(ft, 1, ft, 1));
                yield return new WaitForSeconds(.1f);
            }
        }
    }
}
