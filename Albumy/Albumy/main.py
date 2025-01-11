from tkinter import *
import tkinter.font as tkFont
def wczytajDane():
    with open('Data.txt', 'r', encoding='utf-8') as f:
        wiersze = f.readlines()
    for i in range(0, len(wiersze)):
        wiersze[i] = wiersze[i].strip()
    wiersze[0] = wiersze[0].lstrip('\ufeff')
    return wiersze

def wyswietlDane(albumy):
    for i in range(0, len(albumy)):
        for j in range(0, 5):
            print(albumy[i][j])
        print('')

dane = wczytajDane()
album = []
albumy = []
for i in range(0, len(dane)):
    if dane[i] != '':
        album.append(dane[i])
    else:
        albumy.append(album)
        album = []
albumy.append(album)


## tu zaczyna sie kod do tkintera, wczesniej ctrl c ctrl v konsolowa
def zmienPrawo():
    global obecne
    if obecne != len(albumy) - 1:
        obecne +=1
    else:
        obecne = 0

    albumZespol.config(text=albumy[obecne][0])
    albumTytul.config(text=albumy[obecne][1])
    albumIloscPiosenek.config(text=(albumy[obecne][2] + " utworów"))
    albumRok.config(text=albumy[obecne][3])
    albumIloscPobran.config(text=albumy[obecne][4])

def pobierz():
    global obecne
    albumy[obecne][4] = int(albumy[obecne][4]) + 1
    albumIloscPobran.config(text=albumy[obecne][4])

def zmienLewo():
    global obecne
    if obecne != 0:
        obecne -= 1
    else:
        obecne = len(albumy) - 1

    albumZespol.config(text=albumy[obecne][0])
    albumTytul.config(text=albumy[obecne][1])
    albumIloscPiosenek.config(text=(albumy[obecne][2] + " utworów"))
    albumRok.config(text=albumy[obecne][3])
    albumIloscPobran.config(text=albumy[obecne][4])

obecne = 0
print(albumy)

root = Tk()
root.geometry('1200x400')
root.title('Aplikacje Wykonał: Karol')
root.resizable(False,False)
root.configure(background='#2E8B57')

strzalkaLewo = PhotoImage(file='obraz3.png')
strzalkaLewoPrzycisk = Button(root, text='', image=strzalkaLewo, height=70, command=zmienLewo).pack(side=LEFT)

strzalkaPrawo = PhotoImage(file='obraz2.png')
strzalkaPrawoPrzycisk = Button(root, text='', image=strzalkaPrawo, height=70, command=zmienPrawo    ).pack(side=RIGHT)

plyta = PhotoImage(file='obraz.png')
plytaZdjecie = Label(root, image=plyta, background='#2E8B57').place(x=200, y=50)

fontTytul = tkFont.Font(family="Arial", size=30, slant='italic')
fontButton = tkFont.Font(family="Arial", size=20, weight='bold')

albumZespol = Label(root, text=albumy[obecne][0], font=("Arial", 50), background='#2E8B57', foreground='white')
albumZespol.place(x=450, y=50)

albumTytul = Label(root, text=albumy[obecne][1], font=fontTytul, background='#2E8B57', foreground='white')
albumTytul.place(x=450, y=130)

albumIloscPiosenek = Label(root, text=(albumy[obecne][2] + " utworów"), font=("Arial", 20), background='#2E8B57', foreground='#61D918')
albumIloscPiosenek.place(x=450, y=180)

albumRok = Label(root, text=(albumy[obecne][3]), font=("Arial", 20), background='#2E8B57', foreground='#61D918')
albumRok.place(x=600, y=180)

albumIloscPobran = Label(root, text=albumy[obecne][4], font=("Arial", 20), background='#2E8B57', foreground='#61D918')
albumIloscPobran.place(x=200, y=300)

albumPobierz = Button(root , text="Pobierz", font=fontButton, background='#61D918', command=pobierz)
albumPobierz.place(x=350, y=290)

root.mainloop()