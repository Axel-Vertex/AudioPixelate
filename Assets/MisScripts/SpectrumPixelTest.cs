using UnityEngine;
using System.Collections;

public class SpectrumPixelTest : MonoBehaviour {
    // El Audiosource de la cámara
    public AudioSource miAudio;
    // nuestro array que puede tener un limite de 64 a 8192
    float[] spectrum = new float[256];
    // el Renderer de mi objeto 
    public Renderer miObjeto;
    // el float que cambiara junto con los valores dados por el SpectrumData de nuestro  audio
    public float misNiveles;

    void Update () {
        // En esta parte obtengo los valores dados por el audio 
        miAudio.GetSpectrumData(spectrum, 0, FFTWindow.Rectangular);
        // Levanto mi Renderer
        Renderer rend = miObjeto;
        //Aqui tengo Acceso al PixelateShader y muevo sus float de _CellSize con misNiveles en X y Y de Vector4
        rend.material.SetVector("_CellSize", new Vector4(misNiveles, misNiveles, 0.01f, 0.01f));
        //Pido del valor de mi array y lo multiplico por miNiveles haciendo que cambien en el Update
        misNiveles = spectrum[1] * 0.5f;
    }
}
