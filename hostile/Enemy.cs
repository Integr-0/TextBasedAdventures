namespace project{
    class Enemy{
    public Enemy(string name, int health, int damage, int chanceToAppear, int defence, bool immuneAgainstMagic, ItemList drops){
        this.name = name;
        this.health = health;
        this.damage = damage;
        this.chanceToAppear = chanceToAppear;
        this.defence = defence;
        this.immuneAgainstMagic = immuneAgainstMagic;
        onDied += () => {
            Program.inventory.addAll(drops);
            Logger.DefaultMessage($"You killed the enemy {name}", ConsoleColor.DarkRed);
        };
    }
    public string name;
    public int health;
    public int damage;
    public int chanceToAppear;
    public int defence;
    public bool immuneAgainstMagic;
    public event Action onDied;
}
}