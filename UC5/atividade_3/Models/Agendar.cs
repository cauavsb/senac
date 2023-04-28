using System;
using System.Collections.Generic;
public class Agendar
{
    private List<Cadastro> listaAgendamentos;

    public Agendar() {
        listaAgendamentos = new List<Cadastro>();
    }

    public void incluir(Cadastro agendamento) {
        listaAgendamentos.Add(agendamento);
    }

    public List<Cadastro> ListarAgendamentos() {
        return listaAgendamentos;
    }
}