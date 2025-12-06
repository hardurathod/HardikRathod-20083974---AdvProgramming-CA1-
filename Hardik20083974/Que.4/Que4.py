from bs4 import BeautifulSoup
import csv

data = []


with open("hotelA.html", "r", encoding="utf-8") as f:
    soup = BeautifulSoup(f, "html.parser")
    rooms = soup.find_all("div", class_="room-card")
    for room in rooms:
        name = room.find("h3").text.strip()
        price = room.find("div", class_="price").text.strip()
        data.append(["Hotel A", name, price])


with open("hotelB.html", "r", encoding="utf-8") as f:
    soup = BeautifulSoup(f, "html.parser")
    rooms = soup.find_all("div", class_="room-card")
    for room in rooms:
        name = room.find("h3").text.strip()
        price_tag = room.find("div", class_="price")  # try room-info
        if not price_tag:
            price_tag = room.find("div", class_="price-tag")  # fallback
        price = price_tag.text.strip()
        data.append(["Hotel B", name, price])



with open("HotelRooms.csv", "w", newline="", encoding="utf-8") as f:
    writer = csv.writer(f)
    writer.writerow(["Hotel", "Room", "Price"])
    writer.writerows(data)


with open("HotelRooms.csv", "r", encoding="utf-8") as f:
    reader = csv.DictReader(f)
    for row in reader:
        print(row)
