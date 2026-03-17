# Relatório de Qualidade – GQM

## Objetivo
Assegurar que todos os defeitos sejam corrigidos antes da liberação do software.

---

## Perguntas e Respostas

### 1. O software pode ser liberado para uso com esses dados?
Não.

Ainda existem defeitos em aberto, a cobertura de testes está abaixo do ideal (75%) e a cobertura de requisitos também está baixa (70%). Esses fatores indicam risco para o usuário final.

---

### 2. Qual status de defeito é mais crítico?
O status mais crítico é **"aberto"**.

Isso porque indica que o defeito ainda não foi corrigido e pode impactar diretamente o funcionamento do sistema.

---

### 3. A cobertura de testes é suficiente?
Não.

A cobertura atual é de 75%, enquanto o recomendado é pelo menos 80%. Isso significa que ainda existem partes do sistema que não foram testadas adequadamente.

---

### 4. Que ações devem ser tomadas antes da entrega do software?

- Corrigir todos os defeitos em aberto
- Finalizar os defeitos que estão em teste
- Aumentar a cobertura de testes para pelo menos 80%
- Testar mais requisitos
- Executar testes de regressão

---

## Como executar o código em C# (Visual Studio)

1. Abrir o Visual Studio  
2. Clicar em **Criar Novo Projeto**  
3. Selecionar **Aplicativo de Console (.NET)**  
4. Nomear o projeto  
5. Substituir o conteúdo do arquivo `Program.cs` pelo código fornecido  
6. Pressionar **Ctrl + F5** para executar  

---

## ✅ Conclusão

O software ainda não está pronto para liberação. É necessário melhorar a qualidade através da correção de defeitos e aumento da cobertura de testes antes de disponibilizá-lo para uso.
