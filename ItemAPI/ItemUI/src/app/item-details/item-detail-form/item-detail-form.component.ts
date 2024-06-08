import { Component } from '@angular/core';
import { ItemService } from '../../shared/item.service';

@Component({
  selector: 'app-item-detail-form',
  templateUrl: './item-detail-form.component.html',
  styles: ``
})
export class ItemDetailFormComponent {

  constructor(public itemService: ItemService){

  }
}
