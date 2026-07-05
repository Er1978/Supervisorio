using System.Text.Json.Serialization;

public class TelemetriaArduino
{
    [JsonPropertyName("n1")]
    public double Nivel1 { get; set; }

    [JsonPropertyName("n2")]
    public double Nivel2 { get; set; }

    [JsonPropertyName("VZ")]
    public double Vazao { get; set; }

    [JsonPropertyName("b1")]
    public int Bomba1 { get; set; }

    [JsonPropertyName("b2")]
    public int Bomba2 { get; set; }


    [JsonPropertyName("VB1")]
    public float TensaoBomba1 { get; set; }

    [JsonPropertyName("VB2")]
    public float TensaoBomba2 { get; set; }

    [JsonPropertyName("LV")]
    public int Valvula { get; set; }

    [JsonPropertyName("ackSP")]
    public float Setpoint { get; set; }

    [JsonPropertyName("LAL101")]
    public int LAL101 { get; set; }

    [JsonPropertyName("LAH102")]
    public int LAH102 { get; set; }

    [JsonPropertyName("LAL102")]
    public int LAL102 { get; set; }

    [JsonPropertyName("LAH101")]
    public int LAH101 { get; set; }

    [JsonPropertyName("ackM")]
    public int AckModo { get; set; }

    [JsonPropertyName("RL")]
    public int Emergencia { get; set; }
}