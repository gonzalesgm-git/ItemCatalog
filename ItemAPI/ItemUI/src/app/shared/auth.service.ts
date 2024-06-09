import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from '../../environments/environment';
import { tap } from 'rxjs';

const httpOptions = {
  headers: new HttpHeaders({ 'Content-Type': 'application/json' })
};

const TOKEN = 'Token';

@Injectable({
  providedIn: 'root'
})
export class AuthService {

  auth_url: string = `${environment.apiBaseUrl}`;
  public token: any = null;

  constructor(private http: HttpClient) { 
   
  }

  authenticate(username: string, password: string){
  
    const loginUrl = `${this.auth_url}/auth/login`;
    return this.http.post(loginUrl, { username, password }, httpOptions)
      .pipe(tap((result) => {
        this.token = result;
      }));
  }

  isAuthenticated(): boolean{
    return this.token != null;
  }
}
