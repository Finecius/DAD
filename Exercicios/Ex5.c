#include <stdio.h>

int main(){
int i,v[9],v2[9],v3[9],r[9];

printf("Digite os valores do primeiro vetor\n");

for(i=0;i<9;i++){
    scanf("%d",&v[i]);
}

printf("Digite os valores do segundo vetor\n");

for(i=0;i<9;i++){
    scanf("%d",&v2[i]);
}

printf("Digite os valores do terceiro vetor\n");

for(i=0;i<9;i++){
    scanf("%d",&v3[i]);
}
printf("O resultado final é:");
for(i=0;i<9;i++){
    if(i<3)
        r[i]=v[i];

    if (i>=3 && i<6)
        r[i]=v2[i];

    if(i>=6)
        r[i]=v3[i];

    printf("\n%d\n",r[i]);
}
return 0;
}
