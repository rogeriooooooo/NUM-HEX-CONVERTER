[PT-BR]
Sistema de Conversão Hexadecimal e Numeral
Uma solução robusta para conversão de formatos de ID, projetada para integração com sistemas de crachás, controle de acesso e servidores de impressão em ambientes corporativos.

Visão Geral
Este sistema oferece uma maneira confiável e eficiente de converter valores entre formatos hexadecimal e numeral, especialmente desenvolvido para processar IDs de crachás de colaboradores. Ele garante compatibilidade entre múltiplos sistemas, como controle de acesso e servidores de impressão, que frequentemente exigem formatos de ID diferentes.

Principais Funcionalidades
Conversão Bidirecional

Converte valores hexadecimais para numerais e vice-versa.

Suporta valores grandes com ulong e BigInteger para escalabilidade.

Interface Amigável

Sistema interativo baseado em menus para facilidade de uso.

Prompts claros para entrada de dados, incluindo nome do colaborador e valores de ID.

Auditoria e Logs

Gera logs detalhados com timestamps, nomes dos colaboradores e resultados das conversões.

Os logs são salvos em um arquivo .txt para rastreamento e conformidade.

Métodos de Entrada Flexíveis

Aceita entrada via leitura de crachás ou inserção manual pelo operador do sistema.

Suporta formatos hexadecimal (com ou sem prefixo 0x) e numeral.

Tratamento de Erros

Manipulação robusta de exceções para lidar com entradas inválidas e casos extremos.

Mensagens de erro claras para facilitar a solução de problemas.

Casos de Uso
Integração com Sistemas de Crachás

Processa IDs de crachás para sistemas de controle de acesso.

Configuração de Servidores de Impressão

Testa e valida formatos de ID para compatibilidade com servidores de impressão.

Auditoria e Conformidade

Mantém um registro rastreável de todas as conversões para relatórios e depuração.

Detalhes Técnicos
Desenvolvido com: C# (.NET)

Tipos de Dados: Suporta ulong para valores grandes e BigInteger para escalabilidade ilimitada.

Formato de Logs:

Copy
[Timestamp] - [Nome do Colaborador] - [Numeral] - [Hexadecimal]  
Exemplo: 2024-01-10 14:30:00 - João Silva - 255 - 0xFF  
Flexibilidade de Entrada:

Hexadecimal: 0xFF, FF, ou ff (não sensível a maiúsculas/minúsculas).

Numeral: Valores inteiros padrão.

Por Que Usar Este Sistema?
Esta ferramenta foi desenvolvida para resolver o desafio comum de interoperabilidade de formatos de ID em ambientes corporativos. Ao fornecer um sistema de conversão simples, porém poderoso, ele elimina erros manuais, garante compatibilidade entre sistemas e mantém um registro detalhado para conformidade e solução de problemas.

Como Começar
Clone o repositório:

bash
Copy
git clone [https://github.com/rogeriooooooo/hex-numeral-converter.git](https://github.com/rogeriooooooo/NUM-HEX-CONVERTER.git)  
Abra o projeto no Visual Studio ou em sua IDE preferida para C#.

Compile e execute a aplicação.

----------------------------------------------------------
[EN-US]
Hexadecimal and Numeral Conversion System
A robust solution for seamless ID format conversion, designed for enterprise-level badge systems, access control, and print server integration.

Overview
This system provides a reliable and efficient way to convert between hexadecimal and numeral formats, specifically tailored for processing employee badge IDs. It ensures compatibility across multiple systems, including access control and print servers, which often require different ID formats.

Key Features
Dual Conversion Capability

Convert hexadecimal values to numerals and vice versa.

Supports large values with ulong and BigInteger for scalability.

User-Friendly Interface

Interactive menu-driven system for ease of use.

Clear prompts for operator input, including collaborator name and ID values.

Audit and Logging

Generates detailed logs with timestamps, collaborator names, and conversion results.

Logs are saved in a .txt file for easy tracking and compliance.

Flexible Input Methods

Accepts input from badge readers or manual operator entry.

Handles both hexadecimal (with or without 0x prefix) and numeral formats.

Error Handling

Robust exception handling to manage invalid inputs and edge cases.

Provides clear error messages for troubleshooting.

Use Cases
Badge System Integration

Process employee badge IDs for access control systems.

Print Server Configuration

Test and validate ID formats for print server compatibility.

Audit and Compliance

Maintain a traceable record of all conversions for reporting and debugging.

Technical Details
Built with: C# (.NET)

Data Types: Supports ulong for large values and BigInteger for unlimited scalability.

Logging Format:

Copy
[Timestamp] - [Collaborator Name] - [Numeral] - [Hexadecimal]  
Example: 2024-01-10 14:30:00 - John Doe - 255 - 0xFF  
Input Flexibility:

Hexadecimal: 0xFF, FF, or ff (case-insensitive).

Numeral: Standard integer values.

Why This System?
This tool was developed to address the common challenge of ID format interoperability in enterprise environments. By providing a simple yet powerful conversion system, it eliminates manual errors, ensures compatibility across systems, and maintains a detailed audit trail for compliance and troubleshooting.

Getting Started
Clone the repository:

bash
Copy
git clone [https://github.com/rogeriooooooo/hex-numeral-converter.git ](https://github.com/rogeriooooooo/NUM-HEX-CONVERTER.git) 
Open the project in Visual Studio or your preferred C# IDE.

Build and run the application.
