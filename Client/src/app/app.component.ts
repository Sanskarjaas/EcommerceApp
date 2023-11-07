import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';
import { environmentVariables } from './constants/environmentVariables';
import { Product } from './shared/models/products';
import { Pagination } from './shared/models/pagination';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  title = 'Client';
  products:Product[]=[];


  constructor(private http:HttpClient){}


  ngOnInit():void{
    this.http.get<Pagination<Product[]>>('https://localhost:7090/api/product?pageSize=1&pageIndex=1').subscribe({
      //next:response=>{this.products=response.data},
      next:(response:any)=>{ this.products=response},
        //console.log('response is', response)
       
      error:error => console.log(error),
      complete :()=>{
        console.log('request complete');
        console.log('extra statement');
        
      }
    })
  }

}
