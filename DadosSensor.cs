using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class DadosSensor
{
    public DateTime DataHora { get; set; }
    public double Valor { get; set; }

    public DadosSensor(double valor)
    {
        DataHora = DateTime.Now;
        Valor = valor;
    }
}