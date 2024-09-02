Microondas
Este projeto é uma simulação interativa de um painel de micro-ondas, desenvolvido para demonstrar o controle de programas de aquecimento pré-definidos e personalizados, integrados com um banco de dados PostgreSQL.

Tecnologias Utilizadas
C#: Linguagem de programação principal.
Windows Forms: Interface gráfica do usuário.
PostgreSQL: Banco de dados para gerenciamento de dados de programas.
Configuração do Banco de Dados
Para conectar-se ao banco de dados, modifique a string de conexão no arquivo Microondas/Properties/DbConnection.cs. A estrutura e os dados do banco de dados estão descritos no arquivo Microondas/dbMicroondas.csv, que inclui o script para criação da tabela e dados iniciais para programas de aquecimento.

Instruções de Uso
Interface de Controle:

Painel Numérico: Insira valores clicando nos botões ou digitando diretamente no teclado.
Programas de Aquecimento: Adicione e gerencie programas de aquecimento personalizados. Programas pré-definidos não são editáveis, exceto o programa "Aquecimento", que permite ajustes de tempo (entre 1 segundo e 2 minutos) e potência.
Uso dos Programas:

Seleção de Programas: Clique duas vezes em um programa para selecioná-lo e depois clique em "Iniciar".
Botão "Iniciar": Caso o cronômetro esteja em 00:00, um aquecimento rápido de 30 segundos com potência 10 será ativado.
Botão "Parar": Pressione uma vez para pausar o cronômetro e uma segunda vez para cancelar o aquecimento.
Notas Importantes
Tempo em Segundos: Todos os tempos dos programas são cadastrados em segundos, mas são exibidos em minutos e segundos ao serem selecionados. Valores digitados manualmente são convertidos de acordo com a mesma lógica. Por exemplo, 85 segundos será exibido como 1 minuto e 25 segundos. Para tempos mais longos, continue digitando até alcançar o tempo desejado.
