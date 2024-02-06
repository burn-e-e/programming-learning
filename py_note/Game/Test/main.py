from inspect import stack
import random
stack = []

def game():
    numberOfBullets = random.randint(2, 6)
    count = 0
    for i in range(numberOfBullets):
        state = random.randint(0,1)
        if(state == 1):
            count+=1
        stack.append(state)
    print("[",count, " сум, ", numberOfBullets - count, " хонгио ]")
    print(stack)
    option()

def option():
    myhp, ophp = 2, 2
    while(myhp > 0 or ophp < 0):
        print("1. Shoot yourself\n2. Shoot opponent")
        choose = int(input())
        if(choose == 1):
           damage = stack[len(stack)-1]
           myhp -= damage
        elif(choose == 2):
           damage = stack[len(stack)-1]
           ophp -= damage
        else:
            print("Buruu buudla")
            option()
        print(myhp, "/", ophp)

def menu():
    print("----WELCOME----")
    print("1. Тоглох\n2. Түвшин")
    x = input()
    if x == "1":
        game()
    elif x == "2":
        print("2")
    else:
        print("Wrong!")

if __name__ == '__main__':
    # menu()
    game()