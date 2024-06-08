import { Component, OnInit } from '@angular/core';
import { ItemService } from '../shared/item.service';
import { Item } from '../shared/item.model';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-item-details',
  templateUrl: './item-details.component.html',
  styles: ``
})
export class ItemDetailsComponent implements OnInit {

  constructor(public itemService: ItemService,
    private toastr: ToastrService){

  }

  ngOnInit(): void {
    this.itemService.refreshList();
  }

  populateForm(selectedItem: Item){
    this.itemService.formData = Object.assign({}, selectedItem);
  }

  deleteItem(seletedItem: Item){
    this.itemService.deleteItem(seletedItem)
    .subscribe({
      next: res => {
        this.itemService.refreshList();
        this.toastr.warning('Item deleted Succesfully', 'Item Catalog');
      },
      error: err => {}
    })
  }

}
