//William Jimenez 2021-1105//

#include <stdio.h>
int main ()
{
    int i, arreglo1[] = {2,2,2,2,2}, arreglo2[] = {5,5,5,5,5,}, arreglo3[] = {0,0,0,0,0};
    for(i = 0; i < 5; i++){
        arreglo3[i] = arreglo1[i] + arreglo2[i];
    }
    for(i = 0; i < 5; i++){
        printf("\n%d", arreglo3[i]);
    }
    return 0;
}