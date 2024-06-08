import { Injectable } from '@angular/core';
import  { HttpClient } from "@angular/common/http";
import { environment } from '../../environments/environment';
import { Item } from './item.model';

@Injectable({
  providedIn: 'root'
})
export class ItemService {

  url:string = environment.apiBaseUrl + '/item';
  list: Item[] = [];
  formData: Item = new Item();
  constructor(private http:HttpClient) { }

  refreshList(){
    this.http.get(this.url)
      .subscribe({
        next: res => {
          this.list = res as Item[];
        },
        error: err => {
          console.log(err);
        }
      });
  }
}
