using CompositeDP.Concretes;

CompositeSoldier general = new("Namiq", "General");

CompositeSoldier mayor = new("Rustem", "Mayor");

LeafSoldier esger = new("Islam", "Esger");

LeafSoldier esger1 = new("Huseyn", "Esger");

mayor.AddSoldier(esger);

mayor.AddSoldier(esger1);

general.AddSoldier(mayor);

mayor.ExecuteCommand();

