using Microsoft.Extensions.Logging;
using Persona4GoldenHelper.Data;
using Persona4GoldenHelper.Data.Data;
using Persona4GoldenHelper.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Persona4GoldenHelper.Service
{
    public class BookService : IBook
    {
        private readonly ApplicationDbContext Context;
        private readonly ILogger<BookService> Logger;

        public BookService(ApplicationDbContext context, ILogger<BookService> logger)
        {
            Context = context;
            Logger = logger;
        }

        public List<Book> GetAll()
        {
            try
            {
                Logger.LogInformation("GetAll was called");

                return Context.Books.ToList();
            }
            catch (Exception ex)
            {
                Logger.LogError($"GetAll failed: {ex}");
                return null;
            }
        }

        public List<BookOrder> GetOrder()
        {
            try
            {
                Logger.LogInformation("GetOrder was called");

                return Context.BookOrder.ToList();
            }
            catch (Exception ex)
            {
                Logger.LogError($"GetOrder failed {ex}");
                return null;
            }
        }
    }
}
