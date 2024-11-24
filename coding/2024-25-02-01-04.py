# import package 
import tkinter.colorchooser
from turtle import * 
import tkinter
t=Turtle
stat=True
s=Screen()
squarecount=0
speed(9)
color1=[]
color2=[]
def square():
    global squarecount
    global stat
    global t
    global s

    for i in range(5):
             if squarecount ==14:
                 stat=True
             if squarecount>=11 and squarecount<=13:
                stat=False
                
                penup()
                forward(200)
                right(90)
                forward(200)
                right(90)
                forward(200)
                right(90)
                forward(200)
                penup()
                right(90)
                forward(200)
                squarecount+=1
                print(squarecount)
                print(stat)
             elif stat==True:
                stat=True
                #color(color1[0],color1[1],color1[2])
                begin_fill()
                pendown()
                forward(200)
                right(90)
                forward(200)
                right(90)
                forward(200)
                right(90)
                forward(200)
                penup()
                right(90)
                forward(200)
                end_fill()
                squarecount+=1
                print(squarecount)
                print(stat)
                stat=False

             elif stat == False:
                pendown()
                #color(color2)
                begin_fill()
                forward(200)
                right(90)
                forward(200)
                right(90)
                forward(200)
                right(90)
                forward(200)
                penup()
                right(90)
                forward(200)
                stat=True
                squarecount+=1
                print(squarecount)
                print(stat)
                end_fill()


def grid():
    global color1
    global color2
    #color1 = list(tkinter.colorchooser.askcolor)
    #color2 = list(tkinter.colorchooser.askcolor)
    print(color1)
    print(color2)
    penup()
    goto(-500,500)
    pendown()
    square()
    penup()
    goto(-500,300)
    pendown()
    square()
    penup()
    goto(-500,100)
    pendown()
    square()
    penup()
    goto(-500,-100)
    pendown()
    square()
    penup()
    goto(-500,-300)
    pendown()
    square()
    

               
            
                
            
s.setup(1020,1000)
grid()
goto(0,-5)
write("Hello, World", font=("impact",20,"normal"), align="center")
mainloop()
