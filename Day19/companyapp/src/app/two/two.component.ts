import { Component } from '@angular/core';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-two',
  templateUrl: './two.component.html',
  styleUrls: ['./two.component.css']
})
export class TwoComponent {
data:string="";
constructor(private active:ActivatedRoute){
    this.data = active.snapshot.params["g3"]
}
}
