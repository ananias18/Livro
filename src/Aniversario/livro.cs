namespace Aula9.Aniversario
{

    public class Livro
    {
        private string titulo;
        private string autor;
        private int totPaginas;
        private int pagAtual;
        private bool aberto;
        private Pessoa leitor;

        public Livro(string titulo, string autor, int totPaginas, Pessoa leitor) : base()
        {
            this.titulo = titulo;
            this.autor = autor;
            this.totPaginas = totPaginas;
            this.aberto = false;
            this.pagAtual = 0;
            this.leitor = leitor;
        }

        public String detalhes()
        {
            return "Titulo: " + this.titulo + "\nAutor: " + this.autor + "\nTotal de Paginas: " + this.totPaginas + "\nPagina Atual: " + this.pagAtual + "\nLivro Aberto: " + this.aberto + "\nLeitor: " + this.leitor.getName();
        }

        public string getTitulo()
        {
            return this.titulo;
        }
        public string getAutor()
        {
            return this.autor;
        }
        public int getTotpaginas()
        {
            return this.totPaginas;
        }
        public int getPagatual()
        {
            return this.pagAtual;
        }
        public bool getAberto()
        {
            return this.aberto;
        }
        public Pessoa getLeitor()
        {
            return this.leitor;
        }
        public void setTitulo(string t)
        {
            this.titulo = t;
        }
        public void setAutor(string a)
        {
            this.autor = a;
        }
        public void setTotpaginas(int to)
        {
            this.totPaginas = to;
        }
        public void setPagatual(int p)
        {
            this.pagAtual = p;
        }
        public void setAberto(bool ab)
        {
            this.aberto = ab;
        }
        public void setLeitor(Pessoa l)
        {
            this.leitor = l;
        }

        public void abrir()
        {
            this.aberto = true;
        }
        public void fechar()
        {
            this.aberto = false;
        }
        public void folhear(int p)
        {
            if(p > this.totPaginas){
                this.pagAtual = 0;
            }else{
                this.pagAtual = p;
            }
            this.pagAtual = p;
        }
        public void avancarPag()
        {
            this.pagAtual++;
        }
        public void voltarPag()
        {
            this.pagAtual--;
        }

}
}