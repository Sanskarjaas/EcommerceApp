import { Component, OnInit } from '@angular/core';
import { Product } from '../shared/models/products';

@Component({
  selector: 'app-shop',
  templateUrl: './shop.component.html',
  styleUrls: ['./shop.component.scss']
})
export class ShopComponent implements OnInit{
  products:Product[]=[];
  constructor()
  ngOnInit():void{
    throw 
  }

}
