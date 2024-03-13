class Monster:
    # health = 50
    # energy = 100
    def __init__(self, health, energy):
        self.health = health
        self.energy = energy
    def attack(self, amount):
        print("The Monster attacked")
        print(f"{amount} damage was dealt")
        self.energy -= 20
    
    def move(self,speed):
        print("The monster has moved")
        print(f"it has speed of {speed}")
        
class Shark(Monster):
    def __init__(self, speed, health, energy):
        super().__init__(health, energy)
        self.speed = speed
    def bite(self):
        print("The shark has bitten")
    def move(self):
        print("The shark has moved")
        
shark = Shark(120, 100, 80)
shark.move()
print(shark.health)
