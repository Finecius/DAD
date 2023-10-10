#include <stdio.h>
#include <locale.h>
int main(){
int i,v[10],v2[10],s[10];
setlocale (LC_ALL,"");
printf("DIgite n�meros para o 1 vetor\n");
for (i=0;i<10;i++){
scanf("%d",&v[i]);
}
printf("DIgite n�meros para o 2 vetor\n");
for (i=0;i<10;i++){
scanf("%d",&v2[i]);
}
for(i=0;i<10;i++){
    s[i]=(v[i]+v2[i]);
    printf("\nA soma da posi��o %d dos vetores � igual a %d\n",i+1,s[i]);
    }
}
