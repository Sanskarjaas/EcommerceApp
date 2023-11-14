import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Pagination } from '../shared/models/pagination';
import { Product } from '../shared/models/product';
import { Brand } from '../shared/models/brand';
import { Type } from '../shared/models/type';

@Injectable({

  providedIn: 'root'
  
})

export class ShopService {
  baseUrl='https://localhost:7090/api/'
  constructor(private http:HttpClient) { }                                                                     
  getProductswithPagination(){
    return this.http.get<Pagination<Product[]>>(this.baseUrl+'product?pageSize=20');
  }
  getBrands(){
    return this.http.get<Brand[]>(this.baseUrl+'product/brands'); 
  }
  getTypes(){
    return this.http.get<Type[]>(this.baseUrl+'product/types');  
  }
  getProducts(){
    return this.http.get<Product[]>(this.baseUrl+'product');
  }
}
