import turtle 

turtle.setup(900,900)
turtle.setworldcoordinates(0, 900, 900, 0)
turtle.hideturtle()
turtle.speed(0)
def makerect(width,height,x,y):
    turtle.seth(0)
    turtle.pu()
    turtle.goto(x,y)
    print(turtle.xcor(),turtle.ycor())
    turtle.pd()
    turtle.begin_fill()
    
    turtle.fd(width)
    turtle.right(90)
    turtle.fd(height)
    turtle.right(90)
    turtle.fd(width)
    turtle.right(90)
    turtle.fd(height)
    turtle.end_fill()


def make_head06():
    makerect(56,8,0,0)
    makerect(8,23,48,24)
    makerect(16,8,56,24)
    makerect(8,23,72,24)
    makerect(56,8,72,0)
    makerect(8,32,120,24)
    makerect(32,8,96,32)#
    makerect(8,32,87,56)
    makerect(32,8.364,88,56)
    makerect(8,16,112,70)#
    makerect(48,8,72,78)
    makerect(8,32,64,102)
    makerect(8,32,48,102)
    makerect(40,8,8,78)
    makerect(8,16,8,70)
    makerect(32,8.364,8,56)
    makerect(8,32,32,56)
    makerect(32,8,7,32)
    makerect(8,32,0,32)
make_head06()






turtle.done()
