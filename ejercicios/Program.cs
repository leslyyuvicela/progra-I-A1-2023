using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicios
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Principal());
        }
    }
}
/*
Mini-repaso de como añadir un nuevo formulario a partir de lo que ya tienen:

1. Crean la tabla en la base de datos con los datos de lo que se va a meter en el formulario
2. En el id tienen que poner la propiedad es una identidad  como true.
3. Abajo, donde dice [Dbo][Table], cambien Table por el nombre que vayan a poner a la tabla 
4. DEN ACTUALIZAR EN LA TABLA
5. En los datos de la tabla, meten un par de filas de ejemplo para que el programa funcione bien
6. Crean el nuevo formulario
7. Copian todos los elementos, añaden o quitan textboxes segun cuantos datos vaya a tener el nuevo formulario
8. Ponen los nombres adecuados a cada elemento del diseño
9. En la tabla del form (dataGridView) editan las columnas para adaptarlas a los nuevos datos que haya. Header text _ es el nombre que se va a mostrar en la tabla, en *_Name* y DataPropertyName tienen que ponerle el nombre como lo tienen en la base de datos
10. Agreguen un errorProvider y ponganle de nombre erpTalCosa (TalCosa es el nombre que tienen en el formulario y la tabla)
11. Generen los eventos: Den doble clic en cada boton y en el formulario. Busquen el evento CellClick en la dataGrid y KeyUp en el textbox encima de la dataGrid.
12. En la clase Conexion, en el metodo obtenerDatos() copien las tres lineas antes de return miDs; peguenlas antes de return miDs y adaptenlas al nuevo form. (Vean la foto 1 para entender mejor)
13. Tambien en Conexion copien todo el metodo mantenimientoTalCosa() luego peguenlo justo despues y adaptenlo. (Foto 2)
14. En el codigo de un formulario que ya tengan, copien todo despues de public partial class talCosa : Form y peguenlo en su nuevo formulario en el mismo lugar
15. Denle en buscar y reemplazar,  seleccionen reemplazar en archivos, ponganle Coincidir mayúsculas y minúsculas, Buscar en: _ Documento actual,_ luego en buscar pongan el nombre del form que pegaron en minusculas y en reemplazar el nombre del nuevo form en minusculas, sin "s" al final luego repitan pero con inicial mayuscula
16. En las partes con error, reemplazen los elementos con los de los datos del nuevo formulario
17. En el form Principal busquen o creen el boton para abrir el nuevo formulario, denle doble clic y en el codigo que aparece pongan:
talCosa objTalCosa = new talCosa(); 
objTalCosa.MdiParent = this;
objTalCosa.Show();
Con esto ya tendrían listo su nuevo formulario :)
*/
