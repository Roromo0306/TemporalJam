using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Roulette : MonoBehaviour
{
    [Header("Fuerzas")]
    public float minRotatePower = 1500f;
    public float maxRotatePower = 3000f;
    public float stopPower = 1500f;   

    [Header("Tiempos")]
    public float spinDuration = 5f;     

    [Header("Offset (grados)")]
    public float angleOffset = 22.5f;

    [Header("Recompensas (0‑7)")]
    public int[] sectorRewards = { 100, 200, 300, 400, 500, 600, 700, 800 };

    Rigidbody2D rb;
    bool spinning;
    bool decelerating;
    float spinTimer;      
    float waitTimer;      

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 0;
    }

    void Update()
    {
        if (!spinning) return;

       
        if (!decelerating)
        {
            spinTimer -= Time.deltaTime;
            if (spinTimer <= 0f)                
                decelerating = true;
            return;
        }

       
        float av = rb.angularVelocity;
        if (Mathf.Abs(av) > 0f)
        {
            float sign = Mathf.Sign(av);
            av -= sign * stopPower * Time.deltaTime;
            
            if (sign != Mathf.Sign(av)) av = 0f;
            rb.angularVelocity = av;
        }

       
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

    // Llamar desde botón
    public void Spin()
    {
        if (spinning) return;

        rb.angularVelocity = 0f;

        // Impulso aleatorio en sentido aleatorio 
        float torque = Random.Range(minRotatePower, maxRotatePower);
        torque *= Random.value < 0.5f ? 1 : -1;
        rb.AddTorque(torque, ForceMode2D.Impulse);

        spinTimer = spinDuration; 
        spinning = true;
        decelerating = false;
    }

  
    void GiveReward()
    {
        float z = transform.eulerAngles.z;
        z = (z + angleOffset) % 360f;
        int sector = Mathf.FloorToInt(z / 45f);   

        // Alinear visualmente
        transform.eulerAngles = new Vector3(0f, 0f, sector * 45f);

        int reward = sectorRewards[sector];
        Debug.Log($"¡Has ganado {reward} puntos!");
    }
}
