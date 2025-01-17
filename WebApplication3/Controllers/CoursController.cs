﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication3.Data;
using miniPrpject_Asp.Models;
using System.Text;

namespace miniPrpject_Asp.Controllers
{
    public class CoursController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CoursController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Cours
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Cours.Include(c => c.Classe).Include(c => c.Professeur);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Cours/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cours = await _context.Cours
                .Include(c => c.Classe)
                .Include(c => c.Professeur)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cours == null)
            {
                return NotFound();
            }

            return View(cours);
        }

        // GET: Cours/Create
        public IActionResult Create()
        {
            ViewBag.ProfesseurID = new SelectList(_context.Professeurs, "Id", "UserName");
            ViewBag.ClasseID = new SelectList(_context.Classes, "Id", "NomClasse");
            return View();
        }

        // POST: Cours/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nom,Groupe,ProfesseurID,ClasseID")] Cours cours)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cours);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            
            ViewBag.ProfesseurID = new SelectList(_context.Professeurs, "UserName", "Id", cours.ProfesseurID);
            ViewBag.ClasseID = new SelectList(_context.Classes, "NomClasse", "Id", cours.ClasseID);
            return View(cours);
        }

        // GET: Cours/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cours = await _context.Cours.FindAsync(id);
            if (cours == null)
            {
                return NotFound();
            }

            ViewBag.ProfesseurID = new SelectList(_context.Professeurs, "Id", "UserName", cours.ProfesseurID);
            ViewBag.ClasseID = new SelectList(_context.Classes, "Id", "NomClasse", cours.ClasseID);
            return View(cours);
        }

        // POST: Cours/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nom,Groupe,ProfesseurID,ClasseID")] Cours cours)
        {
            if (id != cours.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cours);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CoursExists(cours.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }

            ViewBag.ProfesseurID = new SelectList(_context.Professeurs, "Id", "UserName", cours.ProfesseurID);
            ViewBag.ClasseID = new SelectList(_context.Classes, "Id", "NomClasse", cours.ClasseID);
            return View(cours);
        }

        // GET: Cours/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cours = await _context.Cours
                .Include(c => c.Classe)
                .Include(c => c.Professeur)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cours == null)
            {
                return NotFound();
            }

            return View(cours);
        }

        // POST: Cours/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cours = await _context.Cours.FindAsync(id);
            _context.Cours.Remove(cours);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CoursExists(int id)
        {
            return _context.Cours.Any(e => e.Id == id);
        }
        public IActionResult telechargerExcel()
        {
            return CSV();
        }
        [HttpPost, ActionName("Excel")]
        private IActionResult CSV()
        {
            var builder = new StringBuilder();
            builder.AppendLine("Cours ; Professeuer ; Niveau");
           
            foreach (var cour in _context.Cours)
            {
                foreach (var prof in _context.Professeurs)
                {
                    if (prof.Id == cour.ProfesseurID)
                    {
                        foreach (var niveau in _context.Classes)
                        {
                            if (niveau.Id == cour.ClasseID)
                            {
                                builder.AppendLine($"{cour.Nom}; {prof.Nom} {prof.Prenom}; {niveau.code}");


                            }
                        }
                    }
                }
            }
            return File(Encoding.UTF8.GetBytes(builder.ToString()), "text/csv", "ExcelCour.csv");

        }
    }
}
