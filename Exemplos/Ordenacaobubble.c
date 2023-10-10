#include <stdio.h>
int main(){
    int i,trocou,v[5],temp;
    for (i=0;i<5;i++){
        printf("\nDigite o %do. numero do vetor:",i+1);
        scanf("%d",&v[i]);
    }
    printf("\nVetor original:");
    for(i=0;i<5;i++)printf("%d\n",v[i]);
    do{
        trocou=0;
        for(i=0;i<5;i++){
            if(v[i]>v[i+1])
            {
                temp=v[i];
                v[i]=v[i+1];
                v[i+1]=temp;
                trocou=1;
            }
        }
    }while(trocou);
    printf("\nVetor ordenado:");
    for(i=0;i<5;i++)printf("%d\t",v[i]);
    printf("\n\n");
    return 0;
}