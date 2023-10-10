#include <stdio.h>

int main(){
int c,v[10],i,r;
printf("Digite o número inicial: ");
scanf("%d",&i);
printf("Digite a razão de progressão aritmética: ");
scanf("%d",&r);
printf("Valor inicial = %d\nRazão = %d",i,r);
for(c=0;c<9;c++){
    v[c]=(i+r);
    i+=r;
    printf("\n%d\n",v[c]);
}

return 0;
}
