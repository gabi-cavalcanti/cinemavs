using filmes.alura;
List<filme> mfilmes = new List<filme>();
List<artistas> martista = new List<artistas>();

filme f1 = new filme("De volta pro futuro",116);
filme f2 = new filme("O poderoso chefão",175);
filme f3 = new filme("O senhor dos aneis",178);
filme f4 = new filme("O exorcista",122);
filme f5 = new filme("O iluminado",146);
filme f6 = new filme("O Pequeno Stuart Little", 84);

artistas a1 = new artistas("Michael J. Fox", 62);
artistas a2 = new artistas("Christopher Lloyd", 87);
artistas a3 = new artistas("Lea Thompson", 64);
artistas a4 = new artistas("Marlon Brando", 80);
artistas a5 = new artistas("Al Pacino", 85);
artistas a6 = new artistas("Diane Keaton", 74);
artistas a7 = new artistas("Elijah Wood", 43);
artistas a8 = new artistas("Ian McKellen", 84);
artistas a9 = new artistas("Viggo Mortensen", 64);
artistas a10 = new artistas("Linda Blair", 63);
artistas a11 = new artistas("Ellen Burstyn", 90);
artistas a12 = new artistas("Stellan Skarsgård", 74);
artistas a13 = new artistas("Jack Nicholson", 86);
artistas a14 = new artistas("Shelley Duvall", 77);
artistas a15 = new artistas("Danny Lloyd", 45);
artistas duble = new artistas("Tom Hardy", 46);

f1.adicionarartista(a1,a2,a3);
f2.adicionarartista(a4,a5,a6);
f3.adicionarartista(a7,a8,a9);
f4.adicionarartista(a10,a11,a12);
f5.adicionarartista(a13,a14,a15);
f6.adicionarartista(a1);
f1.Exibirfichatecnica();
a1.exibirfichatecnicaartistaI();