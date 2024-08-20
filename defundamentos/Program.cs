using defundamentos;

internal class Program
{

    private static void Main(string[] args)
    {
        //        Aluno aluno1 = new Aluno();
        //        Aluno aluno2 = new Aluno();
        //        Aluno aluno3 = new Aluno();

        //        aluno1.Nome = "Ana Geremias";
        //        aluno1.RM = "3492";
        //        aluno1.Email = "anageremiias@gmail.com";
        //        aluno1.Nascimento = new DateOnly(2007, 01, 03);

        //        aluno2.Nome = "Ana Chiaramontte";
        //        aluno2.RM = "3489";
        //        aluno2.Email = "ana.chiaramontte@portalsesisp.org.br";
        //        aluno2.Nascimento = new DateOnly(2007, 05, 20);

        //        aluno3.Nome = " Beatriz Nascimento";
        //        aluno3.RM = "4503";
        //        aluno3.Email = "beatriz,silva124@portalsesisp.org.br";
        //        aluno3.Nascimento = new DateOnly(2007, 04, 08);

        //        // Imprimir na Tela
        //        Console.WriteLine("Aluno 1");
        //        Console.WriteLine("Nome: " + aluno1.Nome);
        //        Console.WriteLine("RM: " + aluno1.RM);
        //        Console.WriteLine("Email" + aluno1.Email);
        //        Console.WriteLine("Nascimento" + aluno1.Nascimento);
        //        Console.WriteLine("============================================");

        //        Console.WriteLine("Aluno 2");
        //        Console.WriteLine("Nome: " + aluno2.Nome);
        //        Console.WriteLine("RM: " + aluno2.RM);
        //        Console.WriteLine("Email: " + aluno2.Email);
        //        Console.WriteLine("Nascimento" + aluno2.Nascimento);
        //        Console.WriteLine("============================================");

        //        Console.WriteLine("Aluno 3");
        //        Console.WriteLine("Nome: " + aluno3.Nome);
        //        Console.WriteLine("RM: " + aluno3.RM);
        //        Console.WriteLine("Email" + aluno3.Email);
        //        Console.WriteLine("Nascimento" + aluno3.Nascimento);
        //        Console.WriteLine("============================================");

        //        // Instanciar um objeto do tipo produto
        //        produto p1 = new produto();
        //        p1.Codigo = 123456;
        //        p1.Nome = "Coca-cola 3 Litros";
        //        p1.Preco = 12.99;
        //        p1.Estoque = 96;
        //        //chamar o metodo quantidadeestoque
        //        p1.QuantidadeEstoque();
        //        p1.Estoque = 85;
        //        //chamar o metodo quantidadeestoque
        //        p1.QuantidadeEstoque();



        //        Console.WriteLine("========================================================");
        //        Console.WriteLine();


        //        carro carro1 = new carro();
        //        carro1.Marca = "Ferrari";
        //        carro1.Modelo = "488";
        //        carro1.Velocidade = 80;

        //        carro1.Acelerar();
        //        carro1.Desacelerando();
        //        carro1.Acelerar();
        //        carro1.Desacelerando();

        //        Console.WriteLine("===========================================================");
        //        Console.WriteLine();

        //        pessoa pessoa1 = new pessoa();
        //        pessoa1.Nome = "Anna";
        //        pessoa1.Idade = 17;

        //        pessoa1.Envelhecer(5);
        //        pessoa1.Envelhecer(2);

        //        Console.WriteLine("================================================================");
        //        Console.WriteLine();

        //        Funcionario func1 = new Funcionario();
        //        func1.Nome = "Ana";
        //        func1.Idade = 17;
        //        func1.Cargo = "Aprendiz";
        //        func1.Salario = 1400;

        //        func1.ApresentarSe();

        //        Console.WriteLine("======================================================");

        //        //Instanciar um Objeto
        //        Animal animal1 = new Animal();

        //        //Iserindo Dados no Atributo
        //        animal1.Especie = "Cachorro";

        //        //Chamando o metod objeto
        //        animal1.emitirSom();

        //        Console.WriteLine("O animal " + animal1.Especie + "emitiu um som");



        Gato gato = new Gato();
        gato.Nome = "Frajola";
        Console.WriteLine(gato.Nome + " faz: ");
        gato.emitirSom();

        Console.WriteLine();

        porco porco = new porco();
        porco.Nome = "toucinho";
        Console.WriteLine(porco.Nome + " faz: ");
        porco.emitirSom();

        Console.WriteLine();

        galo galo = new galo();
        galo.Nome = "Beatricio";
        Console.WriteLine(galo.Nome + " faz: ");
        galo.emitirSom();


        Console.WriteLine();

        personagem personagem = new personagem();


        personagem.Categoria = "Bruxa";
        personagem.Nome = "Louca Julia";
        personagem.Nivel = 20;
        personagem.Forca = 187;
        personagem.Agilidade = 5;
        personagem.Inteligencia = 100;
        personagem.Vida = 98;

        Console.WriteLine();

        Console.WriteLine("personagem");
        Console.WriteLine("Nome: " + personagem.Nome);
        Console.WriteLine("Categoria: " + personagem.Categoria);
        Console.WriteLine("Nivel: " + personagem.Nivel);
        Console.WriteLine("Forca: " + personagem.Forca);
        Console.WriteLine("Agilidade: " + personagem.Agilidade);
        Console.WriteLine("Inteligencia: " + personagem.Inteligencia);
        Console.WriteLine("Vida: " + personagem.Vida);

        Console.WriteLine("============================================");







        //Livro livro1 = new Livro();
        //livro1.Titulo = "Harry Potter";
        //livro1.Editora = "Editora Abril";
        //livro1.Autor = "j,k,h";
        //livro1.AnoLancamento = 2001;

        //Livro livro2 = new Livro();
        //livro2.Titulo = "Programando em C#";
        //livro2.Editora = "Editora Nova";
        //livro2.AnoLancamento = 1982;
        //livro2.Autor = "Gustavo Castello";

        //Livro livro3 = new Livro();
        //livro2.Titulo = "Pai Rico Pai Pobre";
        //livro2.Editora = "Minha Editora";
        //livro2.AnoLancamento = 2000;
        //livro2.Autor = "Cristiano de Paula";



    }
}