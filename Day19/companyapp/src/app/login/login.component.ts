import { Component } from '@angular/core';
import { User } from './user';
import { UserService } from '../services/user.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent {
user:User = new User();

constructor(private userService:UserService,private router:Router){

}

loginClick(){
  this.userService.login(this.user).subscribe(result=>{
    this.user = result as User;
    sessionStorage.setItem("token",this.user.token);
    alert("Login success");
    this.router.navigateByUrl("menu")
  })
}
}
