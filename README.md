# turnBasedBattleGame
proiect medii si platforme

📚 DESIGN PATTERNS ÎN PROIECT
1. Factory Pattern

🔹 Ce este:
Factory Pattern este un pattern creational care permite crearea obiectelor fără să specificăm exact clasa concretă care va fi instanțiată. Factory-ul decide ce instanță să returneze.

🔹 Cum e folosit aici:

Avem o clasă CharacterFactory.

Aceasta primește tipul de caracter dorit (CharacterType.Warrior, CharacterType.Archer, CharacterType.Mage) și creează obiectul potrivit (Warrior, Archer, Mage).

Nu trebuie să știm cum se creează exact fiecare caracter. Factory-ul se ocupă de detalii.

🔹 De ce e util aici:

Separăm logica de creare de restul aplicației.

Ușor de adăugat noi tipuri de caractere pe viitor (ex: Paladin, Assassin) fără să stricăm codul vechi.

Respectăm principiul Open/Closed din SOLID (Open for extension, Closed for modification).

2. Strategy Pattern
   
🔹 Ce este:
Strategy Pattern este un pattern comportamental care permite schimbarea comportamentului unui obiect în timpul execuției, alegând o strategie potrivită.

🔹 Cum e folosit aici:

Atacurile și vindecarea sunt definite ca strategii.

Avem interfețe precum IAttackStrategy și IHealingStrategy.

Fiecare caracter primește o strategie potrivită la crearea lui:

MeleeAttack pentru Warrior,

RangedAttack pentru Archer,

MagicAttack + HealingSpell pentru Mage.

Atunci când caracterul atacă sau se vindecă, folosește strategia setată, fără să știe detaliile implementării.

🔹 De ce e util aici:

Comportamentele de atac/vindecare pot fi schimbate dinamic.

Codul este foarte modular și extensibil.

Dacă vrem să adăugăm un nou tip de atac (ex: PoisonAttack), nu modificăm clasele existente, ci adăugăm o nouă strategie.
