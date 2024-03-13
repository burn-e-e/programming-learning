def game():
    
    print("game")
    
if __name__ == '__main__':
    print("Welcome!")
    mainOption = input()
    if(int(mainOption) == 1):
        game()
    elif(int(mainOption) == 2):
        print("exit")
    else:
        exit