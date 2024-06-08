import { Injectable } from '@angular/core';
import  { HttpClient } from "@angular/common/http";
import { environment } from '../../environments/environment';
import { Item } from './item.model';
import { NgForm } from '@angular/forms';

@Injectable({
  providedIn: 'root'
})
export class ItemService {

  url:string = `${environment.apiBaseUrl}/item`;
  list: Item[] = [];
  formData: Item = new Item();
  formSubmitted: boolean = false;
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

  saveItem(){
   return this.http.post(this.url, this.formData);
  }

  updateItem(){
    const url = `${this.url}/${this.formData.id}`;
    return this.http.put(url, this.formData);
  }

  resetForm(form: NgForm){
    form.form.reset();
    this.formData = new Item();
    this.formSubmitted = false;
  }
}
