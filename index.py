
from app import app
from flask import Flask, render_template
import dao




@app.route("/")
def index():
    cates = dao.load_cates()
    products = dao.load_products()
    return render_template('index.html' , cates = cates, products= products)


if __name__ == '__main__':
    app.run(debug=True)