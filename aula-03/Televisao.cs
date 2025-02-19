using System.Reflection;

namespace aula_03;

class Televisao
{
    //O método construtor possui o mesmo nome da classe. 
    //Ele não possui retorno (nem mesmo o void)
    //Este método é executado sempre que uma instancia da classe
    //é criada.
    //Por padrão, o C# cria um método construtor publico vazio, 
    //mas podemos criar métodos construtores com outras
    //visibilidades e recebendo parametros, se necessário.
    public Televisao(float tamanho)
    {
        if (tamanho < TAMANHO_MINIMO || tamanho > TAMANHO_MINIMO)
        {   
            //Uma exceção interrompe o fluxo normal do sistema.
            throw new ArgumentOutOfRangeException($"O tamanho ({tamanho}) não é suportado.");
        }
        Tamanho = tamanho;
        Volume = VOLUME_PADRAO;
    }

    //Optamos pela utilização da constante para tornar o código mais
    private const float TAMANHO_MINIMO = 22;
    private const float TAMANHO_MAXIMO = 80;
    private int VOLUME_MAXIMO = 12;
    private int VOLUME_MINIMO = 0;
    private int VOLUME_PADRAO = 10;



    //Get: permite que seja executada a
    //leitura do valor atual da propriedade
    //Set: permite que seja atribuído um
    //valor para a propriedade

    //As propriedades e métodos possuem modificadores de acesso
    //public: visiveis a todo o projeto
    //internal: visiveis somente no namespace
    //protected: visiveis somente na classe e nas classes que herdam
    //private: visiveis somente na classe que foram criados
    public float Tamanho { get; private set; }
    public int Resolucao { get; set; }
    public int Volume { get; private set; }
    public int Canal { get; set; }
    public bool Estado { get; set; }
    
    public void AumentarVolume()
    {

        Tamanho = 1_0000;

        if(Volume < VOLUME_MAXIMO)
        {
            Volume++;
        }
        else
        { 
            Console.WriteLine("A TV já está no volume máximo permitido");
        }
    }

    public void DiminuirVolume();
    {
        if (Volume > VOLUME_MINIMO)
        {
            Volume--;
        }
        else
        {
            Console.WriteLine("Esse é o volume minimo da TV");
        }
    }
}