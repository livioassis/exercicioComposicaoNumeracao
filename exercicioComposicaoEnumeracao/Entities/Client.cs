﻿using System;

namespace exercicioComposicaoEnumeracao.Entities
{
    class Client
    {
        public string Name { get; set; }
        public string EMail{ get; set; }
        public DateTime BirthDate { get; set; }

        public Client()
        {
        }

        public Client(string name, string eMail, DateTime birthDate)
        {
            Name = name;
            EMail = eMail;
            BirthDate = birthDate;
        }

        public override string ToString()
        {
            return
                Name +
                " (" +
                BirthDate.ToString("dd/MM/yyyy")
                + ") - " +
                EMail;
        }
    }
}
