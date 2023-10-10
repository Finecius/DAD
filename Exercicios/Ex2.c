#include <stdio.h>
#include <locale.h>

int main(){
setlocale(LC_ALL,"");
int i,v[10],menor=0,maior=0;

for(i=0;i<10;i++){

    printf("Digite um numero para a posição %d do vetor: ",i+1);
    scanf("%d",&v[i]);
}
menor=v[0];
maior=v[0];
for(i=0;i<10;i++){

    if(menor > (v[i]))
       menor = (v[i]);

    if(maior < (v[i]))
    maior = (v[i]);
}
printf("O maior numero é o: %d\nO menor numero é o: %d",maior,menor);
return 0;
}
