import { Component } from '@angular/core';
import { ItemService } from '../../shared/item.service';
import { NgForm } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-item-detail-form',
  templateUrl: './item-detail-form.component.html',
  styles: ``
})
export class ItemDetailFormComponent {

  constructor(public itemService: ItemService, 
              private toastr: ToastrService){

  }

  onSubmit(form:NgForm){
    this.itemService.formSubmitted = true;
    if(form.valid){
      if(this.itemService.formData.id === 0){
        this.addItem(form);
      }else {
        this.updateItem(form);
      }
    }
  }

  addItem(form:NgForm){
    this.itemService.saveItem()
        .subscribe({
          next: res => {
            this.itemService.refreshList();
            this.itemService.resetForm(form);
            this.toastr.success('Item Added Succesfully', 'Item Catalog');
          },
          error: err => {
            console.log(err);
          }
        });
  }
  updateItem(form:NgForm){
    this.itemService.updateItem()
    .subscribe({
      next: res => {
          this.itemService.refreshList();
          this.itemService.resetForm(form);
          this.toastr.info('Item Updated Succesfully', 'Item Catalog');
      },
      error: err => {},
    });
  }
}
