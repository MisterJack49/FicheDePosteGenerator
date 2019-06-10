using FicheDePosteGenerator.Interfaces.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FicheDePosteGenerator.Model
{
    public class GenerationData
    {
        public int Id { get; set; }
        public string EventId { get; set; }
        public IField TeamNumber { get; set; }
        public IField Paps { get; set; }
        public IField Meal { get; set; }
        public IField Local { get; set; }
        public ICellField Event { get; set; }
        public ICellField Organizer { get; set; }
        public ICellField Place { get; set; }
        public ICellField Date { get; set; }
        public ICellField Time { get; set; }
    }
}
