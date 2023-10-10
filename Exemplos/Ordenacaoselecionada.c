#include <stdio.h>
int main (){
    int i,j,min,v[5];
      for (i=0;i<5;i++){
        printf("\nDigite o %do. numero do vetor:",i+1);
        scanf("%d",&v[i]);
    }
    printf("\nVetor original: \n");
    for(i=0;i<5;i++)printf("%d\n",v[i]);
    for(i=0;i<4;i++){
        min =i;
        for(j=(i+1);j<5;j++){
            if (v[j]<v[min])min=j;
        }
        if(i !=min){
            int temp = v[i];
            v[i]=v[min];
            v[min]=temp;
        }
    }
    printf("\nO vetor ordenado: ");

    for(i=0;i<5;i++)printf("%d\t",v[i]);
    return 0 ;
}