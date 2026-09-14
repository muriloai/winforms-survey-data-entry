using System;
using System.Collections.Generic;

namespace SurveyDataEntry
{
    public class objeto_pergunta_respondida
    {
        private List<objeto_resposta_respondida> respostas = new List<objeto_resposta_respondida>();
        private int id_pergunta = 0;
        private int maxPerm = 0;

        public void setID_pergunta(int id_perg)
        {
            this.id_pergunta = id_perg;
        }

        public int getId_pergunta()
        {
            return this.id_pergunta;
        }

        public void item_respondido(int id_resposta)
        {
            objeto_resposta_respondida novo = new objeto_resposta_respondida();
            novo.id_resposta = id_resposta;
            novo.tipo = 1;
            if (respostas.Count < this.maxPerm)
            {
                respostas.Add(novo);
            }
        }

        public void item_respondido(int id_resposta, string texto)
        {
            objeto_resposta_respondida novo = new objeto_resposta_respondida();
            novo.id_resposta = id_resposta;
            novo.texto = texto;
            novo.tipo = 2;
            if (respostas.Count < this.maxPerm)
            {
                respostas.Add(novo);
            }
        }

        public void item_respondido(int id_resposta, int indiceQttvo)
        {
            objeto_resposta_respondida novo = new objeto_resposta_respondida();
            novo.id_resposta = id_resposta;
            novo.tipo = 3;
            novo.valorQuantitativo = indiceQttvo.ToString();
            if (respostas.Count < this.maxPerm)
            {
                respostas.Add(novo);
            }
        }

        public List<objeto_resposta_respondida> getTodasResposta()
        {
            return respostas;
        }

        public void setMaxPerm(int maxPerm)
        {
            this.maxPerm = maxPerm;
        }

        public int getMaxPerm()
        {
            return this.maxPerm;
        }

        public int getQtdRespondida()
        {
            return respostas.Count;
        }

        public void remover_todasRespostas()
        {
            respostas.Clear();
        }
    }
}