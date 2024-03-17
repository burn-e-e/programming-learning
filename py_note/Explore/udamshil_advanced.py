class Monster:
    def __init__(self, health, energy):
        self.health = health
        self.energy = energy
    
    def attack(self, amount):
        print('The Monster has attacked')
        print(f'The Monster has dealth {amount} damage')
        self.energy -= 20
    def move (self, speed):
        print("The Monster has moved")
        print(f"It has a speed of {speed}")
class Fish:
    def __init__(self, speed, has_scales):
        self.speed = speed
        self.has_scales = has_scales
    def swim(self):
        print(f"The fish is swimming at a speed of {self.speed}")
class Shark(Monster, Fish):
    def __init__(self, bite_str, health, energy, speed, has_scales):
        self.bite_str = bite_str
        super().__init__(health, energy)
print(Shark.mro())    