#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <ctype.h>

int main() {
    int i, trocou, t;
    char *nome = (char*) malloc(50 * sizeof(char));
    printf("Digite seu nome: ");
    fgets(nome, 50, stdin);
    t = strlen(nome);

    char temp[t+1];
    for ( i = 0; i<t; i++)
{
    nome[i]=toupper(nome[i]);
}

    printf("\nNome original: ");
    printf("%s", nome);

    do {
        trocou = 0;
        for (i = 0; i < t-1; i++) {
            if (nome[i] > nome[i+1]) {
                temp[i] = nome[i];
                nome[i] = nome[i+1];
                nome[i+1] = temp[i];
                trocou = 1;
            }
        }
    } while(trocou);

    printf("\nNome ordenado: ");
    printf("%s", nome);
    printf("\n\n");
    return 0;
}
