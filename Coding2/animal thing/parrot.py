#LEVIS PARROT



# Rules: 900 x 900 canvas
#pensize(4)
#screensize(900,900)
#speed(999)

def draw_parrot(t):
    #First Half
    t.hideturtle()
    t.penup()
    t.goto(0,350)
    t.pendown()
    t.goto(-100,300)
    t.goto(-160,150)
    t.goto(-230,50)
    t.goto(-180,0)
    t.goto(-180,-50)
    t.goto(-90,-40)
    t.goto(-40,-80)
    t.goto(0,-20)
    t.penup()
    t.goto(0,250)
    t.pendown()
    t.goto(-40,230)
    t.goto(-60,150)
    t.goto(0,0)
    t.end_fill()
    t.penup()
    t.goto(-75,270)
    t.pendown()
    t.goto(-30,270)
    t.goto(-40,250)
    t.goto(-85,250)
    t.goto(-75,270)

#Second half
    t.clone()
    t.hideturtle()
    t.penup()
    t.goto(0,350)
    t.pendown()
    t.goto(100,300)
    t.goto(160,150)
    t.goto(230,50)
    t.goto(180,0)
    t.goto(180,-50)
    t.goto(90,-40)
    t.goto(40,-80)
    t.goto(0,-20)
    t.penup()
    t.goto(0,250)
    t.pendown()
    t.goto(40,230)
    t.goto(60,150)
    t.goto(0,0)
    t.end_fill()
    t.penup()
    t.goto(75,270)
    t.pendown()
    t.goto(30,270)
    t.goto(40,250)
    t.goto(85,250)
    t.goto(75,270)
    
    
   


#drawParrot()
#mainloop()
#END OF LEVIS PARROT