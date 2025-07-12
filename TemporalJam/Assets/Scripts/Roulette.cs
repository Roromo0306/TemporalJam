using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Roulette : MonoBehaviour
{
    /* ---------- Ajustes ---------- */
    [Header("Fuerzas")]
    public float minRotatePower = 1500f;
    public float maxRotatePower = 3000f;
    public float stopPower = 1500f;

    [Header("Tiempos")]
    public float spinDuration = 5f;   // Segundos de giro antes de empezar a frenar

    [Header("Offset (grados)")]
    public float angleOffset = 22.5f; // Para alinear los sectores

    [Header("Recompensas (0‑7)")]
    public int[] sectorRewards = { 100, 200, 300, 400, 500, 600, 700, 800 };

    /* ---------- Internos ---------- */
    Rigidbody2D rb;
    bool spinning;       // ¿Está girando?
    bool decelerating;   // ¿Ya estamos frenando?
    float spinTimer;      // Cuenta atrás hasta frenar
    float waitTimer;      // Pequeña pausa antes de dar la recompensa

    /* ---------- Inicialización ---------- */
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 0;  // Sin gravedad en 2D
    }

    /* ---------- Lógica por frame ---------- */
    void Update()
    {
        if (!spinning) return;

        /* 1) Mientras no frenamos, solo contamos tiempo */
        if (!decelerating)
        {
            spinTimer -= Time.deltaTime;
            if (spinTimer <= 0f)
                decelerating = true;
            return;
        }

        /* 2) Una vez frenamos, reducimos velocidad angular suavemente */
        float av = rb.angularVelocity;
        if (Mathf.Abs(av) > 0f)
        {
            float sign = Mathf.Sign(av);
            av -= sign * stopPower * Time.deltaTime;
            if (sign != Mathf.Sign(av)) av = 0f;  // Cuando cruza 0, lo fijamos
            rb.angularVelocity = av;
        }

        /* 3) Esperamos un momento tras detenerse para dar la recompensa */
        if (rb.angularVelocity != 0f) return;

        waitTimer += Time.deltaTime;
        if (waitTimer >= 0.5f)
        {
            GiveReward();
            spinning = false;
            decelerating = false;
            waitTimer = 0f;
        }
    }

    /* ---------- Método público para el botón ---------- */
    public void Spin()
    {
        if (spinning) return;

        // Desactivar el botón hasta que acabe el giro
        GameManager.I.DisableSpinButton();

        rb.angularVelocity = 0f;

        // Impulso aleatorio (sentido horario o antihorario)
        float torque = Random.Range(minRotatePower, maxRotatePower);
        torque *= Random.value < 0.5f ? 1 : -1;
        rb.AddTorque(torque, ForceMode2D.Impulse);

        spinTimer = spinDuration;
        spinning = true;
        decelerating = false;
    }

    /* ---------- Recompensa ---------- */
    void GiveReward()
    {
        // 1) Determinar sector (0‑7) según ángulo Z
        float z = transform.eulerAngles.z;
        z = (z + angleOffset) % 360f;
        int sector = Mathf.FloorToInt(z / 45f);

        // 2) Alinear la ruleta visualmente al sector exacto
        transform.eulerAngles = new Vector3(0f, 0f, sector * 45f);

        // 3) Obtener puntos
        int reward = sectorRewards[sector];

        // 4) Nombre del jugador actual y log
        string nombre = GameManager.I.GetCurrentPlayerName();
        Debug.Log($"{nombre} ha ganado {reward} puntos!");

        // 5) Sumar puntos y pasar turno
        GameManager.I.AddScoreToCurrentPlayer(reward);
    }
}

