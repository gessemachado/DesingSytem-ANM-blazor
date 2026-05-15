namespace SIGBM.Models;

public class CaractModel
{
    public string TipoBarragem { get; set; } = "";
    public string FaseVida { get; set; } = "";
    public string DataInicioConstrucao { get; set; } = "";
    public string DataInicioOperacao { get; set; } = "";
    public string DataDesativacao { get; set; } = "";
    public string DataInicioDescaracterizacao { get; set; } = "";
    public bool UsoPrincipalRejeitos { get; set; }
    public bool UsoPrincipalSedimentos { get; set; }
    public bool MassaConcreto { get; set; }
    public bool MassaRejeito { get; set; }
    public bool MassaTerraHomogenea { get; set; }
    public bool MassaEnrocamento { get; set; }
    public bool MassaTerraEnrocamento { get; set; }
    public string AlturaMaximaProjeto { get; set; } = "";
    public string AlturaMaximaAtual { get; set; } = "";
    public string ComprimentoCristaProjeto { get; set; } = "";
    public string ComprimentoCristaAtual { get; set; } = "";
    public string MaterialConstrucao { get; set; } = "";
    public string TipoFundacao { get; set; } = "";
    public string MetodoConstrutivo { get; set; } = "";
    public string DrenagemInterna { get; set; } = "";
    public string DrenagemSuperficial { get; set; } = "";
    public string InclinacaoTalude { get; set; } = "";
    public string Instrumentacao { get; set; } = "";
    public string VazaoProjeto { get; set; } = "";
    public string MinerioReservatorio { get; set; } = "";
    public string AreaReservatorio { get; set; } = "";
}
