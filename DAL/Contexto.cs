using Microsoft.EntityFrameworkCore;

public class Contexto : DbContext
    {
        public DbSet<Categorias> Categorias { get; set; }
        public DbSet<Productos> Productos { get; set; }
        public DbSet<Compras> Compras { get; set; }

        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {
        } 
 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categorias>().HasData(
              new Categorias() { CategoriaId = 1, Descripcion = "Alimentos" },
              new Categorias() { CategoriaId = 2, Descripcion = "Abarrotes" }
            );

            modelBuilder.Entity<Productos>().HasData(
                new Productos
                {
                    ProductoId = 1,
                    Descripcion = "Arroz",
                    Costo = 40,
                    Precio = 38,
                    CategoriaId = 2,
                    Existencia = 0
                },
                new Productos
                {
                    ProductoId = 2,
                    Descripcion = "Papas",
                    Costo = 40,
                    Precio = 35,
                    CategoriaId = 3,
                    Existencia = 0
                },
                new Productos
                {
                    ProductoId = 3,
                    Descripcion = "Ajies",
                    Costo = 50,
                    Precio = 100,
                    CategoriaId = 4,
                    Existencia = 0
                }
                );
        }
    }