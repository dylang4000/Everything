import turtle
from cow import draw_cow
from crocodile import draw_crocodile
from deer import draw_deer
from elephant import draw_elephant
from giraffe import draw_giraffe
#from owl import drawShape
from parrot import draw_parrot
from rabbit import draw_rabbit
#from turt import draw_turtle




selector=0

functionsanimals=[draw_cow, draw_crocodile,draw_deer,draw_elephant,draw_giraffe,draw_parrot,draw_rabbit,]
turtle.speed(0)
turtle.tracer(2)
turtle.width(4)


functionsanimals[selector](turtle)
def select():
    print('asdfasdf')
    global selector
    selector+=1
    if selector>6:
        selector=0
    turtle.home()
    turtle.clear()
    print(selector)
    functionsanimals[selector](turtle)
def negativeselect():
    
    global selector
    selector-=1
    if selector<-6:
        selector=6
    turtle.home()
    turtle.clear()
    print(selector)
    functionsanimals[selector](turtle)  


turtle.onkeypress(select,'d')
turtle.onkeypress(negativeselect,'a')
turtle.listen()
turtle.mainloop()