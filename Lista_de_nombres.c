#include <stdio.h>
#include <stdlib.h>
#include <string.h>

#define MAX_NAMES 100
#define MAX_NAME_LENGTH 50

char names[MAX_NAMES][MAX_NAME_LENGTH];
int num_names = 0;

int main() {
    int option;

    do {
        printf("Seleccionar una opcion:\n");
        printf("1. Agregar un nombre en la lista\n");
        printf("2. Leer la lista de nombres\n");
        printf("3. Salir\n");
        scanf("%d", &option);

        switch (option) {
            case 1:
                if (num_names == MAX_NAMES) {
                    printf("La lista esta llena.\n");
                    break;
                }
                printf("Introducir un nombre: ");
                scanf("%s", names[num_names]);
                num_names++;
                printf("Name added to the list.\n");
                break;
            case 2:
                if (num_names == 0) {
                    printf("La lista esta vacia.\n");
                    break;
                }
                printf("Lista de nombres:\n");
                for (int i = 0; i < num_names; i++) {
                    printf("%s\n", names[i]);
                }
                break;
            case 3:
                printf("Saliendo.\n");
                exit(0);
            default:
                printf("Opcion invalida.\n");
                break;
        }
    } while (option != 3);

    return 0;
}
