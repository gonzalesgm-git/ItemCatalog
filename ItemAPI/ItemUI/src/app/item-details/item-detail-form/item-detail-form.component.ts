import { Component } from '@angular/core';
import { ItemService } from '../../shared/item.service';
import { NgForm } from '@angular/forms';

@Component({
  selector: 'app-item-detail-form',
  templateUrl: './item-detail-form.component.html',
  styles: ``
})
export class ItemDetailFormComponent {

  constructor(public itemService: ItemService){

  }

  onSubmit(form:NgForm){
    this.itemService.saveItem()
      .subscribe({
        next: res => {
          console.log(res);
        },
        error: err => {
          console.log(err);
        }
      })
  }
}
