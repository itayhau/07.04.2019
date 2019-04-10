            int i = 0;
            var result1 = from c2 in countries
                          where c2.Size_km == (from c in countries
                                               select c.Size_km).Count()
                          select c2;

            var result2 = from c3 in countries
                          where c3.Size_km == (from c_ in countries
                                               where c_.Id == c3.Id
                                               select c_.Size_km
                                               ).Max()
                          select c3;

            int s1 = (from c in countries
                     select c.Size_km).Max();

from p in Product
join c in Catalog on c.Id equals p.CatalogId
join m in Manufacturer on m.Id equals p.ManufacturerId
where p.Active == 1
select new { Name = p.Name, CatalogId = p.CatalogId, ManufacturerId = p.ManufacturerId, CatalogName = c.Name, ManufacturerName = m.Name };

from p in Product
from c in Catalog
from m in Manufacturer
where c.Id == p.CatalogId && m.Id == p.ManufacturerId && p.Active == 1
select new 
    { 
        p.Name,
        p.CatalogId,
        p.ManufacturerId,
        c.Name,
        m.Name 
    };
