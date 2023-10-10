#include <stdio.h>
#include <locale.h>

int main(){
setlocale(LC_ALL,"");
int x[4][4],c,d,maior,menor,r[4][4],i,j,q=0;

for (c=0;c<4;c++){
  printf("Linha: %d\n",c+1);
  for (d=0;d<4;d++){
    printf("\nDigite o %d número: ",d+1);
    scanf("%d",&x[c][d]);
    r[c][d]=x[c][d];
  }
}
maior = x[0][0];
menor = x[0][0];

for (c=0;c<4;c++){
  printf("Linha: %d\n",c+1);
  for (d=0;d<4;d++){
    if(x[c][d]>maior)
    maior=x[c][d];

    if (x[c][d]<menor)
    menor = x[c][d];
    for(i=0;i<4;i++){
        for(j=0;j<4;j++){
            if (x[c][d]==r[i][j])
                q++;
        }
    }

    printf("O número %d se repete %d\n",x[c][d],q);
    q=0;
  }
}


printf("o maior valor é: %d",maior);
printf ("o menor valor é: %d",menor);
return 0;
}
