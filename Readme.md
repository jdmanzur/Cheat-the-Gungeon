# Cheat the Gungeon

## Conceito do projeto
Escolhemos fazer uma interface que nos permitem a usar "cheat" (truques especiais durante o jogo) em um jogo chamado  [Enter the Gungeon](https://store.steampowered.com/app/311690/Enter_the_Gungeon). Para isso, tivemos que implementar a interface, e o cheat do jogo.

### Pré-requisitos e recursos utilizados

O grupo utilizou a linguagem C# para desenvolver a implementação geral do projeto, além de importar as seguintes bibliotecas: Memory.dll.x64 e Memory.dll.x86 ambas desenvolvidas por NeWaGe,hollow87.
Para ajudar a entender melhor sobre o assunto, pesquisamos várias informações como [Como CHEATS e HACKS de jogos são criados?](https://www.youtube.com/watch?v=0w6Pb2p-r5o) para  compreender a implementação do cheat.

### Passo a passo

1. Baixamos o material disponível em [Cheat Engine](https://www.cheatengine.org/)
2. Procuramos com a ferramenta [Cheat Engine](https://www.cheatengine.org/) cada endereço dos dados do jogo que serão utilizados no cheat
3. Implementamos um programa em C# que detecta o endereço dos dados e modifica-os.
4. Implementamos uma interface de usuário para facilitar o uso do programa.

### Instalação
a)
 Tenha instalado o jogo Enter the Gungeon e o visual studio em sua máquina.
b)
  1. Baixe as bibliotecas citadas acima. 
  2. Inicie a execução do projeto no visual studio.
  

## Execução
Passos necessários para executar, rodar ou testar seu projeto. Vocês podem seguir o mesmo modelo dos exemplos de Instalação.

## Bugs/problemas conhecidos
Existe a possibilidade de falha na alteração da memória.O Cheat utiliza de uma base de endereço somado a offs sets, logo, existe a possibilidade que o resultado dessa soma chegue há um endereço nao relacionado ao jogo, possibilitando bugs no cheat.

### Exemplo:
O cheat usa como base a memória que está sendo executada durante o jogo, ou seja, para alterar a quantidade de dinheiro, é injetado um valor diretamente na memoria, durante a execução do jogo. Se o endereço não for o correto, a quantidade de dinheiro não será alterada. O mesmo acontece com a vida e os blanks.

## Autores
Guilherme Henrique Rodrigues
Rafael Jyo Kondo

## Imagens/screenshots

Print da tela Incial do Cheat
![Imagem](https://github.com/nyanham/Cheat-the-Gungeon/blob/master/screenshot_1.png)

Print do forms no visual studio
![Imagem](https://github.com/nyanham/Cheat-the-Gungeon/blob/master/screenshot_2.png)

Uso das bibliotecas, utilizando do metodo write alterar a memoria em execução.
![Imagem](https://github.com/nyanham/Cheat-the-Gungeon/blob/master/screenshot_3.png)

Uso das bibliotecas para encontrar o jogo em execução
![Imagem](https://github.com/nyanham/Cheat-the-Gungeon/blob/master/screenshot_4.png)

