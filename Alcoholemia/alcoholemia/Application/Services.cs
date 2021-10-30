using System;
using System.Collections.Generic;
using System.Linq;


namespace alcoholemia.Application
{
    public class Services
    {
        public string calcular_alcoholemia(string bebida, int cantidad, double peso)
        {
            int ml = 0;
            double grado_alcohol = 0;
            double alcoholemia = 0;
            double volmen_sangre = 0;
            string msg = "";

            switch(bebida.ToLower())
            {
                case "cerveza":
                ml = 330;
                grado_alcohol = 5;
                break;

                case "vino":
                ml = 100;
                grado_alcohol = 12;
                break;

                case "cava":
                ml = 100;
                grado_alcohol = 12;
                break;

                case "vermu":
                ml = 70;
                grado_alcohol = 17;
                break;

                case "licor":
                ml = 45;
                grado_alcohol = 23;
                break;

                case "brandy":
                ml = 45;
                grado_alcohol = 38;
                break;

                case "combinado":
                ml = 50;
                grado_alcohol = 38;
                break;

                default:
                return "Bebida No Valida";
            }

            alcoholemia = cantidad * ml;
            alcoholemia = (grado_alcohol / 100) * alcoholemia;
            alcoholemia = 0.15 * alcoholemia;
            alcoholemia = 0.789 * alcoholemia;
            volmen_sangre = 0.08 * peso;
            alcoholemia = alcoholemia / volmen_sangre;
            alcoholemia = Math.Round(alcoholemia, 3);

            if (0.8 < alcoholemia)
            {
                msg = "La Persoa No Es Apta Para Conducir. Solicita Un Taxi o Uber...";
            }
            else
            {
                msg = "Buen Viaje";
            }
            
            string result = "El Nivel De Alcohol En Sangre (Alcoholemia) Es: " + alcoholemia + "g/L " + msg;
            return result;
        }
    }
}