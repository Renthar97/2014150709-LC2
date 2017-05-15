namespace _2014150709_PER.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "Admin.Administrador_Equipo",
                c => new
                    {
                        AdministradorEquipo_Id = c.Int(nullable: false, identity: true),
                        Nombre_AdEquipo = c.String(),
                        Apellido_Paterno_AdEquipo = c.String(),
                        Apellido_Materno_AdEquipo = c.String(),
                        Dni = c.String(),
                    })
                .PrimaryKey(t => t.AdministradorEquipo_Id);
            
            CreateTable(
                "Admin.Equipo_Celular",
                c => new
                    {
                        EquipoCelular_Id = c.Int(nullable: false, identity: true),
                        Nombre_Equipo = c.String(),
                        Marca_Equipo = c.String(),
                        AdministradorEquipo_Id_AdministradorEquipo_Id = c.Int(),
                    })
                .PrimaryKey(t => t.EquipoCelular_Id)
                .ForeignKey("Admin.Administrador_Equipo", t => t.AdministradorEquipo_Id_AdministradorEquipo_Id)
                .Index(t => t.AdministradorEquipo_Id_AdministradorEquipo_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("Admin.Equipo_Celular", "AdministradorEquipo_Id_AdministradorEquipo_Id", "Admin.Administrador_Equipo");
            DropIndex("Admin.Equipo_Celular", new[] { "AdministradorEquipo_Id_AdministradorEquipo_Id" });
            DropTable("Admin.Equipo_Celular");
            DropTable("Admin.Administrador_Equipo");
        }
    }
}
