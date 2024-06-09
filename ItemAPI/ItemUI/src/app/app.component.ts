import { Component, OnInit } from '@angular/core';
import { AuthService } from './shared/auth.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styles: []
})
export class AppComponent implements OnInit{

  isLoggedIn: boolean = false;
  title = 'Item.UI';

  constructor(private authService:AuthService){
    
  }

  ngOnInit(): void {
    this.isLoggedIn = this.authService.isAuthenticated();
  }
  
}
