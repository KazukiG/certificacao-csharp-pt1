using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class Estruturas : IAulaItem
    {
        public void Executar()
        {
            PosicaoGPS posicao1;
            PosicaoGPS posicao2;

            posicao1 = new PosicaoGPS(13.78, 29.51);
            posicao2 = new PosicaoGPS(-20.90, 30.51);

            Console.WriteLine(posicao1);
            Console.WriteLine(posicao2);
        }
    }

    interface IGPS //porque a interface leva o metodo?
    {
        bool EstaNoHemisferioNorte();
    }

    struct PosicaoGPS : IGPS
    {
        public double Latitude;
        public double Longitude;

        public PosicaoGPS(double latitude, double longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
        }

        public bool EstaNoHemisferioNorte()
        {
            return Latitude > 0;
        }

        public override string ToString()
        {
            return $"Latitude: {Latitude}, Longitude: {Longitude}, Hemisfério Norte: {EstaNoHemisferioNorte()}";
        }
    }
}
