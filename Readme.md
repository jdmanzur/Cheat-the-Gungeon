# Cheat the Gungeon

## Conceito do projeto
Escolhemos fazer uma interface que nos permitem a usar "cheat" (truques especiais durante o jogo) em um jogo chamado  [Enter the Gungeon](https://store.steampowered.com/app/311690/Enter_the_Gungeon). Para isso, tivemos que implementar a interface, e o cheat do jogo.

### Pré-requisitos e recursos utilizados

O grupo utilizou a linguagem C# para desenvolver a implementação geral do projeto, além de importar as seguintes bibliotecas:
*
Para ajudar a entender melhor sobre o assunto, pesquisamos várias informações como [Como CHEATS e HACKS de jogos são criados?](https://www.youtube.com/watch?v=0w6Pb2p-r5o) para  compreender a implementação do cheat.

### Passo a passo

1. Baixamos o material disponível em [Cheat Engine](https://www.cheatengine.org/)
2. Procuramos com a ferramenta [Cheat Engine](https://www.cheatengine.org/) cada endereço dos dados do jogo que serão utilizados no cheat
3. Implementamos um programa em C# que detecta o endereço dos dados e modifica-os.
4. Implementamos uma interface de usuário para facilitar o uso do programa.

### Instalação
a)
 Tenha instalado o jogo Enter the Gungeon em sua máquina.
b)
  1. ......

## Execução
Passos necessários para executar, rodar ou testar seu projeto. Vocês podem seguir o mesmo modelo dos exemplos de Instalação.

## Bugs/problemas conhecidos
Existe a possibilidade de falha na alteração da memória. Cheat utiliza de uma base de endereço somado a offs sets, logo, existe a possibilidade que o resultado dessa soma chegue há um endereço nao relacionado ao jogo, possibilitando bugs no cheat.

### Exemplo:
O cheat usa como base a memória que está sendo executada durante o jogo, ou seja, para alterar a quantidade de dinheiro, é injetado um valor diretamente na memoria, durante a execução do jogo. Se o endereço não for o correto, a quantidade de dinheiro não será alterada. O mesmo acontece com a vida e os blanks.

## Autores
Guilherme Henrique Rodrigues
Rafael Jyo Kondo

## Imagens/screenshots
É necessário colocar pelo menos 3 imagens/screenshots do projeto, porém fiquem a vontade para colocar mais, a medida do que vocês acharem legal para ilustrar o projeto.

Para colocar imagens no Readme do Github, vocês podem usar o seguinte comando (abrir este Readme no modo raw ou como txt):

![Imagem](https://github.com/Infinitemarcus/Hackerspace-template/blob/master/exemplo.png)

É preferível que vocês usem imagens hospedadas no próprio GitHub do projeto. É só referenciar o link delas no comando acima.
