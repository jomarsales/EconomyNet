using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using EconomyNet.Entity;
using Newtonsoft.Json;

namespace EconomyNet.Repository
{
    public class RecordRepository : IRepository
    {
        private List<Record> _records;
        private readonly string _fileName;

        public RecordRepository()
        {
            var directory = Path.Combine(Environment.CurrentDirectory, DateTime.Now.ToString("yyyy"));

            if (!Directory.Exists(directory))
                Directory.CreateDirectory(directory);

            _fileName = Path.Combine(directory, $"{nameof(RecordRepository)}.json");

            _records = new List<Record>();
            Read();
        }

        public void Read()
        {
            try
            {
                using (var r = new StreamReader(_fileName))
                {
                    var json = r.ReadToEnd();
                    _records = JsonConvert.DeserializeObject<List<Record>>(json);
                }
            }
            catch
            {
                //ignore
            }
        }

        public void Write()
        {
            try
            {
                using (var file = File.CreateText(_fileName))
                {
                    var serializer = new JsonSerializer();
                    serializer.Serialize(file, _records);
                }
            }
            catch
            {
                //ignore
            }
        }

        public void Save(Record record)
        {
            var u = _records.FirstOrDefault(r => string.Equals(r.Description, record.Description, StringComparison.CurrentCultureIgnoreCase));

            if (u == null)
                _records.Add(record);
            else
            {
                u.Type = record.Type;
                u.Category = record.Category;
                u.Price = record.Price;
                u.PaidOut = record.PaidOut;
                u.PaymentDate = record.PaymentDate;
            }

            Write();
        }

        public void Delete(Record record)
        {
            var u = _records.FirstOrDefault(r => string.Equals(r.Description, record.Description, StringComparison.CurrentCultureIgnoreCase));

            if (u == null)
                throw new Exception("Registo não encontrado...");

            _records.Remove(u);

            Write();
        }

        public List<Record> All()
        {
            Read();

            return _records;
        }

        public Record Find(string description)
        {
            Read();

            return _records.FirstOrDefault(u => string.Equals(u.Description, description, StringComparison.CurrentCultureIgnoreCase));
        }
    }
}
