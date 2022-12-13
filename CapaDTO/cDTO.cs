using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDTO
{
    public class cDTO
    {
        public class ciudad

        {

            private int id_ciudad;
            private String nombre_ciudad;

            public int Id_ciudad { get => id_ciudad; set => id_ciudad = value; }
            public string Nombre_ciudad { get => nombre_ciudad; set => nombre_ciudad = value; }
        }

        public class comuna
        {
            private int id_comuna;
            private String nombre_comuna;

            public int Id_comuna { get => id_comuna; set => id_comuna = value; }
            public string Nombre_comuna { get => nombre_comuna; set => nombre_comuna = value; }
        }

        public class contrato
        {
            private int id_contrato;
            private String id_estado;
            private DateTime fecha_contrato;
            private String imagen;

            public int Id_contrato { get => id_contrato; set => id_contrato = value; }
            public string Id_estado { get => id_estado; set => id_estado = value; }
            public DateTime Fecha_contrato { get => fecha_contrato; set => fecha_contrato = value; }
            public string Imagen { get => imagen; set => imagen = value; }
        }

        public class detalle_servicio
        {
            private int id_asesoria;
            private String detalle_asesoria;
            private DateTime fecha;
            private String extra;
            private String profesional;
            private String tema;
            private String ubicacion;
            private int duracion;
            private String id_tipo_servicio;
            private String id_servicio;

            public int Id_asesoria { get => id_asesoria; set => id_asesoria = value; }
            public string Detalle_asesoria { get => detalle_asesoria; set => detalle_asesoria = value; }
            public DateTime Fecha { get => fecha; set => fecha = value; }
            public string Extra { get => extra; set => extra = value; }
            public string Profesional { get => profesional; set => profesional = value; }
            public string Tema { get => tema; set => tema = value; }
            public string Ubicacion { get => ubicacion; set => ubicacion = value; }
            public int Duracion { get => duracion; set => duracion = value; }
            public string Id_tipo_servicio { get => id_tipo_servicio; set => id_tipo_servicio = value; }
            public string Id_servicio { get => id_servicio; set => id_servicio = value; }
        }

        public class detalle_usuario
        {
            private String id_usuario;
            private String id_empresa;
            private String id_detalle_usuario;

            public string Id_usuario { get => id_usuario; set => id_usuario = value; }
            public string Id_empresa { get => id_empresa; set => id_empresa = value; }
            public string Id_detalle_usuario { get => id_detalle_usuario; set => id_detalle_usuario = value; }
        }

        public class direccion
        {
            private String id_direccion;
            private String calle;
            private String numero;
            private String id_comuna;
            private String id_pais;
            private String id_ciudad;
            private String id_region;
            private String observaciones;

            public string Id_direccion { get => id_direccion; set => id_direccion = value; }
            public string Calle { get => calle; set => calle = value; }
            public string Numero { get => numero; set => numero = value; }
            public string Id_comuna { get => id_comuna; set => id_comuna = value; }
            public string Id_pais { get => id_pais; set => id_pais = value; }
            public string Id_ciudad { get => id_ciudad; set => id_ciudad = value; }
            public string Id_region { get => id_region; set => id_region = value; }
            public string Observaciones { get => observaciones; set => observaciones = value; }
        }

        public class empresa
        {
            private String id_empresa;
            private String rut_empresa;
            private String id_rubro;
            private String id_contrato;

            public string Id_empresa { get => id_empresa; set => id_empresa = value; }
            public string Rut_empresa { get => rut_empresa; set => rut_empresa = value; }
            public string Id_rubro { get => id_rubro; set => id_rubro = value; }
            public string Id_contrato { get => id_contrato; set => id_contrato = value; }
        }

        public class especialidad_profesional
        {
            private String id_especialidad;
            private String nombre_especialidad;
            private String detalle_especialidad;

            public string Id_especialidad { get => id_especialidad; set => id_especialidad = value; }
            public string Nombre_especialidad { get => nombre_especialidad; set => nombre_especialidad = value; }
            public string Detalle_especialidad { get => detalle_especialidad; set => detalle_especialidad = value; }
        }

        public class estado
        {
            private String id_estado;
            private String nombre_estado;
            private String observaciones_estado;

            public string Id_estado { get => id_estado; set => id_estado = value; }
            public string Nombre_estado { get => nombre_estado; set => nombre_estado = value; }
            public string Observaciones_estado { get => observaciones_estado; set => observaciones_estado = value; }
        }

        public class item
        {
            private String id_item;
            private String nombre_item;
            private String descripcion_item;
            private String id_estado;
            private DateTime fecha_agregado;
            private String id_empresa;

            public string Id_item { get => id_item; set => id_item = value; }
            public string Nombre_item { get => nombre_item; set => nombre_item = value; }
            public string Descripcion_item { get => descripcion_item; set => descripcion_item = value; }
            public string Id_estado { get => id_estado; set => id_estado = value; }
            public DateTime Fecha_agregado { get => fecha_agregado; set => fecha_agregado = value; }
            public string Id_empresa { get => id_empresa; set => id_empresa = value; }
        }

        public class login
        {
            private int Id_usuario;
            private String Nombre;
            private String Usuario;
            private String Password;
            private String Tipo_usuario;

            public int Id_usuario1 { get => Id_usuario; set => Id_usuario = value; }
            public string Nombre1 { get => Nombre; set => Nombre = value; }
            public string Usuario1 { get => Usuario; set => Usuario = value; }
            public string Password1 { get => Password; set => Password = value; }
            public string Tipo_usuario1 { get => Tipo_usuario; set => Tipo_usuario = value; }
        }

        public class mensualidad
        {
            private String id_mensualidad;
            private String id_estado;
            private String observaciones;

            public string Id_mensualidad { get => id_mensualidad; set => id_mensualidad = value; }
            public string Id_estado { get => id_estado; set => id_estado = value; }
            public string Observaciones { get => observaciones; set => observaciones = value; }
        }

        public class pais
        {
            private String id_pais;
            private String nombre_pais;

            public string Id_pais { get => id_pais; set => id_pais = value; }
            public string Nombre_pais { get => nombre_pais; set => nombre_pais = value; }
        }

        public class region
        {
            private String id_region;
            private String nombre_region;

            public string Id_region { get => id_region; set => id_region = value; }
            public string Nombre_region { get => nombre_region; set => nombre_region = value; }
        }

        public class reporteAccidente
        {
            private int id_reporteAccidente;
            private String nombreCliente;
            private String Rut;
            private String Direccion;
            private String Area;
            private String Fecha;
            private String Descripcion;
            private String Tarea;

            public int Id_reporteAccidente { get => id_reporteAccidente; set => id_reporteAccidente = value; }
            public string NombreCliente { get => nombreCliente; set => nombreCliente = value; }
            public string Rut1 { get => Rut; set => Rut = value; }
            public string Direccion1 { get => Direccion; set => Direccion = value; }
            public string Area1 { get => Area; set => Area = value; }
            public string Fecha1 { get => Fecha; set => Fecha = value; }
            public string Descripcion1 { get => Descripcion; set => Descripcion = value; }
            public string Tarea1 { get => Tarea; set => Tarea = value; }
        }

        public class rol
        {
            private String id_rol;
            private String nombre_rol;
            private String detalle_rol;

            public string Id_rol { get => id_rol; set => id_rol = value; }
            public string Nombre_rol { get => nombre_rol; set => nombre_rol = value; }
            public string Detalle_rol { get => detalle_rol; set => detalle_rol = value; }

            public rol(string id_rol, string nombre_rol, string detalle_rol)
            {
                this.id_rol = id_rol;
                this.nombre_rol = nombre_rol;
                this.detalle_rol = detalle_rol;
            }

        }


        public class rubro
        {
            private String id_rubro;
            private String nombre_rubro;
            private String descripcion_rubro;

            public string Id_rubro { get => id_rubro; set => id_rubro = value; }
            public string Nombre_rubro { get => nombre_rubro; set => nombre_rubro = value; }
            public string Descripcion_rubro { get => descripcion_rubro; set => descripcion_rubro = value; }
        }

        public class servicio
        {
            private String id_servicio;
            private String id_mensualidad;
            private String id_empresa;

            public string Id_servicio { get => id_servicio; set => id_servicio = value; }
            public string Id_mensualidad { get => id_mensualidad; set => id_mensualidad = value; }
            public string Id_empresa { get => id_empresa; set => id_empresa = value; }
        }

        public class tipo_servicio
        {
            private String id_tipo_servicio;
            private String nombre_tipo_servicio;
            private String detalle_tipo_servicio;

            public string Id_tipo_servicio { get => id_tipo_servicio; set => id_tipo_servicio = value; }
            public string Nombre_tipo_servicio { get => nombre_tipo_servicio; set => nombre_tipo_servicio = value; }
            public string Detalle_tipo_servicio { get => detalle_tipo_servicio; set => detalle_tipo_servicio = value; }
        }

        public class usuario
        {
            private String id_usuario;
            private String nombre;
            private String apellido_p;
            private String apellido_m;
            private DateTime fecha_nacimiento;
            private String id_estado;
            private String correo;
            private String telefono;
            private String contrasena;
            private String id_direccion;
            private String rut_usuario;
            private String id_especialidad;
            private String id_rol;
            private String imagen;

            public string Id_usuario { get => id_usuario; set => id_usuario = value; }
            public string Nombre { get => nombre; set => nombre = value; }
            public string Apellido_p { get => apellido_p; set => apellido_p = value; }
            public string Apellido_m { get => apellido_m; set => apellido_m = value; }
            public DateTime Fecha_nacimiento { get => fecha_nacimiento; set => fecha_nacimiento = value; }
            public string Id_estado { get => id_estado; set => id_estado = value; }
            public string Correo { get => correo; set => correo = value; }
            public string Telefono { get => telefono; set => telefono = value; }
            public string Contrasena { get => contrasena; set => contrasena = value; }
            public string Id_direccion { get => id_direccion; set => id_direccion = value; }
            public string Rut_usuario { get => rut_usuario; set => rut_usuario = value; }
            public string Id_especialidad { get => id_especialidad; set => id_especialidad = value; }
            public string Id_rol { get => id_rol; set => id_rol = value; }
            public string Imagen { get => imagen; set => imagen = value; }
        }
    }
}
