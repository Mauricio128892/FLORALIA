/******************************************************************************

                              Online C++ Compiler.
               Code, Compile, Run and Debug C++ program online.
Write your code in this editor and press "Run" button to compile and execute it.

*******************************************************************************/

#include <stdio.h>

void mostrarMenu() {
    printf("\n--- Menu de Starbucks ---\n");
    printf("1. Cafe Americano - $50\n");
    printf("2. Latte - $60\n");
    printf("3. Capuccino - $65\n");
    printf("4. Pan dulce - $40\n");
    printf("5. Sandwich - $75\n");
    printf("6. Jugo natural - $45\n");
    printf("-------------------------\n");
}

int main() {
    char respuesta;
    char metodoPago;
    int opcion;
    
    printf("Bienvenido a Starbucks\n");
    printf("\nDesea realizar un pedido? (s/n): ");
    scanf(" %c", &respuesta);
    
    if (respuesta == 's' || respuesta == 'S') {
        mostrarMenu();
        printf("Seleccione una opcion del menu (1-6): ");
        scanf(" %d", &opcion);
        
        if (opcion >= 1 && opcion <= 6) {
            printf("\nProcesando pedido...\n");
            printf("Seleccione el metodo de pago (e: efectivo, t: tarjeta): ");
            scanf(" %c", &metodoPago);
            
            if (metodoPago == 'e' || metodoPago == 'E' || metodoPago == 't' || metodoPago == 'T') {
                printf("\nPago realizado con exito.\n");
                printf("Recibiendo pedido...\n");
                printf("Pedido completado.\n");
            } else {
                printf("Metodo de pago no valido. Cancelando pedido.\n");
            }
        } else {
            printf("Opcion no valida. Cancelando pedido.\n");
        }
    } else {
        printf("\nNo se realizo ningun pedido. Gracias por visitar Starbucks.\n");
    }
    
    return 0;
}