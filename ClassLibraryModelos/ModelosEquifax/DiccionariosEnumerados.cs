using ClassLibraryModelos.ModelosEquifax;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryModelos.ModelosEquifax
{
    internal class DiccionariosEnumerados
    {
        public Hashtable NaturalezasIntervinientes = new Hashtable()
        {
            { "00", new Nature { Code = "00", DescriptionEn = "SEVERAL CATEGORIES", DescriptionEs = "DIVERSAS" } },
            { "01", new Nature { Code = "01", DescriptionEn = "HOLDER", DescriptionEs = "TITULAR" } },
            { "02", new Nature { Code = "02", DescriptionEn = "SECOND HOLDER", DescriptionEs = "COTITULAR" } },
            { "04", new Nature { Code = "04", DescriptionEn = "GUARANTEE", DescriptionEs = "AVALISTA" } },
            { "05", new Nature { Code = "05", DescriptionEn = "GRANTOR", DescriptionEs = "CEDENTE" } },
            { "06", new Nature { Code = "06", DescriptionEn = "DEBTOR", DescriptionEs = "DEUDOR" } },
            { "07", new Nature { Code = "07", DescriptionEn = "PARTNER", DescriptionEs = "SOCIO COMANDITARIO" } }
        };

        public Hashtable ProductoOperacion = new Hashtable()
        {
            { "01", new Product { Code = "01", DescriptionEn = "AUTOMOBILE FINANCING", DescriptionEs = "FINANC. AUTOMOVILES" } },
            { "02", new Product { Code = "02", DescriptionEn = "CONSUMPTION FINANCING", DescriptionEs = "FINANC. CONSUMO" } },
            { "03", new Product { Code = "03", DescriptionEn = "PROPERTY LEASING", DescriptionEs = "LEASING INMOBILIARIO" } },
            { "04", new Product { Code = "04", DescriptionEn = "FURNITURE LEASING", DescriptionEs = "LEASING MOBILIARIO" } },
            { "05", new Product { Code = "05", DescriptionEn = "RECOVERY BY THIRD", DescriptionEs = "FACTORING" } },
            { "06", new Product { Code = "06", DescriptionEn = "MORTAGAGE", DescriptionEs = "PRESTAMO HIPOTECARIO" } },
            { "07", new Product { Code = "07", DescriptionEn = "PERSONAL LOAN", DescriptionEs = "PRESTAMOS PERSONALES" } },
            { "08", new Product { Code = "08", DescriptionEn = "CREDIT POLICY", DescriptionEs = "POLIZAS DE CREDITO" } },
            { "09", new Product { Code = "09", DescriptionEn = "CREDIT CARD", DescriptionEs = "TARJETAS DE CREDITO" } },
            { "10", new Product { Code = "10", DescriptionEn = "INSURANCE", DescriptionEs = "SEGUROS" } },
            { "11", new Product { Code = "11", DescriptionEn = "BUSINESS DISCOUNT", DescriptionEs = "DESCUENTO COMERCIAL" } },
            { "12", new Product { Code = "12", DescriptionEn = "OVERDRAFT CREDIT ACCOUNT", DescriptionEs = "DESCUENTOS EN C/C" } },
            { "13", new Product { Code = "13", DescriptionEn = "GUARANTEES", DescriptionEs = "AVALES Y GARANTIAS" } },
            { "14", new Product { Code = "14", DescriptionEn = "TELECOMMUNICATIONS", DescriptionEs = "TELECOMUNICACIONES" } },
            { "15", new Product { Code = "14", DescriptionEn = "EQUIPMENT FINANCING CREDIT", DescriptionEs = "FINANC. BIENES EQUI." } },
            { "16", new Product { Code = "14", DescriptionEn = "PRIVATE CARD", DescriptionEs = "TARJETA PRIVADA" } },
            { "17", new Product { Code = "14", DescriptionEn = "PAYMENT CARD", DescriptionEs = "TARJETA DE PAGO" } },
            { "18", new Product { Code = "14", DescriptionEn = "CREDIT FOR MACHINERY OR VEHICLE RENTING", DescriptionEs = "RENTING" } },
            { "19", new Product { Code = "14", DescriptionEn = "CREDIT FOR ASSETS RENTING", DescriptionEs = "ALQUILER" } },
            { "20", new Product { Code = "14", DescriptionEn = "RECOVER BY THIRD INSOLVENT CUSTOMERS", DescriptionEs = "FACTOR SIN RECURSO" } },
            { "21", new Product { Code = "14", DescriptionEn = "PAYMENT MANAGERS", DescriptionEs = "CONFIRMING" } },
            { "22", new Product { Code = "14", DescriptionEn = "BILL OF EXCHANGE", DescriptionEs = "LETRA DE CAMBIO" } },
            { "23", new Product { Code = "14", DescriptionEn = "MICROLOAN", DescriptionEs = "MICROCREDITO" } },
            { "24", new Product { Code = "14", DescriptionEn = "ELECTRICITY/GAS", DescriptionEs = "ELECTRICIDAD/GAS" } },
            { "25", new Product { Code = "14", DescriptionEn = "FUEL", DescriptionEs = "COMBUSTIBLE" } },
            { "26", new Product { Code = "14", DescriptionEn = "WATER", DescriptionEs = "AGUA" } },
            { "99", new Product { Code = "14", DescriptionEn = "OTHERS", DescriptionEs = "OTROS" } }
        };

        public Hashtable SituacionOperacion = new Hashtable()
        {
            { "01", new Situation { Code = "01", DescriptionEn = "FRIENDLY NEGOTIATION", DescriptionEs = "AMISTOSO" } },
            { "02", new Situation { Code = "02", DescriptionEn = "PRE-JUDICIAL", DescriptionEs = "PREJUDICIAL" } },
            { "03", new Situation { Code = "03", DescriptionEn = "JUDICIAL", DescriptionEs = "JUDICIAL" } },
            { "04", new Situation { Code = "04", DescriptionEn = "UNSUCCESSFUL", DescriptionEs = "FALLIDO" } },
            { "05", new Situation { Code = "05", DescriptionEn = "PAYMENTS SUSPENSION", DescriptionEs = "SUSPENSION DE PAGOS" } },
            { "06", new Situation { Code = "06", DescriptionEn = "BANKRUPTCY", DescriptionEs = "QUIEBRA" } },
            { "08", new Situation { Code = "08", DescriptionEn = "ASSETS WITH HIGH LIKELIHOODS OF UNPAID", DescriptionEs = "ACTIV. SUSP. REGULA." } },
            { "09", new Situation { Code = "09", DescriptionEn = "VOLUNTARY BANKRUPTCY", DescriptionEs = "CONCURSO VOLUNTARIO" } },
            { "10", new Situation { Code = "10", DescriptionEn = "INVOLUNTARY BANKRUPTCY", DescriptionEs = "CONCURSO NECESARIO" } },
            { "99", new Situation { Code = "99", DescriptionEn = "OTHERS", DescriptionEs = "OTROS" } }
        };

        /*TipoEntidad = new Hashtable
        {
            { "00", new { Code: "00", DescripcionEn: "SEVERAL CATEGORIES", DescripcionEs:  "DIVERSAS" } },
            { "01", new { Code: "01", DescripcionEn: "SEVERAL CATEGORIES", DescripcionEs:  "DIVERSAS" } },
            { "02", new { Code: "02", DescripcionEn: "SEVERAL CATEGORIES", DescripcionEs:  "DIVERSAS" } },
            { "03", new { Code: "03", DescripcionEn: "SEVERAL CATEGORIES", DescripcionEs:  "DIVERSAS" } },
            { "04", new { Code: "04", DescripcionEn: "SEVERAL CATEGORIES", DescripcionEs:  "DIVERSAS" } },
            { "05", new { Code: "05", DescripcionEn: "SEVERAL CATEGORIES", DescripcionEs:  "DIVERSAS" } },
            { "06", new { Code: "06", DescripcionEn: "SEVERAL CATEGORIES", DescripcionEs:  "DIVERSAS" } },
            { "07", new { Code: "07", DescripcionEn: "SEVERAL CATEGORIES", DescripcionEs:  "DIVERSAS" } },
            { "08", new { Code: "08", DescripcionEn: "SEVERAL CATEGORIES", DescripcionEs:  "DIVERSAS" } },
            { "09", new { Code: "09", DescripcionEn: "SEVERAL CATEGORIES", DescripcionEs:  "DIVERSAS" } },
            { "10", new { Code: "10", DescripcionEn: "SEVERAL CATEGORIES", DescripcionEs:  "DIVERSAS" } },
            { "11", new { Code: "11", DescripcionEn: "SEVERAL CATEGORIES", DescripcionEs:  "DIVERSAS" } },
            { "12", new { Code: "12", DescripcionEn: "SEVERAL CATEGORIES", DescripcionEs:  "DIVERSAS" } },
            { "13", new { Code: "13", DescripcionEn: "SEVERAL CATEGORIES", DescripcionEs:  "DIVERSAS" } },
            { "14", new { Code: "14", DescripcionEn: "SEVERAL CATEGORIES", DescripcionEs:  "DIVERSAS" } },
            { "15", new { Code: "15", DescripcionEn: "SEVERAL CATEGORIES", DescripcionEs:  "DIVERSAS" } },
            { "16", new { Code: "16", DescripcionEn: "SEVERAL CATEGORIES", DescripcionEs:  "DIVERSAS" } },
            { "17", new { Code: "17", DescripcionEn: "SEVERAL CATEGORIES", DescripcionEs:  "DIVERSAS" } },
            { "18", new { Code: "18", DescripcionEn: "SEVERAL CATEGORIES", DescripcionEs:  "DIVERSAS" } },
            { "19", new { Code: "19", DescripcionEn: "SEVERAL CATEGORIES", DescripcionEs:  "DIVERSAS" } },
            { "20", new { Code: "20", DescripcionEn: "SEVERAL CATEGORIES", DescripcionEs:  "DIVERSAS" } },
            { "50", new { Code: "50", DescripcionEn: "SEVERAL CATEGORIES", DescripcionEs:  "DIVERSAS" } },
            { "99", new { Code: "99", DescripcionEn: "SEVERAL CATEGORIES", DescripcionEs:  "DIVERSAS" } }
        };*/

        public Hashtable CodigosAsnef = new Hashtable()
        {
            { "000", new Error{ Code = "000", Description = "Si existen datos para la petición realizada" }},
            { "001", new Error { Code = "001", Description = "No existen datos para la petición realizada" } },
            { "101", new Error { Code = "101", Description = "Formato de datos incorrecto" } },
            { "102", new Error { Code = "102", Description = "NIF/NIE/CIF no informado" } },
            { "103", new Error { Code = "103", Description = "NIF/NIE/CIF incorrecto" } },
            { "104", new Error { Code = "104", Description = "Organismo reclamante no informado" } },
            { "105", new Error { Code = "105", Description = "Identificador de la incidencia no informado" } },
            { "106", new Error { Code = "106", Description = "Último dato enviado no existe" } },
            { "108", new Error { Code = "108", Description = "Datos para la selección erroneos" } },
            { "109", new Error { Code = "109", Description = "Datos para la selección no informados" } },
            { "110", new Error { Code = "110", Description = "Error en la búsqueda de candidatos" } },
            { "111", new Error { Code = "111", Description = "Error de inconsistencia de datos" } },
            { "112", new Error { Code = "112", Description = "Último dato enviado´erróneo" } },
            { "117", new Error { Code = "117", Description = "Código de tabla sin formar" } },
            { "118", new Error { Code = "118", Description = "No existe el código de tabla" } },
            { "119", new Error { Code = "119", Description = "No existe el último elemento" } },
            { "120", new Error { Code = "120", Description = "No existen elementos posteriores" } },
            { "121", new Error { Code = "121", Description = "Código de banco en Código de cuenta bancaria erróneo" } },
            { "122", new Error { Code = "122", Description = "Código de sucursal en Código de cuenta bancaria erróneo" } },
            { "123", new Error { Code = "123", Description = "Código de control en Código de cuenta bancaria erróneo" } },
            { "124", new Error { Code = "124", Description = "Número de cuenta bancaria erroneo" } },
            { "125", new Error { Code = "125", Description = "Número de teléfono erróneo" } },
            { "142", new Error { Code = "142", Description = "Error en moneda de conexión" } },
            { "500", new Error { Code = "500", Description = "LOGON/LOGOFF ya activo" } },
            { "501", new Error { Code = "501", Description = "Petición sin LOGON activo" } },
            { "502", new Error { Code = "502", Description = "Entidad no existe" } },
            { "503", new Error { Code = "503", Description = "Usuario no existe" } },
            { "504", new Error { Code = "504", Description = "Trama no autorizada" } },
            { "505", new Error { Code = "505", Description = "Máximo de sesiones alcanzado" } },
            { "510", new Error { Code = "510", Description = "LOGON establecido" } },
            { "511", new Error { Code = "511", Description = "Password no valida" } },
            { "512", new Error { Code = "512", Description = "Password no informada" } },
            { "590", new Error { Code = "590", Description = "LOGOFF establecido" } }
        };

        public Hashtable CodigosError = new Hashtable()
        {
            { "ICESD001", new Error{ Code = "ICESD001", Description = "Petición vacía: significa que el mensaje de JSON no está presente en la petición" } },
            { "ICESD002", new Error{ Code = "ICESD002", Description = "Petición no incluye sección 'applicants'" } },
            { "ICESD003", new Error{ Code = "ICESD003", Description = "Respuesta inválida" } },
            { "ICESD004", new Error{ Code = "ICESD004", Description = "Identificador de persona informado incorrecto" } },
            { "ICESA001", new Error{ Code = "ICESA001", Description = "Autenticación fallida" } },
            { "ICESO001", new Error{ Code = "ICESO001", Description = "Orquestación proporcionada no encontrada" } },
            { "ICDAS001", new Error{ Code = "ICDAS001", Description = "Servicio configurado no alcanzado" } },
            { "ICDAS002", new Error{ Code = "ICDAS002", Description = "Servicio configurado no existe" } },
            { "ICDAS003", new Error{ Code = "ICDAS003", Description = "Servicio configurado no disponible" } },
            { "ICDAS004", new Error{ Code = "ICDAS004", Description = "Servicio configurado representa problemas al final del servicio" } }
        };

        public Hashtable CodigosWorstSituation = new Hashtable()
        {
            { "1", "Amistoso" },
            { "2", "Perjudicial" },
            { "3", "Judicial" },
            { "4", "Fallido" },
            { "5", "Suspension de pagos" },
            { "6", "Quiebra" },
            { "8", "Actividad suspension regular" },
            { "9", "Consumo Voluntario" },
            { "10", "Consumo Necesario" },
            { "99", "Otros" }
        };

        public Hashtable CodigosRating = new Hashtable()
        {
            { "1", "Muy alto" },
            { "2", "Alto" },
            { "3", "Medio alto" },
            { "4", "Medio" },
            { "5", "Medio bajo" },
            { "6", "Bajo" }
        };
    }
}
