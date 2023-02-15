#include<stdio.h>
#include<stdlib.h>

#define falso 0
#define verdadero 1
#define final 3


int main()
{
    int  tmp= 0;
    unsigned int i= 0;//indice
    char fin = falso; //vandra que indica fin de algoritmo 
    int a [4]; //array para almacenar los numeros a ordenar
    a[0]=10;
    a[1]=1;
    a[2]=8;
    a[3]=6;

    printf("\nelemento a[0] %d", a[0]);
    printf("\nelemento a[1] %d",  a[1]);
    printf("\nelemento a[2]  %d", a[2]);
    printf("\nelemento a[3]  %d" , a[3]);
fin = falso;
while(fin ==falso){
    fin =verdadero;
    for(i=0; i<3; i++){
        if(a[i] > a[i+1]){
            tmp = a[i];
            a[i] = a[i+1];
            a[i+1] = tmp;
            fin = falso;
    
    }
    
    }

}
printf("\n-------odernador----------\n");
    printf("\nelemento a[0]: %d", a[0]);
    printf("\nelemento a[1]:%d",  a[1]);
    printf("\nelemento a[2]:  %d", a[2]);
    printf("\nelemento a[3] : %d" , a[3]);

return 0;
}