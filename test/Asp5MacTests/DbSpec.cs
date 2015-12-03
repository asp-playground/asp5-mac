
using System.Data;
using Xunit;
using System.Collections.Generic;
using System.IO;
using Microsoft.Data.Entity;
using Microsoft.Extensions.PlatformAbstractions;
using System;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Info {
    [Key]
    public int Id {set;get;}
    public String Name {set;get;}
    public int Age { set;get;}
}

public class MyContext: DbContext {

    public DbSet<Info> Infoes {set;get;}

    protected override void OnConfiguring(DbContextOptionsBuilder builder) {
        builder.UseNpgsql("Server=192.168.0.105;Port=5432;Database=Asp5; User Id=tfo;Password=abcABC123;");
    }
}

public class DbSpec {
    [Fact]
    public void ShouldGenerateSchema() {
        var context = new MyContext();
        context.Infoes.Where( x=> x.Age > 100).ToList();
    }
}