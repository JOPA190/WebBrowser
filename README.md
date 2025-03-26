# Navegador Web Simples

Este projeto em C# implementa um navegador web simples utilizando o controle `WebBrowser` do Windows Forms. O programa permite ao usuário navegar pela web, voltar para a página anterior, avançar para a próxima página e abrir URLs específicas.

## Funcionalidades

### 1. **Ajuste Dinâmico do Tamanho do Navegador**
   O tamanho do controle `WebBrowser` é ajustado automaticamente conforme o tamanho do formulário. O controle ocupa toda a área disponível da janela, com um pequeno espaçamento de 50 pixels na largura e 125 pixels na altura.

### 2. **Abrir URL**
   O usuário pode inserir uma URL na caixa de texto e clicar no botão **Abrir** para carregar a página web correspondente no controle `WebBrowser`. Se a URL inserida estiver incorreta ou faltando informações (como o protocolo `http://`), uma mensagem de erro será exibida.

### 3. **Voltar e Avançar**
   O usuário pode navegar pelas páginas visitadas clicando nos botões **Voltar** e **Avançar**, utilizando as funcionalidades de navegação do controle `WebBrowser`.

### 4. **Liberação de Recursos**
   Quando o formulário é fechado, os recursos usados pelo componente `WebBrowser` são liberados para evitar problemas de memória.

## Estrutura do Código

A aplicação é composta pela classe `Form1`, que controla as funcionalidades do navegador, com os seguintes métodos principais:

- **Form1_Resize**: Ajusta dinamicamente o tamanho do controle `WebBrowser` quando a janela é redimensionada.
- **Form1_FormClosed**: Libera os recursos usados pelo controle `WebBrowser` quando o formulário é fechado.
- **btn_Abrir_Click**: Abre a URL inserida na caixa de texto no controle `WebBrowser`.
- **btn_Voltar_Click**: Navega para a página anterior.
- **btn_Avançar_Click**: Navega para a próxima página.

## Dependências

- **System.Windows.Forms**: Para a interface gráfica com o usuário e controles de navegação.

## Instruções de Uso

1. **Abrir URL**: Insira uma URL na caixa de texto e clique no botão **Abrir** para carregar a página.
2. **Voltar e Avançar**: Use os botões **Voltar** e **Avançar** para navegar pelas páginas visitadas.
3. **Redimensionar a Janela**: O controle `WebBrowser` será redimensionado automaticamente conforme o tamanho da janela.

## Considerações Finais

Este sistema é um navegador web simples, útil para visualização de páginas da internet de forma integrada em uma aplicação Windows Forms. Ele pode ser expandido para incluir funcionalidades adicionais, como favoritos, histórico ou controle de cookies.
