import turtle 

turtle.setup(900,900)
turtle.setworldcoordinates(0, 900, 900, 0)
turtle.hideturtle()
turtle.speed(0)

for x in range(100):
    turtle.forward(x * 0.05)
    turtle.seth(x^2)