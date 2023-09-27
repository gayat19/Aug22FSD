import { Component } from '@angular/core';
import { Product } from '../models/product';

@Component({
  selector: 'app-addproduct',
  templateUrl: './addproduct.component.html',
  styleUrls: ['./addproduct.component.css']
})
export class AddproductComponent {
  product:Product =new Product();
  constructor(){
    
  }

  changeVeg(){
    this.product.type="Veg";

  }
  changeNonVeg(){
    this.product.type="Non-Veg";

  }
  assignFile(pic:any){
    this.product.pic = "/assets/images/"+pic.files[0].name;
    console.log(this.product)
  }
}
