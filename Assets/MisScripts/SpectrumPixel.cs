using UnityEngine;
using System.Collections;

public class SpectrumPixel : MonoBehaviour {
    public AudioSource miAudio;
    float[] spectrum = new float[256];

    public Renderer miObjeto;
    public Renderer miObjeto2;
    public Renderer miObjeto3;
    public Shader PixelS;
    public float misNiveles;
   
	
	
	void Update () {
       miAudio.GetSpectrumData(spectrum, 0, FFTWindow.Rectangular);
        Renderer rend = miObjeto;
        Renderer rend2 = miObjeto2;
        Renderer rend3 = miObjeto3;
        rend.material.shader = PixelS;
        rend2.material.shader = PixelS;
        rend3.material.shader = PixelS;
        //Valores a editar X y Y del CellSize
        rend.material.SetVector("_CellSize", new Vector4(misNiveles,misNiveles,0.01f, 0.01f));
        rend2.material.SetVector("_CellSize", new Vector4(misNiveles, misNiveles, 0.01f, 0.01f));
        rend3.material.SetVector("_CellSize", new Vector4(misNiveles, misNiveles, 0.01f, 0.01f));

        misNiveles = spectrum[1] * 0.5f;
    }
}
