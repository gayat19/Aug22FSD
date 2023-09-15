import { Component } from '@angular/core';

@Component({
  selector: 'app-third',
  templateUrl: './third.component.html',
  styleUrls: ['./third.component.css']
})
export class ThirdComponent {
  name:string;
  counter:number;
  classToggle:string ="fa fa-heart-o"
  boolToggle:boolean=false;
  constructor(){
    this.name = "Ramu";
    this.counter = 0;
  }
  handleClick(){
    // alert("You clicked teh button");
    this.counter++;
  }
  changeLook(){
    this.boolToggle = !this.boolToggle;
    if(this.boolToggle == true)
      this.classToggle ="fa fa-heart"
    else
      this.classToggle ="fa fa-heart-o"
  }
}
