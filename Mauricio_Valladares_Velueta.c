#include <stdio.h>
#include <stdlib.h> // Para la función exit()

int main() {
    int opcionPrincipal, opcionBebida, confirmacion, metodoPago;

    do {
        printf("\n--- La Cafetera Feliz ---\n");
        printf("1. Ver el menú\n");
        printf("2. Salir\n");
        printf("Selecciona una opción: ");
        scanf("%d", &opcionPrincipal);

        switch (opcionPrincipal) {
            case 1: // Ver el menú
                printf("\n--- Nuestro Menú --- \n");
                printf("1. Café Matutino - $25\n");
                printf("2. Expreso Doble - $35\n");
                printf("3. Café del Día Especial - $45\n");
                printf("4. Americano Intenso - $55\n");
                printf("5. Latte Clásico - $50\n");
                printf("6. Capuchino Espumoso - $55\n");
                printf("7. Moca Delicia - $60\n");
                printf("8. Chocolate Caliente Cremoso - $40\n");
                printf("9. Té Chai Especiado - $45\n");
                printf("10. Volver al menú principal\n");
                printf("Selecciona tu bebida: ");
                scanf("%d", &opcionBebida);

                if (opcionBebida >= 1 && opcionBebida <= 9) {
                    printf("¿Confirmar pedido?\n1. Sí\n2. No\n");
                    scanf("%d", &confirmacion);

                    if (confirmacion == 1) {
                        do {
                            printf("Método de pago:\n1. Efectivo\n2. Tarjeta\n");
                            scanf("%d", &metodoPago);

                            if (metodoPago == 1 || metodoPago == 2) {
                                printf("¡Pedido confirmado! Gracias.\n");
                                break; // Sale del bucle de pago
                            } else {
                                printf("Opción inválida.\n");
                            }
                        } while (1);
                    }
                } else if (opcionBebida == 10) {
                    continue; // Vuelve al menú principal
                } else {
                    printf("Opción inválida.\n");
                }
                break;

            case 2: // Salir
                printf("¡Hasta luego!\n");
                exit(0);

            default:
                printf("Opción inválida.\n");
        }
    } while (1);

    return 0;
}