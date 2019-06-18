namespace HomeWork23_06_19.DataAccess
{
    using HomeWork23_06_19.Models;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class TasksContext : DbContext
    {
        // Контекст настроен для использования строки подключения "TasksContext" из файла конфигурации  
        // приложения (App.config или Web.config). По умолчанию эта строка подключения указывает на базу данных 
        // "HomeWork23_06_19.DataAccess.TasksContext" в экземпляре LocalDb. 
        // 
        // Если требуется выбрать другую базу данных или поставщик базы данных, измените строку подключения "TasksContext" 
        // в файле конфигурации приложения.
        public TasksContext()
            : base("name=TasksContext")
        {
        }

        public DbSet<Period> Periods { get; set; }
        public DbSet<CatalogMoveTask> CatalogMoveTasks { get; set; }
        public DbSet<FileDownloadTask> FileDownloadTasks { get; set; }
        public DbSet<EmailSendTask> EmailSendTasks { get; set; }
        // Добавьте DbSet для каждого типа сущности, который требуется включить в модель. Дополнительные сведения 
        // о настройке и использовании модели Code First см. в статье http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}