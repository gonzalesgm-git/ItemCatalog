import { Component } from '@angular/core';
import { AuthService } from '../../shared/auth.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styles: ``
})
export class LoginComponent {

  username: string = "";
  password: string = "";

  constructor(private authService:AuthService,
    private router: Router){

  }

  login(){
    this.authService.authenticate(this.username, this.password)
      .subscribe({
        next: res =>{
          this.router.navigate(['/item-details']);
        },
        error: err => {
          console.log(err);
        }
      });
  }
}
