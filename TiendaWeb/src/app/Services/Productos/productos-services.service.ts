import { ProductosDto } from './../../Models/DTO/ProductosDto';
import { Injectable } from '@angular/core';
import { HttpClient} from '@angular/common/http'

@Injectable({
  providedIn: 'root'
})
export class ProductosService {

  constructor(
    private http: HttpClient

  ) { }


  apiUrl = "https://localhost:7177/productos/"

  obtenerProductos(){
    this.http.get<ProductosDto[]>(this.apiUrl + "obtener");
  }

  crearProducto(producto : ProductosDto){
    this.http.post(this.apiUrl + "crear" + "/", producto);
  }
}
