using UnityEngine;
using System.Collections;

[RequireComponent(typeof(SpriteRenderer))]
public class SpritePlayer: MonoBehaviour
{
    public enum StartMode
    {
        AutoAfterDelay,   // se pone en marcha solo
        Manual            // requiere Play()
    }

    [Header("Modo de inicio")]
    public StartMode startMode = StartMode.AutoAfterDelay;
    [Tooltip("Segundos de espera si el modo es AutoAfterDelay")]
    public float autoDelay = 1f;

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
    public float frameTime = 0.05f;

    private SpriteRenderer sr;
    private float timer;
    private int index;
    private bool introDone;
    private bool playing;

    /* ───────────────────────────────────────────── */

    void Awake()
    {
        sr = GetComponent<SpriteRenderer>();
        transform.localScale = Vector3.one * 0.93f;   // escala fija
    }

    void Start()
    {
        if (startMode == StartMode.AutoAfterDelay)
            StartCoroutine(DelayedPlay(autoDelay));
    }

    private IEnumerator DelayedPlay(float delay)
    {
        yield return new WaitForSeconds(delay);
        Play();
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

        sr.sprite = sprites[index - introStart];
    }

    /// <summary>Inicia la animación (público para botones u otros scripts).</summary>
    public void Play()
    {
        if (sprites == null || sprites.Length == 0)
        {
            Debug.LogWarning($"{name}: sprites[] está vacío.");
            return;
        }

        index = introStart;
        introDone = false;
        timer = 0f;
        sr.sprite = sprites[0];   // frame 50
        playing = true;
    }
}
