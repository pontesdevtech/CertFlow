# Certificados Automatizados - Sistema de Renomeação, Criptografia e Envio em Massa

## Contextualização

A gestão e o envio de certificados em PDF para alunos que concluem cursos em instituições de ensino é uma tarefa essencial, mas frequentemente sujeita a desafios relacionados à segurança, praticidade e conformidade legal. Antes deste projeto, o processo era inteiramente manual: arquivos eram renomeados um a um, enviados individualmente por e-mail e permaneciam desprotegidos, aumentando os riscos de acessos não autorizados.  

Este cenário, além de consumir tempo significativo, também apresentava lacunas em termos de segurança e compliance, especialmente com a **Lei Geral de Proteção de Dados (LGPD)**. Essa legislação exige que dados pessoais sejam tratados com o máximo rigor para garantir privacidade e confidencialidade, algo que não era plenamente garantido nos métodos tradicionais.

## A Solução

O sistema desenvolvido aborda esses desafios de forma direta, combinando **agilidade operacional** e **robustez na segurança dos dados**.  

### Funcionalidades Principais

1. **Renomeação Automática de Arquivos**  
   Os arquivos PDF são renomeados dinamicamente, utilizando o nome do aluno como referência, facilitando a organização e identificação dos documentos.

2. **Criptografia de Certificados**  
   Cada PDF gerado é protegido por senha, sendo esta o CPF do aluno. Essa abordagem:
   - **Aumenta a segurança** dos documentos, protegendo-os contra acessos não autorizados.
   - **Cumpre as exigências da LGPD**, ao evitar a exposição de dados sensíveis de forma inadvertida.

3. **Envio em Massa de Certificados**  
   O sistema realiza o envio de e-mails de forma automatizada e personalizada:
   - Cada aluno recebe uma mensagem nominal.
   - O certificado criptografado é enviado como anexo, assegurando que apenas o destinatário tenha acesso ao documento.

4. **Ganho de Eficiência**  
   A automação elimina erros manuais e reduz drasticamente o tempo necessário para concluir o processo, que antes exigia dias de trabalho, agora realizado em questão de minutos.

---

## Benefícios

### **Conformidade com a LGPD**  
O programa foi projetado com foco em boas práticas de segurança e privacidade, atendendo aos requisitos legais para tratamento de dados sensíveis.

### **Praticidade e Agilidade**  
A automação do processo permite que equipes se concentrem em tarefas mais estratégicas, enquanto o sistema realiza operações repetitivas de forma confiável e consistente.

### **Escalabilidade**  
Capaz de processar centenas ou até milhares de certificados em uma única execução, o sistema atende instituições de qualquer porte.

---

## Como Funciona

1. **Entrada de Dados**  
   Uma planilha contendo informações do aluno (nome, e-mail e CPF) é utilizada como base para personalização.

2. **Processamento dos Certificados**  
   - Renomeação dos arquivos conforme o nome do aluno.
   - Criptografia com senha personalizada (CPF do aluno).

3. **Envio Automatizado de E-mails**  
   Para cada aluno:
   - O sistema gera uma mensagem personalizada.
   - O certificado criptografado é anexado e enviado para o e-mail correspondente.

---

## Tecnologias Utilizadas

- **C#**: Linguagem principal utilizada no desenvolvimento do sistema, baseada na plataforma **.NET 8.0**.
- **Bibliotecas Utilizadas**:
  - `itext` (v8.0.5): Para geração, manipulação e criptografia de documentos PDF.
  - `itext7.bouncy-castle-adapter` (v8.0.5): Para suporte a algoritmos de criptografia avançados no processamento de PDFs.
  - `ExcelDataReader` (v3.7.0): Para leitura de dados a partir de arquivos Excel, permitindo extração eficiente de informações dos alunos.
  - `ExcelDataReader.DataSet` (v3.7.0): Complemento para transformar dados lidos em estruturas tabulares (DataSets) de forma prática.
- **Windows Forms**: Framework utilizado para o desenvolvimento da interface gráfica do sistema.
- **Ícones**: Provenientes da plataforma gratuita **Google Icons**, garantindo um design limpo e moderno.

---

## Considerações Finais

Este projeto foi desenvolvido com foco na segurança, eficiência e conformidade regulatória. Ele representa uma evolução significativa no processo de gestão de certificados em instituições de ensino, oferecendo uma solução que alia tecnologia à proteção de dados.

Sinta-se à vontade para explorar o código, adaptar às suas necessidades e contribuir com melhorias!  

**Contribua, utilize e torne o envio de certificados mais seguro e eficiente!**

