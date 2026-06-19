import math
from abc import ABC, abstractmethod


class IDrawable(ABC):
    @abstractmethod
    def draw(self):
        pass

class Shape(ABC):
    @abstractmethod
    def calculate_area(self):
        pass

class Circle(Shape, IDrawable):
    def __init__(self, radius):
        self.radius = radius

    def calculate_area(self):
        return math.pi * (self.radius ** 2)

    def draw(self):
        print(f"Малюємо коло з радіусом {self.radius}")


class Square(Shape, IDrawable):
    def __init__(self, side):
        self.side = side

    def calculate_area(self):
        return self.side ** 2

    def draw(self):
        print(f"Малюємо квадрат зі стороною {self.side}")


class Triangle(Shape, IDrawable):
    def __init__(self, base, height):
        self.base = base
        self.height = height

    def calculate_area(self):
        return 0.5 * self.base * self.height

    def draw(self):
        print(f"Малюємо трикутник з основою {self.base} та висотою {self.height}")

if __name__ == "__main__":
    shapes = [
        Circle(radius=5),
        Square(side=4),
        Triangle(base=6, height=3)
    ]

    print("--- Демонстрація поліморфізму ---\n")
    for shape in shapes:
        shape.draw()  
        print(f"Площа: {shape.calculate_area():.2f}\n")
