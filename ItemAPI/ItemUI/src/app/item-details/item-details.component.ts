import { Component, OnInit } from '@angular/core';
import { ItemService } from '../shared/item.service';

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

}
