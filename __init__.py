from flask_sqlalchemy import SQLAlchemy
from flask import Flask
from urllib.parse import quote

app = Flask(__name__)
app.config["SQLALCHEMY_DATABASE_URI"]= "mysql+pymysql://root:%s@localhost/saleapp"  % quote("Admin@123")
app.config["SQLAICHEMY_TRACK_MODIFICATIONS"]= True
db =SQLAlchemy(app= app)
