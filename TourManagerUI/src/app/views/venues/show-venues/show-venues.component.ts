import { THIS_EXPR } from '@angular/compiler/src/output/output_ast';
import { Component, OnInit, Version } from '@angular/core';
import { VenuewsModels } from './../../../models/venues/venues-model';

@Component({
  selector: 'app-show-venues',
  templateUrl: './show-venues.component.html',
  styleUrls: ['./show-venues.component.less']
})



export class ShowVenuesComponent implements OnInit {

  public venuewsModels: VenuewsModels = new VenuewsModels();

  public listFlatModels: FlatModel[] = [];

  constructor() {
    this.loadVenue();
  }

  ngOnInit(): void {
  }

  public loadVenue(): void {

    const keys = Object.keys(this.venuewsModels);
    const keysWithoutId =  keys.filter(key => key !== 'id');

    for (const i in keysWithoutId) {

      if (keysWithoutId.hasOwnProperty(i)) {
        // code here
        const flat = new FlatModel();
        let name = keysWithoutId[i];

        name = name.charAt(0).toUpperCase() + name.slice(1);
        flat.propertyNameOfObject = name;
        flat.propertyValueOfObject = this.venuewsModels[i];
        this.listFlatModels.push(flat);
      }
    }
  }

  public updateValue(value: string, propertyToUpdate: string): void {

    this.venuewsModels[propertyToUpdate.toLocaleLowerCase()] = value;
  }
}

export class FlatModel{
  public propertyNameOfObject: string;
  public propertyValueOfObject: string;
}
