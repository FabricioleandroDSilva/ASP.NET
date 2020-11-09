﻿using FichaAcademia.AcessoDados.Mapeamentos;
using FichaAcademia.Dominio.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace FichaAcademia.AcessoDados
{
   public class Contexto : DbContext
    {
        public DbSet<Administrador> Administradores { get; set; }
        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<CategoriaExercicio> CategoriaExercicios { get; set; }
        public DbSet<Exercicio> Exercicios { get; set; }
        public DbSet<Ficha> Fichas { get; set; }
        public DbSet<ListaExercicio> ListaExercicios { get; set; }
        public DbSet<Professor> Professores { get; set; }
        public DbSet<Objetivo> Objetivos { get; set; }
        public Contexto(DbContextOptions<Contexto> opcoes):base (opcoes)
        {


        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AdministradoresMap());
            modelBuilder.ApplyConfiguration(new AlunoMap());
            modelBuilder.ApplyConfiguration(new CategoriaExericioMap());
            modelBuilder.ApplyConfiguration(new ExericioMap());
            modelBuilder.ApplyConfiguration(new FichaMap());
            modelBuilder.ApplyConfiguration(new ListaExercicioMap());
            modelBuilder.ApplyConfiguration(new ObjetivoMap());
            modelBuilder.ApplyConfiguration(new ProfessorMap());

        }
    }
}
