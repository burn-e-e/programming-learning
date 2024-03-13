class Monster:
    def __init__(self, func):
        self.func = func
class Attacks:
    def stike(self):
        print("Striking")
    def kick(self):
        print("Kicking")
attacks = Attacks()
m1 = Monster(attacks.kick())        