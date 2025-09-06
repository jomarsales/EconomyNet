using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using EconomyNet.Entity;
using Newtonsoft.Json;

namespace EconomyNet.Repository
{
    public class CategoryRepository : IRepository
    {
        private List<Category> _categories;
        private readonly string _fileName;

        public CategoryRepository()
        {
            var directory = Path.Combine(Environment.CurrentDirectory, DateTime.Now.ToString("yyyy"));

            if (!Directory.Exists(directory))
                Directory.CreateDirectory(directory);

            _fileName = Path.Combine(directory, $"{nameof(CategoryRepository)}.json");

            _categories = new List<Category>();
            Read();
        }

        public void Read()
        {
            try
            {
                using (var r = new StreamReader(_fileName))
                {
                    var json = r.ReadToEnd();
                    _categories = JsonConvert.DeserializeObject<List<Category>>(json);
                }
            }
            catch
            {
                //Ignore
            }
        }

        public void Write()
        {
            try
            {
                using (var file = File.CreateText(_fileName))
                {
                    var serializer = new JsonSerializer();
                    serializer.Serialize(file, _categories);
                }
            }
            catch
            {
                //Ignore
            }
        }

        public void Save(Category category)
        {
            var u = _categories.FirstOrDefault(r => string.Equals(r.CategoryName, category.CategoryName, StringComparison.CurrentCultureIgnoreCase));

            if (u == null)
                _categories.Add(category);
            else
                u.CategoryName = category.CategoryName;

            Write();
        }

        public void Delete(Category category)
        {
            var u = _categories.FirstOrDefault(r => string.Equals(r.CategoryName, category.CategoryName, StringComparison.CurrentCultureIgnoreCase));

            if (u == null)
                throw new Exception("Registo não encontrado...");

            _categories.Remove(u);

            Write();
        }

        public List<Category> All()
        {
            Read();

            return _categories;
        }
    }
}
