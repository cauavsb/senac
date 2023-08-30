public static class Dados {
    public static Cadastrar cadastroAtual { get; set;}
    static Dados() {
        cadastroAtual = new Cadastrar();
    }
}