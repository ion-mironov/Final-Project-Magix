﻿using Final___Magix.DataContext;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Final___Magix.Controllers
	{
	public class TradeInController : Controller
	{
		// GET: TradeInController
		private readonly CardContext _dbContext; 
	public TradeInController(CardContext dbContext)
        {
            _dbContext = dbContext;
        }

        public ActionResult Index()
        {

			var tradein = _dbContext.TradeIns.ToList();
            return View(tradein);
			}

		// GET: TradeInController/Details/5
		public ActionResult Details(int id)
			{
			return View();
			}

		// GET: TradeInController/Create
		public ActionResult Create()
			{
			return View();
			}

		// POST: TradeInController/Create
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Create(IFormCollection collection)
			{
			try
				{
				return RedirectToAction(nameof(Index));
				}
			catch
				{
				return View();
				}
			}

		// GET: TradeInController/Edit/5
		public ActionResult Edit(int id)
			{
			return View();
			}

		// POST: TradeInController/Edit/5
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Edit(int id, IFormCollection collection)
			{
			try
				{
				return RedirectToAction(nameof(Index));
				}
			catch
				{
				return View();
				}
			}

		// GET: TradeInController/Delete/5
		public ActionResult Delete(int id)
			{
			return View();
			}

		// POST: TradeInController/Delete/5
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Delete(int id, IFormCollection collection)
			{
			try
				{
				return RedirectToAction(nameof(Index));
				}
			catch
				{
				return View();
				}
			}
		}
	}
