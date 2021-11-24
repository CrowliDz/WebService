using System.Threading.Tasks;
using WebService.Entities;

namespace WebService.Interfaces
// GENERICOS O TIPOS T: SON CLASES GENERICAS QUE SON DIFINADAS USANDO UN TIPO DE PARAMETRO: SON GUIAS QUE SIRVEN PARA APLICARSE
// EN EL DESARROLLO DE SOFTWARE PARA ELIMINAR MALOS DISEÑOS PROVOCANDO QUE EL PROGRAMADOR TENGA QUE REFACTORIZAR EL CODIGO FUENTE
// HASTA QUE QUEDE LEGIBLE Y EXTENSIBLE

//Clase vs clase abstracta vs interfaz : metodos-instancia/solo heredear/es un punto medio entre meotodos y propiedades
//(solo tiene las firmas de los metodos que se van a usar)

{
    public interface ITokenService
    {
        Task<string> CreateToken(AppUser user);
    }
}