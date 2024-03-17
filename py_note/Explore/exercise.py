class Monster:
    def __init__(self, health, energy):
        self.health = health
        self.energy = energy
    def damage(self):
        print("The monster is attacking")
class Scorpion(Monster):
    def __init__(self, health, energy, poison_damage):
        self.poison_damage = poison_damage
        super().__init__(health, energy)
    def damage(self):
        print(f"Scorpion poisoning you {self.poison_damage}")
s = Scorpion(100, 20, 10)
s.damage()