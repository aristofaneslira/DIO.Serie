using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIO.Series
{
    public class Serie : EntidadeBase{
        //Atributos

        private Genero Genero {get; set;}
        private String Titulo {get; set;}
        private String Descricao {get; set;}
        private int Ano {get; set;}
        private bool Excluido {get; set;}
    

    //Metodos

    public Serie(int id, Genero genero, string titulo, string descricao, int ano){
        this.Id = id;
        this.Genero = genero;
        this.Titulo = titulo;
        this.Descricao = descricao;
        this.Ano = ano;
        this.Excluido = false;
    } 

    public override string ToString(){
        String retorno = "";
        retorno += "Genero: " + this.Genero + Environment.NewLine;
        retorno += "Titulo: " + this.Titulo+ Environment.NewLine;
        retorno += "Descrição: " + this.Descricao + Environment.NewLine;
        retorno += "Ano de Inicio: " + this.Ano + Environment.NewLine;
        retorno += "Excluido: " + this.Excluido;
        return retorno;
    }

    public string retornaTitulo(){
        return this.Titulo;
    }

    public int retornaId(){
        return this.Id;
    }

    public bool retornaExcluido(){
        return this.Excluido;
    }

    public void Excluir(){
        this.Excluido = true;
    }

    }
}