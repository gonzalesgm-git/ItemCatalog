import { Component, OnInit } from '@angular/core';
import { ItemService } from '../shared/item.service';
import { Item } from '../shared/item.model';

@Component({
  selector: 'app-item-details',
  templateUrl: './item-details.component.html',
  styles: ``
})
export class ItemDetailsComponent implements OnInit {

  constructor(public itemService: ItemService){

  }

  ngOnInit(): void {
    this.itemService.refreshList();
  }

  populateForm(selectedItem: Item){
    this.itemService.formData = Object.assign({}, selectedItem);
  }

}
