#include <stdio.h>
#include <stdlib.h>

typedef struct block bloco;
struct block{
    int id;
    char desc[50];
    struct block *prox;
};


int main(int argc, char const *argv[])
{
    bloco *p;

    bloco bloco1;
    bloco1.id = 100;

    p = &bloco1;

    printf("end bloco1 eh %p SEU ID eh %d \n", p, bloco1.id);

    return 0;
}
