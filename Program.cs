
    class Clientes
    {
        public string nome { get; set; }
        public string endereco { get; set; }
        public float valor { get; protected set; }
        public float valor_imposto { get; protected set; }
        public float total { get; protected set; }
        public virtual void Pagar_Imposto(float v)
        {
            this.valor = v;
            this.valor_imposto = this.valor * 10 / 100;
            this.total = this.valor + this.valor_imposto;
        }
    }


    class Pessoa_Fisica : Clientes
    {
        public string cpf { get; set; }
        public string rg { get; set; }
    }



    class Pessoa_Juridica : Clientes
    {
        public string cnpj { get; set; }
        public string ie { get; set; }
        public override void Pagar_Imposto(float v)
        {
            this.valor = v;
            this.valor_imposto = this.valor * 20 / 100;
            this.total = this.valor + this.valor_imposto;
        }
    }


namespace Atividade
{
    class Program
    {
        static void Main(string[] args)
        {
            float val_pag;
Console.WriteLine("Informar Nome");
string var_nome = Console.ReadLine();
Console.WriteLine("Informar Endereço");
string var_endereco = Console.ReadLine();
Console.WriteLine("Pessoa Física (f) ou Jurídica (j) ?");
string var_tipo = Console.ReadLine();


if (var_tipo == "f")
{
    // --- Pessoa Física ----
    Pessoa_Fisica pf = new Pessoa_Fisica();
    pf.nome = var_nome;
    pf.endereco = var_endereco;
    Console.WriteLine("Informar CPF:");
    pf.cpf = Console.ReadLine();
    Console.WriteLine("Informar RG:");
    pf.rg = Console.ReadLine();
    Console.WriteLine("Informar Valor de Compra:");
    val_pag = float.Parse(Console.ReadLine());
    pf.Pagar_Imposto(val_pag);
    Console.WriteLine("-------- Pessoa Física --------- ");
    Console.WriteLine("Nome ..........: " + pf.nome);
    Console.WriteLine("Endereço ......: " + pf.endereco);
    Console.WriteLine("CPF ...........: " + pf.cpf);
    Console.WriteLine("RG ............: " + pf.rg);
    Console.WriteLine("Valor de Compra: " +
    pf.valor.ToString("C"));
    Console.WriteLine("Imposto .......: " +
    pf.valor_imposto.ToString("C"));
    Console.WriteLine("Total a Pagar : " +
    pf.total.ToString("C"));
}
if (var_tipo == "j")
{


    // Pessoa Jurídica
    Pessoa_Juridica pj = new Pessoa_Juridica();
    pj.nome = var_nome;
    pj.endereco = var_endereco;
    Console.WriteLine("Informar CNPJ:");
    pj.cnpj = Console.ReadLine();
    Console.WriteLine("Informar IE:");
    pj.ie = Console.ReadLine();
    Console.WriteLine("Informar Valor de Compra:");
    val_pag = float.Parse(Console.ReadLine());
    pj.Pagar_Imposto(val_pag);
    Console.WriteLine("-------- Pessoa Jurídica ---------");
    Console.WriteLine("Nome ..........: " + pj.nome);
    Console.WriteLine("Endereço ......: " + pj.endereco);
    Console.WriteLine("CNPJ ..........: " + pj.cnpj);
    Console.WriteLine("IE ............: " + pj.ie);
    Console.WriteLine("Valor de Compra: " +
    pj.valor.ToString("C"));
    Console.WriteLine("Imposto .......: " +
    pj.valor_imposto.ToString("C"));
    Console.WriteLine("Total a Pagar : " +
    pj.total.ToString("C"));
}
        }
    }
}