using System;

namespace IngreseLa9_TN5o_m_b_irneiAcipaelellsi_d_o_c_acranrén_e
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el monto de la compra: ");

            try
            {
                // Leer el monto ingresado por el usuario
                decimal montoCompra = decimal.Parse(Console.ReadLine());

                // Aplicar descuento según el criterio
                decimal descuento = 0;

                if (montoCompra < 400)
                {
                    // No hay descuento
                }
                else if (montoCompra <= 1000)
                {
                    descuento = 0.07m; // 7% de descuento
                }
                else if (montoCompra <= 5000)
                {
                    descuento = 0.10m; // 10% de descuento
                }
                else if (montoCompra <= 15000)
                {
                    descuento = 0.15m; // 15% de descuento
                }
                else
                {
                    descuento = 0.25m; // 25% de descuento
                }

                // Verificar si hay código de descuento
                Console.WriteLine("¿Tiene un código de descuento? (S/N): ");
                string tieneCodigoDescuento = Console.ReadLine();

                if (tieneCodigoDescuento.ToUpper() == "S")
                {
                    descuento += 0.05m; // Agregar 5% de descuento adicional
                }

                // Calcular monto final
                decimal montoFinal = montoCompra - (montoCompra * descuento);

                // Mostrar el monto final a pagar
                Console.WriteLine($"Monto final a pagar: Q{montoFinal}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Por favor, ingrese un monto válido.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error inesperado: {ex.Message}");
            }
        }
    }
}
