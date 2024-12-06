#import turtle as t

#t.bgpic("C:\\Users\\Brandon Mertes\\Desktop\\cornbreads\\coding II\\owl.png")
#
#t.shapesize()
#t.speed(9999)
animalShapes = {
    'Owl':[
        25,
        ((0,-2),(1.7,-6),(0.7,-7),(0,-11)), #beak
        ((0,12),(7,10),(13.5,11.4),(12,7),(10,6),(11,-3),(7,-8.5),(5,-7.5),(0,-9)), #head
        ((8,9),(6.5,7.5),(9,6.5)), #ear
        ((8,8),(11,9.5)), #ear scritch
        ((0,5),(0,10)), #head line middle
        ((3,7),(1.5,2.5)), #head line edge
        ((0.5,-3),(3,1.5),(7.5,2.5),(6.5,0),(1.8,-1)), #eye
        ((6,-1.8),(1.8,-1),(5.5,-3.2),(1.8,-1),(4,-4)), #eyelines

    ],
    'Mogus':[
        ()
    ]
}

def mirrorFormat(list):
    output = []
    for item in list:
        output.insert(0,(item[0]*-1,item[1]))
    return output

def drawLine(start,stop,turtle=t):
    turtle.penup()
    turtle.goto(start)
    turtle.pendown()
    turtle.goto(stop)
    turtle.penup()

def CordMult(tuple,mult):
    return (tuple[0]*mult,tuple[1]*mult) #ugly but works!!


def drawGrid(size,ppl=25):
    halfsize = size//2
    for y in range(-halfsize,halfsize+1,ppl):

        if y == 0: t.pensize(5)
        else: t.pensize(1)

        drawLine((y,halfsize),(y,-halfsize))
        drawLine((halfsize,y),(-halfsize,y))

def drawShape(shape=animalShapes["Owl"],turtle=t,scaleMultiplier=1):
    turtle.penup()
    scaleFactor = shape[0]*scaleMultiplier
    for segment in shape:
        if type(segment) != int:
            drawSegment(segment,scaleFactor,turtle)

def drawSegment(segment,scaleFactor=20,turtle=t,mirror=True):
    print(segment,mirror)
    turtle.penup()
    turtle.goto(CordMult(segment[0],scaleFactor))
    turtle.pendown()
    for cord in segment:
        turtle.goto(CordMult(cord,scaleFactor))
    if mirror:
        segment = mirrorFormat(segment)

        drawSegment(segment,scaleFactor,turtle,mirror=False)

#drawGrid(650)
#drawGrid(500,ppl=50)
t.penup()
t.goto(10,10)
t.fillcolor("cyan")
t.shapesize(3)
t.pensize(3)
t.pensize(4)
t.color("black")
drawShape()



t.mainloop()