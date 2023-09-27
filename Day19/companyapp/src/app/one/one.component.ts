import { Component } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-one',
  templateUrl: './one.component.html',
  styleUrls: ['./one.component.css']
})
export class OneComponent {
numbers:number[]=[100,34,55,22,45];
constructor(private route:Router){

}
goTo(num:any){
  this.route.navigate(["two",num])
}
}
