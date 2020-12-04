namespace WeAreTheChampions.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using WeAreTheChampions.Model;

    internal sealed class Configuration : DbMigrationsConfiguration<WeAreTheChampions.Model.WeAreTheChampionsContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WeAreTheChampions.Model.WeAreTheChampionsContext context)
        {
            if (!context.Teams.Any())
            {
                context.Teams.AddRange(Team());
            }
            if (!context.Players.Any())
            {
                context.Players.AddRange(Player());
            }
            if (!context.Matches.Any())
            {
                context.Matches.Add((new Match() { Team1Id = 1, Team2Id = 2, Score1 = 2, Score2 = 2, Result = Result.Draw }));
            }
        }

        private List<Team> Team()
        {
            return new List<Team>()
            {
                new Team() { TeamName = "Manchester United"},
                new Team() { TeamName = "Milan"},
                new Team() { TeamName = "Barcelona"},
            };
        }

        private List<Player> Player()
        {
            return new List<Player>()
            {
                new Player() {  PlayerName ="Peter Schmeichel", TeamId = 1 },
                new Player() {  PlayerName ="Ronny Johnsen", TeamId = 1 },
                new Player() {  PlayerName ="Jaap Stam", TeamId = 1 },
                new Player() {  PlayerName ="Gary Neville", TeamId = 1 },
                new Player() {  PlayerName ="Denis Irwin", TeamId = 1 },
                new Player() {  PlayerName ="Nicky Butt", TeamId = 1 },
                new Player() {  PlayerName ="David Beckham", TeamId = 1 },
                new Player() {  PlayerName ="Jesper Blomqvist", TeamId = 1 },
                new Player() {  PlayerName ="Ryan Giggs", TeamId = 1 },
                new Player() {  PlayerName ="Dwight Yorke", TeamId = 1 },
                new Player() {  PlayerName ="Andy Cole", TeamId = 1 },

                new Player() {  PlayerName ="Dida", TeamId = 2 },
                new Player() {  PlayerName ="Alessandro Nesta", TeamId = 2 },
                new Player() {  PlayerName ="Paolo Maldini", TeamId = 2 },
                new Player() {  PlayerName ="Kaladze", TeamId = 2 },
                new Player() {  PlayerName ="Cafu", TeamId = 2 },
                new Player() {  PlayerName ="Gennaro Gattuso", TeamId = 2 },
                new Player() {  PlayerName ="Andrea Pirlo", TeamId = 2 },
                new Player() {  PlayerName ="Clarence Seedorf", TeamId = 2 },
                new Player() {  PlayerName ="Kaka Leite", TeamId = 2 },
                new Player() {  PlayerName ="Filippo Inzaghi", TeamId = 2 },
                new Player() {  PlayerName ="Andriy Shevchenko", TeamId = 2 },

                new Player() {  PlayerName ="Victor Valdez", TeamId = 3 },
                new Player() {  PlayerName ="Dani Alves", TeamId = 3 },
                new Player() {  PlayerName ="Carles Puyol", TeamId = 3 },
                new Player() {  PlayerName ="Gerrard Pique", TeamId = 3 },
                new Player() {  PlayerName ="Eric Abidal", TeamId = 3 },
                new Player() {  PlayerName ="Xavi", TeamId = 3 },
                new Player() {  PlayerName ="Andreas Iniesta", TeamId = 3 },
                new Player() {  PlayerName ="Sergio Busquets", TeamId = 3 },
                new Player() {  PlayerName ="David Villa", TeamId = 3 },
                new Player() {  PlayerName ="Lionel Messi", TeamId = 3 },
                new Player() {  PlayerName ="Zlatan Ibrahimovic", TeamId = 3 }
            };
        }
    }
}