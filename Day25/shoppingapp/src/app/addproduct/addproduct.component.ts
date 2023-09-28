import { Component, ViewChild } from '@angular/core';
import { Product } from '../models/product';
import {NgForm} from '@angular/forms';

@Component({
  selector: 'app-addproduct',
  templateUrl: './addproduct.component.html',
  styleUrls: ['./addproduct.component.css']
})
export class AddproductComponent {
  product:Product =new Product();
  showErrors:boolean = false;
  @ViewChild("productForm") productForm:any
  order:any 
  constructor(){
    this.order=  {id:101,amount:200,
      orderedDate:new Date(2023,10,22),
      remarks:"This is a long description that is being done to show the purpose of custom pipe"}
  }
  changeVeg(){
    this.product.type="Veg";
  }
  changeNonVeg(){
    this.product.type="Non-Veg";
  }
  assignFile(pic:any){
    this.product.pic = "/assets/images/"+pic.files[0].name;
  }
  addProduct(){
    //console.log()
    //console.log(this.product)
    console.log(this.productForm)
    if(this.productForm.valid)
    {
      this.showErrors=false;
      alert("Added");
    }
      
    else
    {
      this.showErrors=true;
      alert("Details are incomplete")
    }
      
  }
}
