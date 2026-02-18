using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace DesafioProjetoHospedagem.Models
{
    public class Pessoa
    {
        public Pessoa() { }
        public Pessoa(string nome)
        {
            Nome = nome;
        }
        public Pessoa(string nome, string sobrenome)
        {
           Nome=nome;
           Sobrenome=sobrenome;
        }
        public string Nome{get; set; }
        public string Sobrenome{get; set; }
        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();

}}