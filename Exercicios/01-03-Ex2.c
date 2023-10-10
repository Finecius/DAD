#include <stdio.h>
#include <locale.h>

int main(){
setlocale(LC_ALL,"Portuguese");
int m[3][4],n[3][4],i,j,l,c,p=0,po=0,ml,mc;

for(i=0;i<3;i++){
    for(j=0;j<4;j++){
        printf("Digite um numero para a Linha %d e coluna %d: ",i+1,j+1);
        scanf("%d",&m[i][j]);
        n[i][j]=m[i][j];
    }
}
ml=m[0][0];
mc=m[0][0];
for(i=0;i<3;i++){
    for(j=0;j<4;j++){
        for(l=0;l<4;l++){
                if(m[i][j]<n[i][l]){
                        for(c=0;c<3;c++){
                            if(m[i][j]>n[c][j]){
                                p=m[i][j];
                                
                                printf("O ponto de sela e igual a: %d e a posição é\nLinha %d e Coluna %d",p,i+1,j+1);
                                return 0;
                            }
                        }

            }
        }
    }
}



return 0;
}
