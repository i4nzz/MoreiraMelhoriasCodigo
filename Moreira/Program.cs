using System;
using System.Collections.Generic;
using System.Linq;

class Defeito
{
    public int Id { get; set; }
    public string Status { get; set; }
}

class Program
{
    static void Main()
    {
        List<Defeito> defeitos = new List<Defeito>
        {
            new Defeito { Id = 1, Status = "aberto" },
            new Defeito { Id = 2, Status = "corrigido" },
            new Defeito { Id = 3, Status = "em teste" },
            new Defeito { Id = 4, Status = "corrigido" },
            new Defeito { Id = 5, Status = "aberto" }
        };

        int testesPlanejados = 20;
        int testesExecutados = 15;

        int requisitosTotal = 10;
        int requisitosTestados = 7;

        Console.WriteLine("===== METRICAS DE QUALIDADE (GQM) =====");

        // Número total de defeitos
        Console.WriteLine($"Numero total de defeitos: {defeitos.Count}");

        // Defeitos por status
        var statusDefeitos = defeitos
            .GroupBy(d => d.Status)
            .ToDictionary(g => g.Key, g => g.Count());

        Console.WriteLine("\nDefeitos por status:");
        foreach (var s in statusDefeitos)
        {
            Console.WriteLine($"{s.Key}: {s.Value}");
        }

        // Cobertura de testes
        double coberturaTestes = (double)testesExecutados / testesPlanejados * 100;

        Console.WriteLine($"\nTestes planejados: {testesPlanejados}");
        Console.WriteLine($"Testes executados: {testesExecutados}");
        Console.WriteLine($"Cobertura de testes: {coberturaTestes:F2}%");

        // Cobertura de requisitos
        double coberturaRequisitos = (double)requisitosTestados / requisitosTotal * 100;

        Console.WriteLine($"\nRequisitos testados: {requisitosTestados}");
        Console.WriteLine($"Cobertura de requisitos: {coberturaRequisitos:F2}%");

        // Taxa de defeitos corrigidos (DESAFIO EXTRA)
        int corrigidos = defeitos.Count(d => d.Status == "corrigido");
        double taxaCorrecao = (double)corrigidos / defeitos.Count * 100;

        Console.WriteLine($"\nTaxa de defeitos corrigidos: {taxaCorrecao:F2}%");

        // Indicador de liberação
        bool podeLiberar = taxaCorrecao >= 80 &&
                           coberturaTestes >= 80 &&
                           coberturaRequisitos >= 80;

        Console.WriteLine("\nIndicador de liberacao:");
        Console.WriteLine(podeLiberar ? "APROVADO ✅" : "REPROVADO ❌");

        Console.ReadLine();
    }
}