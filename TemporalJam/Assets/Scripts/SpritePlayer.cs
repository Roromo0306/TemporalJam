using UnityEngine;

/// <summary>
/// Reproduce una secuencia de sprites:
///   • Intro  (introStart‑introEnd)    → una sola vez
///   • Loop   (loopStart‑loopEnd)      → infinitamente
/// Llamar a Play() para iniciar la animación.
/// </summary>
[RequireComponent(typeof(SpriteRenderer))]
public class SpritePlayer : MonoBehaviour
{
    [Header("Sprites numerados consecutivamente")]
    [Tooltip("Arrastra aquí los frames 0050‑0149 en orden")]
    public Sprite[] sprites;

    [Header("Rangos (inclusive) dentro de la numeración")]
    public int introStart = 50;   // 0050
    public int introEnd = 110;  // 0110
    public int loopStart = 111;  // 0111
    public int loopEnd = 149;  // 0149

    [Header("Velocidad")]
    [Tooltip("Duración de cada frame en segundos")]
    public float frameTime = 0.05f;   // 20 fps

    private SpriteRenderer sr;
    private float timer;
    private int index;          // índice real (número de frame)
    private bool introDone;
    private bool playing;

    void Awake()
    {
        sr = GetComponent<SpriteRenderer>();

        // Escala fija al 93 %
        transform.localScale = Vector3.one * 0.93f;
    }

    void Update()
    {
        if (!playing) return;

        timer += Time.deltaTime;
        if (timer < frameTime) return;
        timer = 0f;

        if (!introDone)
        {
            index++;
            if (index > introEnd)
            {
                introDone = true;
                index = loopStart;
            }
        }
        else
        {
            index++;
            if (index > loopEnd) index = loopStart;
        }

        sr.sprite = sprites[index - introStart]; // desplaza para acceder al array
    }

    /// <summary>Inicia la animación.</summary>
    public void Play()
    {
        if (sprites == null || sprites.Length == 0)
        {
            Debug.LogWarning("SpriteSequencePlayer: sprites[] vacío.");
            return;
        }

        index = introStart;
        introDone = false;
        timer = 0f;
        sr.sprite = sprites[0];           // frame 50
        playing = true;
    }
}
