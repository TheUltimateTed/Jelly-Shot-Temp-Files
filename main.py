startDirection = 0
posX = 0
posY = 0
invItems = 0
health = 10
Coins = 100
gameover = 0

def looseHealth (amount):
  global health
  health = health - amount
  if health < 1:
    gameover = 1

def addBullets (am2):
  global Coins
  Coins = Coins - am2
  if Coins < 1:
    gameover = 1

def gameover ():
  global gameover
  if gameover == 1:
    print("Whoops Game Over")


username = input("What Do You Want Your Name To Be?")

print("Welcome To Jelly Shot " + str(username))

print("current health: " + str(health) + "/10")
print("current Coins: " + str(Coins))
