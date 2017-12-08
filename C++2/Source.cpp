#include<iostream>
#include<string>
using namespace std;

//|


//Proba I

//int main() {
//
//	double zbir = 0;
//	double prosek;
//	int brPredmeta = 11;
//	int ocena;
//
//	cout << "Sta imas iz srpskog?\n";
//	cin >> ocena;
//	zbir += ocena;
//
//	cout << "Sta imas iz matematike?\n";
//	cin >> ocena;
//	zbir += ocena;
//
//	cout << "Sta imas iz fizickog?\n";
//	cin >> ocena;
//	zbir += ocena;
//
//	cout << "Sta imas iz engleskog?\n";
//	cin >> ocena;
//	zbir += ocena;
//
//	cout << "Sta imas iz fizike?\n";
//	cin >> ocena;
//	zbir += ocena;
//
//	cout << "Sta imas iz hemije?\n";
//	cin >> ocena;
//	zbir += ocena;
//
//	cout << "Sta imas iz ruskog?\n";
//	cin >> ocena;
//	zbir += ocena;
//
//	cout << "Sta imas iz muzickog?\n";
//	cin >> ocena;
//	zbir += ocena;
//
//	cout << "Sta imas iz likovnog?\n";
//	cin >> ocena;
//	zbir += ocena;
//
//	cout << "Sta imas iz kung-fu-a?\n";
//	cin >> ocena;
//	zbir += ocena;
//
//	cout << "Sta imas iz kibernetike?\n";
//	cin >> ocena;
//	zbir += ocena;
//
//	prosek = zbir / brPredmeta;
//
//	cout << "Tvoj prosek je:" << prosek << endl;
//
//	system("pause");
//	return 0;
//}


//Proba II

//int main() 
//{
//	int a, b, a1, b1;
//
//	cout << "Duzina1" << endl;
//	cin >> a ;
//
//	cout << "Sirina1" << endl;
//	cin >> b;
//
//	cout << "Duzina2" << endl;
//	cin >> a1;
//
//	cout << "Sirina2" << endl;
//	cin >> b1;
//
//	if (a1 > a || a1 > b || b1 > a || b1 > b)
//	{
//		cout << "Ne moze da stane" << endl;
//	}
//	else
//	{
//		cout << "Moze da stane" << endl;
//	}
//
//
//	system("pause");
//}


//Proba III

//int main()
//{
//	int s, m, u;
//
//	cout << "Serbski";
//	cin >> s;
//
//	cout << "Mata";
//	cin >> m;
//
//	u = s + m;
//
//	if (s > 5 && m > 5 && u > 25)
//	{
//		cout << "1";
//	}
//	else
//	{
//		cout << "0";
//	}
//
//	system("pause");
//
//}


//Proba IV

//int main()
//{
//	int mika, pera, joca;
//
//	bool mika_na_igralistu, pera_na_igralistu, joca_na_igralistu;
//
//	int brojNaIgralistu;
//
//	std::cout << "Unesi koliko zadataka je uradio Mika, koliko Joca a koliko Pera:" << std::endl;
//
//	std::cin >> mika >> joca >> pera;
//
//	mika_na_igralistu = mika >= 3;
//
//	pera_na_igralistu = pera >= 3;
//
//	joca_na_igralistu = joca >= 3;
//
//	brojNaIgralistu = 0;
//
//	if (mika_na_igralistu)
//
//	{
//
//		brojNaIgralistu += 1;
//
//	}
//
//	if (pera_na_igralistu)
//
//	{
//
//		brojNaIgralistu += 1;
//
//	}
//
//	if (joca_na_igralistu)
//
//	{
//
//		brojNaIgralistu += 1;
//
//	}
//
//	std::cout << brojNaIgralistu << std::endl;
//
//	system("pause");
//
//}


//Proba V

//int main()
//{
//	int j, p, k;
//
//	cout << "Koraci do Jodze *razmak Koraci do Pere" << endl;
//	cin >> j >> p;
//
//	k = abs(j - p);
//
//	cout << k << endl;
//
//	system("pause");
//}


//Proba VI

//int main()
//{
//	int BpK, BpP, R, Provera;
//
//	cout << "Broj plocica za kupatilo *razmak Broj plocica u jednom paketu" << endl
//		;
//	cin >> BpK >> BpP;
//
//	R = BpK / BpP;
//	Provera = BpK % BpP;
//
//	if (Provera != 0)
//	{
//		R += 1;
//	}
//
//	cout << R << endl;
//
//	system("pause");
//}


//Proba VII

//int main()
//{
//	int sirinaOrmana, visinaOrmana;
//	int sirinaLevihVrata, visinaLevihVrata;
//	int sirinaDesnihVrata, visinaDesnihVrata;
//	cout << "Unesite sirinu i visinu ormara: " <<endl;
//	cin >> sirinaOrmana >> visinaOrmana;
//	cout << "Unesite sirinu i visinu levih vrata: " << endl;
//	cin >> sirinaLevihVrata >> visinaLevihVrata;
//	cout << "Unesite sirinu i visinu desnih vrta: " << endl;
//	cin >> sirinaDesnihVrata >> visinaDesnihVrata;
//
//	if (sirinaOrmana = sirinaLevihVrata + sirinaDesnihVrata)
//	{
//		if (visinaLevihVrata = visinaDesnihVrata)
//		{
//			if (visinaOrmana % visinaLevihVrata == 0)
//			{
//				cout << "Potrebno je " <<
//					visinaOrmana / visinaLevihVrata <<
//					" parova vrata. " << endl;
//			}
//			else
//			{
//				cout << "Vrata nisu odgovarajuce visine." << endl;
//			}
//		}
//		else
//		{
//			cout << "Vrata nisu jednake visine." << endl;
//		}
//	}
//	else
//	{
//		cout << "Vrata nisu odgovarauce sirine. " << endl;
//	}
//
//	cout << endl ;
//
//	system("pause");
//	return 0;
//}


//Proba VIII

//int main()
//{
//	int a, b, c, Provera1, Provera2, Provera3;
//	cin >> a >> b >> c;
//
//	Provera1 = a / b;
//	Provera2 = b / c;
//	Provera3 = a / c;
//
//		if ((a == b || b == c || a == c) && (Provera1 != 1 && Provera2 !=1 && Provera3 != 1))
//	{
//		cout << "Moze" << endl;
//	}
//
//	system("pause");
//
//}

