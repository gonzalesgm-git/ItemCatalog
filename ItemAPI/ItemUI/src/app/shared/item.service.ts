import { Injectable } from '@angular/core';
import  { HttpClient } from "@angular/common/http";
import { environment } from '../../environments/environment';
import { error } from 'console';

@Injectable({
  providedIn: 'root'
})
export class ItemService {

  url:string = environment.apiBaseUrl + '/item';

  constructor(private http:HttpClient) { }

  refreshList(){
    this.http.get(this.url)
      .subscribe({
        next: res => {
          console.log(res);
        },
        error: err => {
          console.log(err);
        }
      });
  }
}
