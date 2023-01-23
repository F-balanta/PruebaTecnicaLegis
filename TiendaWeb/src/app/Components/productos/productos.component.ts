import { ProductosDto } from './../../Models/DTO/ProductosDto';
import {Observable} from 'rxjs';
import { Component, OnInit } from '@angular/core';
import { ProductosService } from 'src/app/Services/Productos/productos-services.service';

@Component({
  selector: 'app-productos',
  templateUrl: './productos.component.html',
  styleUrls: ['./productos.component.scss']
})
export class ProductosComponent implements OnInit {
  
  constructor(
    private apiService : ProductosService
  ) { }

  ngOnInit(): void {
    
  }

  obtenerTodos(){
    this.apiService.obtenerProductos()
  }
}
