using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.DatabasesContext;
using Entities.ProduitsEntities;
using Microsoft.EntityFrameworkCore.Scaffolding.Metadata;
using Queries.Interface;

namespace Queries
{
    public class ProduitCrudQueryHandler : ICrudInterface<Produit>
    {
        private readonly DatabaseContext _db;
        public ProduitCrudQueryHandler()
        {
            _db = new DatabaseContext();
        }

        public void Archive(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Produit> GetAll()
        {
            List<Produit> Produits = null;

            using (_db)
            {
                Produits = new List<Produit>();
                Produits = _db.Produits.Select(p=>new Produit()
                {
                    DateAjout = p.DateAjout,
                    IsArchived = p.IsArchived,
                    Name = p.Name,
                    Price = p.Price,
                    Tva = p.Tva,
                    Id = p.Id,
                    Description = p.Description,
                    Variants = p.Variants,
                    Images = p.Images,
                    Commentaires = p.Commentaires,
                    Tags = p.Tags,
                }).ToList();
            }
            return Produits;
        }

        public Produit GetById(Guid id)
        {
            Produit Produit = null;
            using (_db)
            {
                Produit = new Produit()
                {
                    Images =        _db.Produits.FirstOrDefault(d => d.IsArchived && d.Id == id).Images,
                    Commentaires =  _db.Produits.FirstOrDefault(d => d.IsArchived && d.Id == id).Commentaires,
                    Description =   _db.Produits.FirstOrDefault(d => d.IsArchived && d.Id == id).Description,
                    Variants =      _db.Produits.FirstOrDefault(d => d.IsArchived && d.Id == id).Variants,
                    DateAjout =     _db.Produits.FirstOrDefault(d => d.IsArchived && d.Id == id).DateAjout,
                    Id =            _db.Produits.FirstOrDefault(d => d.IsArchived && d.Id == id).Id,
                    IsArchived =       _db.Produits.FirstOrDefault(d => d.IsArchived && d.Id == id).IsArchived,
                    Name =          _db.Produits.FirstOrDefault(d => d.IsArchived && d.Id == id).Name,
                    Price =         _db.Produits.FirstOrDefault(d => d.IsArchived && d.Id == id).Price,
                    Tva =           _db.Produits.FirstOrDefault(d => d.IsArchived && d.Id == id).Tva
                };
            }
            return Produit;
        }

        public void Post(Produit entity)
        {
            if (entity == null) throw new ArgumentNullException();
            using (_db)
            {
                _db.Produits.Add(entity);
                if (entity.Images != null)
                {
                    foreach (var img in entity.Images)
                    {
                        _db.Images.Add(img);
                    }
                }
                if (entity.Tags != null)
                {
                    foreach (var tag in entity.Tags)
                    {
                        _db.Tags.Add(tag);
                    }
                }
                if (entity.Variants != null)
                {
                    foreach (var variant in entity.Variants)
                    {
                        _db.Variants.Add(variant);
                    }
                }
                if (entity.Commentaires != null)
                {
                    foreach (var c in entity.Commentaires)
                    {
                        _db.Commentaires.Add(c);
                    }
                }
                if (entity.Description != null)
                {
                    _db.Descriptions.Add(entity.Description);
                }
                _db.SaveChanges();
            }
        }

        public void Put(Produit entity)
        {
            using (_db)
            {
                _db.Produits.Update(entity);
                _db.SaveChanges();
            }
        }
    }
}
