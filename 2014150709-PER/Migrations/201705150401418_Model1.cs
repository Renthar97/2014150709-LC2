namespace _2014150709_PER.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Model1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "Admin.Administrador_Linea",
                c => new
                    {
                        AdministradorLinea_Id = c.Int(nullable: false, identity: true),
                        Nombre_AdLinea = c.String(),
                        Apellido_Paterno_AdLinea = c.String(),
                        Apellido_Materno_AdLinea = c.String(),
                        Dni = c.String(),
                    })
                .PrimaryKey(t => t.AdministradorLinea_Id);
            
            CreateTable(
                "Admin.Cliente",
                c => new
                    {
                        Cliente_Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Apellido_Paterno = c.String(),
                        Apellido_Materno = c.String(),
                        Telefono = c.String(),
                    })
                .PrimaryKey(t => t.Cliente_Id);
            
            CreateTable(
                "Admin.Contrato",
                c => new
                    {
                        ContratoId = c.Int(nullable: false, identity: true),
                        Documento = c.String(),
                    })
                .PrimaryKey(t => t.ContratoId);
            
            CreateTable(
                "Admin.Departamento",
                c => new
                    {
                        Departamento_Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                    })
                .PrimaryKey(t => t.Departamento_Id);
            
            CreateTable(
                "Admin.Provincia",
                c => new
                    {
                        Departamento_id = c.Int(nullable: false),
                        Provincia_Id = c.Int(nullable: false),
                        Nombre = c.String(),
                    })
                .PrimaryKey(t => new { t.Departamento_id, t.Provincia_Id })
                .ForeignKey("Admin.Departamento", t => t.Departamento_id, cascadeDelete: true)
                .Index(t => t.Departamento_id);
            
            CreateTable(
                "Admin.Distrito",
                c => new
                    {
                        Distrito_Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Departamento_Departamento_Id = c.Int(),
                        Provincia_Departamento_id = c.Int(),
                        Provincia_Provincia_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Distrito_Id)
                .ForeignKey("Admin.Departamento", t => t.Departamento_Departamento_Id)
                .ForeignKey("Admin.Provincia", t => new { t.Provincia_Departamento_id, t.Provincia_Provincia_Id })
                .Index(t => t.Departamento_Departamento_Id)
                .Index(t => new { t.Provincia_Departamento_id, t.Provincia_Provincia_Id });
            
            CreateTable(
                "Admin.Estado_Evaluacion",
                c => new
                    {
                        EstadoEvaluacionId = c.Int(nullable: false, identity: true),
                        Estado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.EstadoEvaluacionId);
            
            CreateTable(
                "Admin.Evaluacion",
                c => new
                    {
                        Evaluacion_Id = c.Int(nullable: false, identity: true),
                        CentroAtencion_Id_CentroAtencionId = c.Int(),
                        Cliente_id_Cliente_Id = c.Int(),
                        EquipoCelular_Id_EquipoCelular_Id = c.Int(),
                        EstadoEvaluacion_EstadoEvaluacionId = c.Int(),
                        LineaTelefonica_Id_LineaTelefonica_Id = c.Int(),
                        Plan_Id_Plan_Id = c.Int(),
                        TipoEvaluacion_id_TipoEvaluacion_Id = c.Int(),
                        Trabajador_Id_Trabajador_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Evaluacion_Id)
                .ForeignKey("Admin.CentroAtencions", t => t.CentroAtencion_Id_CentroAtencionId)
                .ForeignKey("Admin.Cliente", t => t.Cliente_id_Cliente_Id)
                .ForeignKey("Admin.Equipo_Celular", t => t.EquipoCelular_Id_EquipoCelular_Id)
                .ForeignKey("Admin.Estado_Evaluacion", t => t.EstadoEvaluacion_EstadoEvaluacionId)
                .ForeignKey("Admin.Linea_Telefonica", t => t.LineaTelefonica_Id_LineaTelefonica_Id)
                .ForeignKey("Admin.Plan", t => t.Plan_Id_Plan_Id)
                .ForeignKey("Admin.Tipo_Evaluacion", t => t.TipoEvaluacion_id_TipoEvaluacion_Id)
                .ForeignKey("Admin.Trabajador", t => t.Trabajador_Id_Trabajador_Id)
                .Index(t => t.CentroAtencion_Id_CentroAtencionId)
                .Index(t => t.Cliente_id_Cliente_Id)
                .Index(t => t.EquipoCelular_Id_EquipoCelular_Id)
                .Index(t => t.EstadoEvaluacion_EstadoEvaluacionId)
                .Index(t => t.LineaTelefonica_Id_LineaTelefonica_Id)
                .Index(t => t.Plan_Id_Plan_Id)
                .Index(t => t.TipoEvaluacion_id_TipoEvaluacion_Id)
                .Index(t => t.Trabajador_Id_Trabajador_Id);
            
            CreateTable(
                "Admin.CentroAtencions",
                c => new
                    {
                        CentroAtencionId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        DireccionId_DireccionId = c.Int(),
                    })
                .PrimaryKey(t => t.CentroAtencionId)
                .ForeignKey("Admin.Direccions", t => t.DireccionId_DireccionId)
                .Index(t => t.DireccionId_DireccionId);
            
            CreateTable(
                "Admin.Direccions",
                c => new
                    {
                        DireccionId = c.Int(nullable: false, identity: true),
                        Adress = c.String(),
                        UbigeoId_UbigeoId = c.Int(),
                    })
                .PrimaryKey(t => t.DireccionId)
                .ForeignKey("Admin.Ubigeo", t => t.UbigeoId_UbigeoId)
                .Index(t => t.UbigeoId_UbigeoId);
            
            CreateTable(
                "Admin.Ubigeo",
                c => new
                    {
                        UbigeoId = c.Int(nullable: false, identity: true),
                        Departamento_Id_Departamento_Id = c.Int(),
                        Distrito_Id_Distrito_Id = c.Int(),
                        Provincia_Id_Departamento_id = c.Int(),
                        Provincia_Id_Provincia_Id = c.Int(),
                    })
                .PrimaryKey(t => t.UbigeoId)
                .ForeignKey("Admin.Departamento", t => t.Departamento_Id_Departamento_Id)
                .ForeignKey("Admin.Distrito", t => t.Distrito_Id_Distrito_Id)
                .ForeignKey("Admin.Provincia", t => new { t.Provincia_Id_Departamento_id, t.Provincia_Id_Provincia_Id })
                .Index(t => t.Departamento_Id_Departamento_Id)
                .Index(t => t.Distrito_Id_Distrito_Id)
                .Index(t => new { t.Provincia_Id_Departamento_id, t.Provincia_Id_Provincia_Id });
            
            CreateTable(
                "Admin.Linea_Telefonica",
                c => new
                    {
                        LineaTelefonica_Id = c.Int(nullable: false, identity: true),
                        Operador = c.String(),
                        Numero = c.String(),
                        Tipo_TipoLinea_Id = c.Int(),
                    })
                .PrimaryKey(t => t.LineaTelefonica_Id)
                .ForeignKey("Admin.Tipo_Linea", t => t.Tipo_TipoLinea_Id)
                .Index(t => t.Tipo_TipoLinea_Id);
            
            CreateTable(
                "Admin.Tipo_Linea",
                c => new
                    {
                        TipoLinea_Id = c.Int(nullable: false, identity: true),
                        Tipo_Linea = c.String(),
                    })
                .PrimaryKey(t => t.TipoLinea_Id);
            
            CreateTable(
                "Admin.Plan",
                c => new
                    {
                        Plan_Id = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(),
                        TipoPlan_Id_TipoPlan_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Plan_Id)
                .ForeignKey("Admin.Tipo_Plan", t => t.TipoPlan_Id_TipoPlan_Id)
                .Index(t => t.TipoPlan_Id_TipoPlan_Id);
            
            CreateTable(
                "Admin.Tipo_Plan",
                c => new
                    {
                        TipoPlan_Id = c.Int(nullable: false, identity: true),
                        Tipo = c.String(),
                    })
                .PrimaryKey(t => t.TipoPlan_Id);
            
            CreateTable(
                "Admin.Tipo_Evaluacion",
                c => new
                    {
                        TipoEvaluacion_Id = c.Int(nullable: false, identity: true),
                        Tipo = c.String(),
                    })
                .PrimaryKey(t => t.TipoEvaluacion_Id);
            
            CreateTable(
                "Admin.Trabajador",
                c => new
                    {
                        Trabajador_Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Apellido_Paterno = c.String(),
                        Apellido_Materno = c.String(),
                        Dni = c.String(),
                        Tipo_TipoTrabajador_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Trabajador_Id)
                .ForeignKey("Admin.Tipo_Trabajador", t => t.Tipo_TipoTrabajador_Id)
                .Index(t => t.Tipo_TipoTrabajador_Id);
            
            CreateTable(
                "Admin.Tipo_Trabajador",
                c => new
                    {
                        TipoTrabajador_Id = c.Int(nullable: false, identity: true),
                        Tipo = c.String(),
                    })
                .PrimaryKey(t => t.TipoTrabajador_Id);
            
            CreateTable(
                "Admin.Tipo_Pago",
                c => new
                    {
                        TipoPago_Id = c.Int(nullable: false, identity: true),
                        Pago = c.String(),
                    })
                .PrimaryKey(t => t.TipoPago_Id);
            
            CreateTable(
                "Admin.Venta",
                c => new
                    {
                        Codigo_venta = c.Int(nullable: false, identity: true),
                        CentroAtencionId_CentroAtencionId = c.Int(),
                        ClienteId_Cliente_Id = c.Int(),
                        ContratoId_ContratoId = c.Int(),
                        EvaluacionId_Evaluacion_Id = c.Int(),
                        LineaTelefonicaId_LineaTelefonica_Id = c.Int(),
                        TipoPagoId_TipoPago_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Codigo_venta)
                .ForeignKey("Admin.CentroAtencions", t => t.CentroAtencionId_CentroAtencionId)
                .ForeignKey("Admin.Cliente", t => t.ClienteId_Cliente_Id)
                .ForeignKey("Admin.Contrato", t => t.ContratoId_ContratoId)
                .ForeignKey("Admin.Evaluacion", t => t.EvaluacionId_Evaluacion_Id)
                .ForeignKey("Admin.Linea_Telefonica", t => t.LineaTelefonicaId_LineaTelefonica_Id)
                .ForeignKey("Admin.Tipo_Pago", t => t.TipoPagoId_TipoPago_Id)
                .Index(t => t.CentroAtencionId_CentroAtencionId)
                .Index(t => t.ClienteId_Cliente_Id)
                .Index(t => t.ContratoId_ContratoId)
                .Index(t => t.EvaluacionId_Evaluacion_Id)
                .Index(t => t.LineaTelefonicaId_LineaTelefonica_Id)
                .Index(t => t.TipoPagoId_TipoPago_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("Admin.Venta", "TipoPagoId_TipoPago_Id", "Admin.Tipo_Pago");
            DropForeignKey("Admin.Venta", "LineaTelefonicaId_LineaTelefonica_Id", "Admin.Linea_Telefonica");
            DropForeignKey("Admin.Venta", "EvaluacionId_Evaluacion_Id", "Admin.Evaluacion");
            DropForeignKey("Admin.Venta", "ContratoId_ContratoId", "Admin.Contrato");
            DropForeignKey("Admin.Venta", "ClienteId_Cliente_Id", "Admin.Cliente");
            DropForeignKey("Admin.Venta", "CentroAtencionId_CentroAtencionId", "Admin.CentroAtencions");
            DropForeignKey("Admin.Evaluacion", "Trabajador_Id_Trabajador_Id", "Admin.Trabajador");
            DropForeignKey("Admin.Trabajador", "Tipo_TipoTrabajador_Id", "Admin.Tipo_Trabajador");
            DropForeignKey("Admin.Evaluacion", "TipoEvaluacion_id_TipoEvaluacion_Id", "Admin.Tipo_Evaluacion");
            DropForeignKey("Admin.Evaluacion", "Plan_Id_Plan_Id", "Admin.Plan");
            DropForeignKey("Admin.Plan", "TipoPlan_Id_TipoPlan_Id", "Admin.Tipo_Plan");
            DropForeignKey("Admin.Evaluacion", "LineaTelefonica_Id_LineaTelefonica_Id", "Admin.Linea_Telefonica");
            DropForeignKey("Admin.Linea_Telefonica", "Tipo_TipoLinea_Id", "Admin.Tipo_Linea");
            DropForeignKey("Admin.Evaluacion", "EstadoEvaluacion_EstadoEvaluacionId", "Admin.Estado_Evaluacion");
            DropForeignKey("Admin.Evaluacion", "EquipoCelular_Id_EquipoCelular_Id", "Admin.Equipo_Celular");
            DropForeignKey("Admin.Evaluacion", "Cliente_id_Cliente_Id", "Admin.Cliente");
            DropForeignKey("Admin.Evaluacion", "CentroAtencion_Id_CentroAtencionId", "Admin.CentroAtencions");
            DropForeignKey("Admin.CentroAtencions", "DireccionId_DireccionId", "Admin.Direccions");
            DropForeignKey("Admin.Direccions", "UbigeoId_UbigeoId", "Admin.Ubigeo");
            DropForeignKey("Admin.Ubigeo", new[] { "Provincia_Id_Departamento_id", "Provincia_Id_Provincia_Id" }, "Admin.Provincia");
            DropForeignKey("Admin.Ubigeo", "Distrito_Id_Distrito_Id", "Admin.Distrito");
            DropForeignKey("Admin.Ubigeo", "Departamento_Id_Departamento_Id", "Admin.Departamento");
            DropForeignKey("Admin.Distrito", new[] { "Provincia_Departamento_id", "Provincia_Provincia_Id" }, "Admin.Provincia");
            DropForeignKey("Admin.Distrito", "Departamento_Departamento_Id", "Admin.Departamento");
            DropForeignKey("Admin.Provincia", "Departamento_id", "Admin.Departamento");
            DropIndex("Admin.Venta", new[] { "TipoPagoId_TipoPago_Id" });
            DropIndex("Admin.Venta", new[] { "LineaTelefonicaId_LineaTelefonica_Id" });
            DropIndex("Admin.Venta", new[] { "EvaluacionId_Evaluacion_Id" });
            DropIndex("Admin.Venta", new[] { "ContratoId_ContratoId" });
            DropIndex("Admin.Venta", new[] { "ClienteId_Cliente_Id" });
            DropIndex("Admin.Venta", new[] { "CentroAtencionId_CentroAtencionId" });
            DropIndex("Admin.Trabajador", new[] { "Tipo_TipoTrabajador_Id" });
            DropIndex("Admin.Plan", new[] { "TipoPlan_Id_TipoPlan_Id" });
            DropIndex("Admin.Linea_Telefonica", new[] { "Tipo_TipoLinea_Id" });
            DropIndex("Admin.Ubigeo", new[] { "Provincia_Id_Departamento_id", "Provincia_Id_Provincia_Id" });
            DropIndex("Admin.Ubigeo", new[] { "Distrito_Id_Distrito_Id" });
            DropIndex("Admin.Ubigeo", new[] { "Departamento_Id_Departamento_Id" });
            DropIndex("Admin.Direccions", new[] { "UbigeoId_UbigeoId" });
            DropIndex("Admin.CentroAtencions", new[] { "DireccionId_DireccionId" });
            DropIndex("Admin.Evaluacion", new[] { "Trabajador_Id_Trabajador_Id" });
            DropIndex("Admin.Evaluacion", new[] { "TipoEvaluacion_id_TipoEvaluacion_Id" });
            DropIndex("Admin.Evaluacion", new[] { "Plan_Id_Plan_Id" });
            DropIndex("Admin.Evaluacion", new[] { "LineaTelefonica_Id_LineaTelefonica_Id" });
            DropIndex("Admin.Evaluacion", new[] { "EstadoEvaluacion_EstadoEvaluacionId" });
            DropIndex("Admin.Evaluacion", new[] { "EquipoCelular_Id_EquipoCelular_Id" });
            DropIndex("Admin.Evaluacion", new[] { "Cliente_id_Cliente_Id" });
            DropIndex("Admin.Evaluacion", new[] { "CentroAtencion_Id_CentroAtencionId" });
            DropIndex("Admin.Distrito", new[] { "Provincia_Departamento_id", "Provincia_Provincia_Id" });
            DropIndex("Admin.Distrito", new[] { "Departamento_Departamento_Id" });
            DropIndex("Admin.Provincia", new[] { "Departamento_id" });
            DropTable("Admin.Venta");
            DropTable("Admin.Tipo_Pago");
            DropTable("Admin.Tipo_Trabajador");
            DropTable("Admin.Trabajador");
            DropTable("Admin.Tipo_Evaluacion");
            DropTable("Admin.Tipo_Plan");
            DropTable("Admin.Plan");
            DropTable("Admin.Tipo_Linea");
            DropTable("Admin.Linea_Telefonica");
            DropTable("Admin.Ubigeo");
            DropTable("Admin.Direccions");
            DropTable("Admin.CentroAtencions");
            DropTable("Admin.Evaluacion");
            DropTable("Admin.Estado_Evaluacion");
            DropTable("Admin.Distrito");
            DropTable("Admin.Provincia");
            DropTable("Admin.Departamento");
            DropTable("Admin.Contrato");
            DropTable("Admin.Cliente");
            DropTable("Admin.Administrador_Linea");
        }
    }
}
