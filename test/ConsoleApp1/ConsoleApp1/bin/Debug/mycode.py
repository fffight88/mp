import folium
import pandas as pd
import json

geo_path = 'seoul_gu.json'
geo_str = json.load(open(geo_path, encoding='utf-8'))

geo_str