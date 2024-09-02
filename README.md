# Microondas

Este projeto simula um painel de micro-ondas, demonstrando o controle de programas de aquecimento pré-definidos e personalizados, integrados com um banco de dados PostgreSQL.

## Tecnologias Utilizadas

- **C#**: Linguagem de programação principal.
- **Windows Forms**: Interface gráfica do usuário.
- **PostgreSQL**: Banco de dados para gerenciamento de dados de programas.

## Configuração do Banco de Dados

1. **Conexão com o Banco de Dados**:
   - Modifique a string de conexão no arquivo `Microondas/Properties/DbConnection.cs` para conectar ao seu banco de dados PostgreSQL.

2. **Estrutura do Banco de Dados**:
   - O arquivo `Microondas/dbMicroondas.csv` contém o script para a criação da tabela e os dados iniciais para programas de aquecimento.

## Instruções de Uso

### Interface de Controle

- **Painel Numérico**: Insira valores clicando nos botões.
- **Programas de Aquecimento**: Adicione e gerencie programas personalizados. Programas pré-definidos não são editáveis, exceto o programa **"Aquecimento"**, que permite ajustes de tempo (entre 1 segundo e 2 minutos) e potência.

### Uso dos Programas
- **How-to**: Pode-se utilizar o browser para selecionar um programa ou clicar fora para insersão do próprio tempo.
- **Seleção de Programas**: Clique duas vezes em um programa para selecioná-lo e depois clique em **"Iniciar"**.
- **Botão "Iniciar"**: Quando o cronômetro estiver em `00:00`, um aquecimento rápido de 30 segundos com potência 10 será ativado.
- **Botão "Parar"**: Pressione uma vez para pausar o cronômetro e uma segunda vez para cancelar o aquecimento.

## Notas Importantes

- **Tempo em Segundos**: Todos os tempos dos programas são cadastrados em segundos, mas são exibidos em minutos e segundos ao serem selecionados. Valores digitados manualmente seguem a mesma lógica de conversão. Por exemplo, `85 segundos` será exibido como `1 minuto e 25 segundos`. Continue digitando até alcançar o tempo desejado.
