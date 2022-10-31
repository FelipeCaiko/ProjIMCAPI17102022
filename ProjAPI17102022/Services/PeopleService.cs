using ProjAPI17102022.Models;
using System;

namespace ProjAPI17102022.Services
{
    public class PeopleService
    {
        public Person CalculoIMC(PeopleDTO peopleDTO)
        {
            Person person = new Person();

            person.Nome = peopleDTO.Nome;
            person.Altura = peopleDTO.Altura;
            person.Peso = peopleDTO.Peso;
            person.SituacaoIMC = GetSituation(person.Peso / (person.Altura * person.Altura));
            return person;
        }

        private string GetSituation(float imc)
        {
            if (imc >= 18.5 && imc <= 24.9)
                return "Sua classificação é NORMAL!";
            else if (imc < 18.5)
                return "Sua classificação é MAGREZA!";
            else if (imc >= 25 && imc <= 29.9)
                return "Sua classificação é SOBREPESO!";
            else if (imc >= 30 && imc <= 39.9)
                return "Sua classificação é OBESIDADE!";
            else
                return "Sua classificação é OBESIDADE GRAVE!";
            return "";
        }
    }
}