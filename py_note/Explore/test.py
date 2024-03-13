class Monster:
    def __init__(self, health, energy):
        self.health = health
        self.energy = energy
    
    def __len__(self):
        return self.health
    
    def __abs__(self):
        return self.energy
    
    def __call__(self):
        print('The monster was called')
    
    def __add__(self, other):
        return self.health + other
    
    def __str__(self):
        return f"Monster has {self.health} health and {self.energy} energy."
    
    def attack(self, amount):
        print("The monster has attacked")
        print(f'{amount} damage was dealt')
        self.energy -= 20
        print(self.energy)
    def move(self, speed):
        print(f"Monster has moved {speed}")
monster1 = Monster(10,20)
monster1
