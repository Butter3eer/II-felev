filmek = [
 ("Star Wars: Az ébredő Erő", "2015", 2068223624),
 ("Avatar", "2009", 2787965087),
 ("Titanic", "1997", 2187463944),
 ("Az Oroszlánkirály", "2019", 1656943394),
 ("Az Avengers: Végjáték", "2019", 2797800564),
 ("Harry Potter és a Halál Ereklyéi, 2. rész", "2011", 1341511219),
 ("Jurassic World", "2015", 1671713208),
 ("Az Igazság Ligája", "2017", 657924295),
 ("A Hobbit: Az öt sereg csatája", "2014", 956019788),
 ("Batman v Superman: Az igazság hajnala", "2016", 873634919),
 ("A Gyűrűk Ura: A király visszatér", "2003", 1146030912),
 ("Toy Story 4", "2019", 1073394593),
 ("Transformers: Az utolsó lovag", "2017", 605425157),
 ("Harcosok klubja", "1999", 101208309),
 ("A fiúk, akikért rajongunk", "1984", 381109762),
 ("Zöld lámpa", "2011", 219851172),
 ("G.I. Joe - A kobra árnyéka", "2009", 302469017),
 ("X-Men: Az elsők", "2011", 353624124),
 ("Pókember: Hazatérés", "2017", 880166924),
 ("Az Első Tiszt", "2018", 438335797)
]

def TxtFileIras() :
    file = open("filmek.txt", "w", encoding="UTF-8")
    for items in filmek :
        file.write(f"{items[0]};{items[1]};{items[2]}\n")

TxtFileIras()