#include <stdio.h>
#include <stdlib.h>
#include <string.h>


typedef struct block bloco;
struct block{
    int id;
    char desc[30];
    struct block *prox;
};


int main(int argc, char const *argv[])
{
    //Independente - apenas um variavel pra guardar um endereco do tipo struct
	bloco *ApontaEndereco;
	
	ApontaEndereco = (bloco*)malloc(sizeof(bloco)); //Alocacao da mem para uma struct tipo bloco. ApontaEndereco sabe desse endereco
	ApontaEndereco->id = 1;
	strcpy(ApontaEndereco->desc, "PRIMEIRA TRANSACAO \n");
	ApontaEndereco-> prox = (bloco*)malloc(sizeof(bloco*));
	
	
	printf("\n Valor do ID apontado pela var: %d \n", ApontaEndereco->id);
	printf(" Valor da Descricao apontada pela var: %s \n\n", ApontaEndereco->desc);
	printf(" Endereco da Alocacao para proximo proximo bloco: %p \n\n", ApontaEndereco->prox);
	
	printf("Adicionando valores no novo bloco! \n\n");
	
	ApontaEndereco->prox->id = 2;
	strcpy(ApontaEndereco->prox->desc, "SEGUNDA TRANSACAO");
	ApontaEndereco->prox->prox = (bloco*)malloc(sizeof(bloco*)); //STRUCT 3 ALOCADA
	
	printf(" SEGUNDO BLOCO ADICIONADO NA LISTA... \n\n");
	
	printf("\n Valor do ID SEGUNDO BLOCO: %d \n", ApontaEndereco->prox->id);
	printf(" Valor da Descricao SEGUNDO BLOCO: %s \n\n", ApontaEndereco->prox->desc);
	
	//so confirmação de mais uma struct alocada

    ApontaEndereco->prox->prox->id= 3;
	strcpy(ApontaEndereco->prox->prox->desc, "TERCEIRA TRANSACAO");
	
	ApontaEndereco->prox->prox->prox = (bloco*)malloc(sizeof(bloco*)); //NESSE CASO, NÃO HÁ UMA 4 ESTRUTURA CRIADA. IREI MOSTRAR A MENSAGEM INFORMANDO ISSO
    
    printf(" VALORES ADICIONADOS PARA TERCEIRO BLOCO... \n\n");
	
	printf("\n Valor do ID TERCEIRO ITEM DA LISTA: %d \n", ApontaEndereco->prox->prox->id);
	printf("\n Valor da Descricao TERCEIRO ITEM DA LISTA: %s \n\n", ApontaEndereco->prox->prox->desc);
	
	ApontaEndereco->prox->prox->prox = (bloco*)malloc(sizeof(bloco*));
	
	
	system("pause");
}


