public static class Dados {
    public static Agendar agendamentoAtual { get; set;}
    static Dados() {
        agendamentoAtual = new Agendar();
    }
}