#include <stdio.h>

int main(int argc, char const *argv[])
{
    int x = 10;
    int *p;

    p = &x;

    //vai mostrar o novo valor
    *p = 20;

    printf(" Ponteiro recebe endereco de X e mostra o valor que eh 20-> %d \n", *p);
    printf ("Aqui mostra o endereco do ponteiro P ->: %p \n",p);
    printf ("novo valor de x eh 20 -> %d \n", x);

    return 0;
}





