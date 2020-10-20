import { Component, OnInit } from '@angular/core';
import { VenuesModels } from 'src/app/models/venues/venues-model';
import { VenuesService } from 'src/app/services/venues-service';

@Component({
  selector: 'app-venue-information',
  templateUrl: './venue-information.component.html',
  styleUrls: ['./venue-information.component.less']
})
export class VenueInformationComponent implements OnInit {

  public venuewsModels: VenuesModels = new VenuesModels();

  public listFlatModels: FlatModel[] = [];

  constructor(private venuesService: VenuesService) {
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

  public async saveInsertedInfo(): Promise<void>{
    const resilt = this.venuesService.addNewVenue(this.venuewsModels);
  }
}

export class FlatModel{
  public propertyNameOfObject: string;
  public propertyValueOfObject: string;
}
