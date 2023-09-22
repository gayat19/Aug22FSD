import { Injectable } from "@angular/core";
import { ActivatedRouteSnapshot, CanActivate, Router, RouterStateSnapshot, UrlTree } from "@angular/router";
import { JwtHelperService } from "@auth0/angular-jwt";
import { Observable } from "rxjs";


@Injectable()
export class AuthGuard implements CanActivate{
    
    constructor(private router:Router,
        private jwtHelper:JwtHelperService
        ){

    }
    canActivate(route: ActivatedRouteSnapshot, 
        state: RouterStateSnapshot
        ): boolean | UrlTree | Observable<boolean | UrlTree> | Promise<boolean | UrlTree> {
        var isAuthenticated = this.checkAuthentication()
        if(!isAuthenticated)
            this.router.navigateByUrl('login');
        return isAuthenticated;
    }
    checkAuthentication() {
        var token = sessionStorage.getItem("token");
        if(token)
        {
            if(!this.jwtHelper.isTokenExpired(token))
                return true;
        }
        return false;
        // return sessionStorage.getItem("token")?true:false;
    }   

}