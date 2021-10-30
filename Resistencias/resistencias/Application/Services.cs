using System;
using System.Collections.Generic;
using System.Linq;


namespace resistencias.Application
{
    public class Services
    {
        public string calcular_alcoholemia(string banda1, string banda2, string banda3, string banda4)
        {
            string valor = "";
            int resistencia = 0;
            double tolerancia = 0;
            string porcentaje = "";

            string color1 = banda1.ToLower();
            string color2 = banda2.ToLower();
            string color3 = banda3.ToLower();
            string color4 = banda4.ToLower();

            switch(color1)
            {
                case "negro":
                    valor = "0";
                    break;
                case "cafe":
                    valor = "1";
                    break;
                case "rojo":
                    valor = "2";
                    break;
                case "naranja":
                    valor = "3";
                    break;
                case "amarillo":
                    valor = "4";
                    break;
                case "verde":
                    valor = "5";
                    break;
                case "azul":
                    valor = "6";
                    break;
                case "violeta":
                    valor = "7";
                    break;
                case "gris":
                    valor = "8";
                    break;
                case "blanco":
                    valor = "9";
                    break;
                default:
                    return "Color No valido Para La Banda 1";
            }

            switch(color2)
            {
                case "negro":
                    valor += "0";
                    break;
                case "cafe":
                    valor += "1";
                    break;
                case "rojo":
                    valor += "2";
                    break;
                case "naranja":
                    valor += "3";
                    break;
                case "amarillo":
                    valor += "4";
                    break;
                case "verde":
                    valor += "5";
                    break;
                case "azul":
                    valor += "6";
                    break;
                case "violeta":
                    valor += "7";
                    break;
                case "gris":
                    valor += "8";
                    break;
                case "blanco":
                    valor += "9";
                    break;
                default:
                    return "Color No valido Para La Banda 2";
            }
            
            switch(color3)
            {
                case "negro":
                    resistencia = Convert.ToInt32(valor) * 1;
                    break;
                case "cafe":
                    resistencia = Convert.ToInt32(valor) * 10;
                    break;
                case "rojo":
                    resistencia = Convert.ToInt32(valor) * 100;
                    break;
                case "naranja":
                    resistencia = Convert.ToInt32(valor) * 1000;
                    break;
                case "amarillo":
                    resistencia = Convert.ToInt32(valor) * 10000;
                    break;
                case "verde":
                    resistencia = Convert.ToInt32(valor) * 100000;
                    break;
                case "azul":
                    resistencia = Convert.ToInt32(valor) * 1000000;
                    break;
                    default:
                    return "Color No valido Para La Banda 3";
            }

            switch(color4)
            {
                case "rojo":
                    tolerancia = resistencia * 0.02;
                    porcentaje = "2%";
                    break;
                case "dorado":
                    tolerancia = resistencia * 0.05;
                    porcentaje = "5%";
                    break;
                case "plata":
                    tolerancia = resistencia * 0.1;
                    porcentaje = "10%";
                    break;
                default:
                    return "Color No valido Para La Banda 4";
            }

            string result = "La Resistencia Es De " + resistencia + "Ω y Tiene Una Tolerancias Del " + porcentaje + ", Por Lo Que, Puede Soportar Valores Entre " + (resistencia + tolerancia) + "Ω y " + (resistencia - tolerancia) + "Ω";
            return result;
        }
    }
}