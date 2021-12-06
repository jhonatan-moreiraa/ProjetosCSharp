using System;
using System.Collections.Generic;
using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturaDeControle;
using CursoCSharp.ClassesEMetodos;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                //Fundamentos
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentários - Fundamentos", Comentarios.Executar},
                {"Variáveis e constantes - Fundamentos", VariaveisEConstantes.Executar},
                {"Inferência de tipos - Fundamentos", Inferencia.Executar},
                {"Interpolação - Fundamentos", Interpolacao.Executar},
                {"Notação ponto - Fundamentos", NotacaoPonto.Executar},
                {"Lendo dados - Fundamentos", LendoDados.Executar},
                {"Formatando números - Fundamentos", FormatandoNumero.Executar},
                {"Conversões - Fundamentos", Conversoes.Executar},
                {"Operadores aritméticos - Fundamentos", OperadoresAritmeticos.Executar},
                {"Operadores relacionais - Fundamentos", OperadoresRelacionais.Executar},
                {"Operadores lógicos - Fundamentos", OperadoresLogicos.Executar},
                {"Operadores de atribuição - Fundamentos", OperadoresAtribuicao.Executar},
                {"Operadores unários - Fundamentos", OperadoresUnarios.Executar},
                {"Operador ternário - Fundamentos", OperadorTernario.Executar},
                

                //Estrutura de controle
                {"Estrutura IF - Estrutura de controle", EstruturaIf.Executar},
                {"Estrutura IF/ELSE - Estrutura de controle", EstruturaIfElse.Executar},
                {"Estrutura IF/ELSE IF -Estrutura de controle", EstruturaIfElseIf.Executar},
                {"Estrutura SWITCH - Estrutura de controle", EstruturaSwitch.Executar},
                {"Estrutura While - Estrutura de controle", EstruturaWhile.Executar},
                {"Estrutura Do/While - Estrutura de controle", EstruturaDoWhile.Executar},
                {"Estrutura For - Estrutura de controle", EstruturaFor.Executar},
                {"Estrutura For Each - Estrutura de controle", EstruturaForEach.Executar},
                {"Usando Break - Estrutura de controle", UsandoBreak.Executar},
                
                //Classes e métodos 
                {"Membros - Classes e métodos", Membros.Executar},
                {"Construtores - Classes e métodos", Construtores.Executar},
                {"Métodos com retorno - Classes e métodos", MetodosComRetorno.Executar},
                {"Métodos estáticos - Classes e métodos", MetodosEstaticos.Executar},
                {"Atributos estáticos - Classes e métodos", AtributosEstaticos.Executar},
                {"Desafio Atributos - Classes e métodos", DesafioAtributo.Executar},
                {"Params - Classes e métodos", Params.Executar},
                {"Parametros nomeados - Classes e métodos", ParametrosNomeados.Executar},
                {"Getters and Setters - Classes e métodos", GetSet.Executar},
                {"Getters and Setters Second - Classes e métodos", GetSetSecond.Executar},
                {"Props - Classes e métodos", Props.Executar},
                {"Readonly - Classes e métodos", ReadOnly.Executar},
                {"Exemplo Enum - Classes e métodos", ExemploEnum.Executar},
                {"Struct - Classes e métodos", Struct.Executar},
                {"Valor vs Referência  - Classes e métodos", ValorVsReferencia.Executar},
                {"Parâmetros por referência  - Classes e métodos", ParametrosPorReferencia.Executar},
                {"Parâmetros padrão  - Classes e métodos", ParametrosPadrao.Executar},

            });

            central.SelecionarEExecutar();
        }
    }
}