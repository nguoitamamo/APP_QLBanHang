from sqlalchemy import Column, Integer, String, Float, ForeignKey
from sqlalchemy.orm import relationship
from app import app, db


class Cates(db.Model):
    id = Column(Integer, primary_key=True, autoincrement=True)
    name = Column(String(20), nullable=False)
    Products = relationship('Products', backref='cates', lazy=True)


class Products(db.Model):
    id = Column(Integer, primary_key=True, autoincrement=True)
    name = Column(String(20), nullable=False)
    description= Column(String(50), nullable=False )
    price = Column(Float, nullable=False)
    image = Column(String(100), nullable=True)
    category_id = Column(Integer, ForeignKey('cates.id'), nullable=False)


if __name__ == "__main__":
    with app.app_context():
        # db.create_all()

        # c1 = Cates(name="Mobile")
        # c2 = Cates(name="Tablet")
        # c3 = Cates(name="Desktop")
        # db.session([c1, c2, c3])
        # db.session.commit()
        produt = [{
            "id": 1,
            "name": "iPhone 7 Plus",
            "description": "Apple, 32GB, RAM: 3GB, iOS13",
            "price": 17000000,
            "image": "https://res.cloudinary.com/dxxwcby8l/image/upload/v1647056401/ipmsmnxjydrhpo21xrd8.jpg",
            "category_id": 1
        }, {
            "id": 2,
            "name": "iPad Pro 2020",
            "description": "Apple, 128GB, RAM: 6GB",
            "price": 37000000,
            "image": "https://res.cloudinary.com/dxxwcby8l/image/upload/v1646729533/zuur9gzztcekmyfenkfr.jpg",
            "category_id": 2
        }, {
            "id": 3,
            "name": "Galaxy Note 10 Plus",
            "description": "Samsung, 64GB, RAML: 6GB",
            "price": 24000000,
            "image": "https://res.cloudinary.com/dxxwcby8l/image/upload/v1647248722/r8sjly3st7estapvj19u.jpg",
            "category_id": 1

        }]
        for i in produt:
            c = Products(**i)
            db.session.add(c)
        db.session.commit()
