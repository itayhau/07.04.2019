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
