#include <stdio.h>
#include <stdlib.h>


int main(int argc, char *argv[]){

    int *p;
    int *s;

    p = malloc(sizeof(int));
    *p = 10;

    s = malloc(20 * sizeof(char));
    printf (" Digite seu nome -  ");
    scanf("%s", s);

    printf("\n O valor de p é: %i | O nome é: %s \n ", *p, s);
    printf (" Endereco do ponteiro: %p", p);
   
    return 0;
}

