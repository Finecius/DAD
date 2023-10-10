#include <stdio.h>
#include <locale.h>

int main(){
setlocale(LC_ALL,"");
int v[16],i,v2[8];

for(i=0;i<16;i++){

    printf("Digite um numero da posição: %d do vetor:",i+1);
    scanf("%d",&v[i]);

    v2[i]=v[i];
}
for(i=0;i<8;i++){
v[i]=v[i+8];
}
for(i=0;i<8;i++){
    v[i+8]=v2[i];
}
for(i=0;i<16;i++){
    printf(" %d ",v[i]);
}
return 0;
}
