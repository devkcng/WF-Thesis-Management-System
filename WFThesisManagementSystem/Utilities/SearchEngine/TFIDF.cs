using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace WFThesisManagementSystem.Utilities.SearchEngine
{
    public class TFIDF
    {
        private readonly string _folderPath = @"TopicFiles\";

        public List<Document> Search(string query)
        {
            var documents = ReadDocumentsFromFolder();
            var tokenizedDocuments = TokenizeAndPreprocessDocuments(documents);
            var documentFrequencies = CalculateDocumentFrequencies(tokenizedDocuments);
            var tfidfMatrix = CalculateTFIDF(tokenizedDocuments, documentFrequencies);
            var searchResults = Search(query, tokenizedDocuments, tfidfMatrix, documentFrequencies);
            var sortedDocuments = SortDocuments(searchResults, documents);
            return sortedDocuments;
        }

        private List<Document> ReadDocumentsFromFolder()
        {
            var documents = new List<Document>();

            if (Directory.Exists(_folderPath))
            {
                var files = Directory.GetFiles(_folderPath, "*.txt");
                foreach (var file in files)
                {
                    var lines = File.ReadAllLines(file);
                    var document = ParseDocument(lines);
                    documents.Add(document);
                }
            }
            else
            {
                Console.WriteLine("Folder not found. Please provide a valid folder path.");
            }

            return documents;
        }

        private Document ParseDocument(string[] lines)
        {
            var document = new Document();
            foreach (var line in lines)
            {
                var parts = line.Split(new[] { ':' }, 2, StringSplitOptions.RemoveEmptyEntries);
                if (parts.Length == 2)
                {
                    var key = parts[0].Trim();
                    var value = parts[1].Trim();
                    switch (key)
                    {
                        case "Topic Id":
                            document.TopicId = value;
                            break;
                        case "Teacher Name":
                            document.TeacherName = value;
                            break;
                        case "Teacher Id":
                            document.TeacherId = value;
                            break;
                        case "Topic Name":
                            document.TopicName = value;
                            break;
                        case "Topic Description":
                            document.TopicDescription = value;
                            break;
                        case "Topic Requirement":
                            document.TopicRequirement = value;
                            break;
                        case "Topic Category":
                            document.TopicCategory = value;
                            break;
                        case "Topic Technology":
                            document.TopicTechnology = value;
                            break;
                        case "Topic Max Members":
                            document.TopicMaxMembers = value;
                            break;
                    }
                }
            }
            return document;
        }

        private List<List<string>> TokenizeAndPreprocessDocuments(List<Document> documents)
        {
            var tokenizedDocuments = new List<List<string>>();
            foreach (var document in documents)
            {
                var tokens = TokenizeAndPreprocessDocument(document);
                tokenizedDocuments.Add(tokens);
            }
            return tokenizedDocuments;
        }

        private List<string> TokenizeAndPreprocessDocument(Document document)
        {
            var content = $"{document.TopicId} {document.TeacherName} {document.TopicName} {document.TopicDescription} {document.TopicRequirement} {document.TopicCategory} {document.TopicTechnology} {document.TopicMaxMembers}";
            var words = content.ToLower().Split(new[] { ' ', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            var stopWords = new HashSet<string> { "this", "is", "the", "and", "a", "an", "in", "to", "of", "for", "it", "on" };
            var tokens = words.Where(word => !stopWords.Contains(word)).ToList();
            return tokens;
        }

        private Dictionary<string, int> CalculateDocumentFrequencies(List<List<string>> documents)
        {
            var documentFrequencies = new Dictionary<string, int>();
            foreach (var document in documents)
            {
                foreach (var term in document.Distinct())
                {
                    if (documentFrequencies.ContainsKey(term))
                        documentFrequencies[term]++;
                    else
                        documentFrequencies[term] = 1;
                }
            }
            return documentFrequencies;
        }

        private Dictionary<string, Dictionary<string, double>> CalculateTFIDF(List<List<string>> documents, Dictionary<string, int> documentFrequencies)
        {
            var tfidfMatrix = new Dictionary<string, Dictionary<string, double>>();
            foreach (var document in documents)
            {
                var tfidfVector = new Dictionary<string, double>();
                foreach (var term in document.Distinct())
                {
                    var tf = document.Count(t => t == term) / (double)document.Count;
                    var idf = Math.Log(documents.Count / (double)(documentFrequencies[term] + 1));
                    var tfidf = tf * idf;
                    tfidfVector[term] = tfidf;
                }
                tfidfMatrix[string.Join(" ", document)] = tfidfVector;
                foreach (var term in document)
                {
                    if (!tfidfMatrix.ContainsKey(term))
                        tfidfMatrix[term] = new Dictionary<string, double>();
                }
            }
            return tfidfMatrix;
        }

        private List<(int, double)> Search(string query, List<List<string>> documents, Dictionary<string, Dictionary<string, double>> tfidfMatrix, Dictionary<string, int> documentFrequencies)
        {
            var queryTerms = TokenizeAndPreprocessQuery(query);
            var queryVector = new Dictionary<string, double>();
            foreach (var term in queryTerms.Distinct())
            {
                var termFrequency = queryTerms.Count(t => t == term);
                var documentFrequency = documentFrequencies.ContainsKey(term) ? documentFrequencies[term] : 0;
                var tf = termFrequency / (double)queryTerms.Count;
                var idf = Math.Log(documents.Count / (double)(documentFrequency + 1));
                var tfidf = tf * idf;
                queryVector[term] = tfidf;
            }
            var searchResults = new List<(int, double)>();
            for (var i = 0; i < documents.Count; i++)
            {
                var documentKey = string.Join(" ", documents[i]);
                if (tfidfMatrix.ContainsKey(documentKey))
                {
                    var similarity = CosineSimilarity(queryVector, tfidfMatrix[documentKey]);
                    searchResults.Add((i, similarity));
                }
            }
            searchResults = searchResults.OrderByDescending(result => result.Item2).ToList();
            return searchResults;
        }

        private List<string> TokenizeAndPreprocessQuery(string query)
        {
            var words = query.ToLower().Split(new[] { ' ', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            var stopWords = new HashSet<string> { "this", "is", "the", "and", "a", "an", "in", "to", "of", "for", "it", "on" };
            var tokens = words.Where(word => !stopWords.Contains(word)).ToList();
            return tokens;
        }

        private double CosineSimilarity(Dictionary<string, double> vector1, Dictionary<string, double> vector2)
        {
            var dotProduct = vector1.Keys.Intersect(vector2.Keys).Sum(key => vector1[key] * vector2[key]);
            var magnitude1 = Math.Sqrt(vector1.Values.Select(value => value * value).Sum());
            var magnitude2 = Math.Sqrt(vector2.Values.Select(value => value * value).Sum());

            if (magnitude1 == 0 || magnitude2 == 0)
                return 0;

            return dotProduct / (magnitude1 * magnitude2);
        }

        private List<Document> SortDocuments(List<(int, double)> searchResults, List<Document> documents)
        {
            var sortedDocuments = new List<Document>();
            foreach (var (documentIndex, _) in searchResults)
            {
                sortedDocuments.Add(documents[documentIndex]);
            }
            return sortedDocuments;
        }
    }
}