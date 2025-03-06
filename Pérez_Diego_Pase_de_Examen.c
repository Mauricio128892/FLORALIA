#include <stdio.h>

int main() {
    int eleccion, confirmar, metodoPago;

    do {
        printf("\n====== Starbucks ======\n");
        // Productos del menú
        printf("Menu / Bebidas Calientes\n");
        
        printf("\nExpresso y Café\n");
        printf("1. Espresso - $30\n");
        printf("2. Espresso Doppio - $40\n");
        printf("3. Café del día - $50\n");
        printf("4. Espresso Americano - $60\n");
        
        printf("\nEspresso Tradicional\n");
        printf("5. Latte Macchiato - $30\n");
        printf("6. Flat White - $35\n");
        printf("7. Mocha Blanco - $40\n");
        printf("8. Mocha - $45\n");
        printf("9. Caramel Macchiato - $50\n");
        printf("10. Cappuccino - $55\n");
        printf("11. Latte - $60\n");
        
        printf("\nAlternativas al Café\n");
        printf("12. Chocolate Caliente - $30\n");
        printf("13. Chocolate Mexicano - $40\n");
        printf("14. Salir\n");
        
        printf("\nSeleccione una opción del menú: ");
        
        scanf("%d", &eleccion);

        if (eleccion >= 1 && eleccion <= 13) {
            printf("Has seleccionado una bebida. ¿Deseas confirmar tu pedido?\n");
            printf("1. Sí\n");
            printf("2. No\n");
            scanf("%d", &confirmar);
            

            if (confirmar == 1) {
                do {
                    printf("Selecciona un método de pago:\n");
                    printf("1. Efectivo\n");
                    printf("2. Tarjeta\n");
                    scanf("%d", &metodoPago);

                    if (metodoPago == 1 || metodoPago == 2) {
                        printf("Pago realizado con éxito. ¡Disfruta tu bebida!\n");
                        return 0; // Fin del programa
                    } else {
                        printf("Opción no válida. Intentalo nuevamente.\n");
                    }
                } while (metodoPago != 1 && metodoPago != 2);
            }
        } else if (eleccion == 14) {
            printf("Saliendo...\n");
            return 0;
        } else {
            printf("Opción no válida. Intenta nuevamente.\n");
        }

    } while (1); // Mantiene el menú hasta que el usuario termine

    return 0;
}