import models

def load_cates():
    return models.Cates.query.all()


def load_products():
   return models.Products.query.all()