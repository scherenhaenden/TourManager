import { THIS_EXPR } from '@angular/compiler/src/output/output_ast';
import { Component, OnInit, Version } from '@angular/core';
import { VenuesModels } from './../../../models/venues/venues-model';
import { VenuesService } from './../../../services/venues-service';

@Component({
  selector: 'app-show-venues',
  templateUrl: './show-venues.component.html',
  styleUrls: ['./show-venues.component.less']
})

export class ShowVenuesComponent implements OnInit {


  public listOFVenuewsModels: VenuesModels[] = [];
  public rowEntered = null;


  constructor(private venuesService: VenuesService) {
    this.loadVenues();
  }

  ngOnInit(): void {
  }

  public mouseEnterRow(that: object): void{

    this.rowEntered = that;
  }

  public mouseLeaveRow(that: object): void {

    if (this.rowEntered === that) {
    this.rowEntered = null;
    }
  }

  public async loadVenues(): Promise<void>  {

    const value = await this.venuesService.showvenues<VenuesModels[]>();
    this.listOFVenuewsModels = value;

    console.log('myInfo', value);

  }

  public formatTime(date: any): string {
    const myNewDate = this.sCdateToJsDate(date);
    return myNewDate.toLocaleTimeString();

  }


  public addNewVenue(): void {

  }


  // FIXME: decouple this
  public sCdateToJsDate(cSDate: any): Date {
    // cSDate is '2017-01-24T14:14:55.807'
    const datestr = cSDate.toString();
    const dateAr = datestr.split('-');
    const year = parseInt(dateAr[0]);
    const month = parseInt(dateAr[1]) - 1;
    const day = parseInt(dateAr[2].substring(0, dateAr[2].indexOf('T')));
    const timestring = dateAr[2].substring(dateAr[2].indexOf('T') + 1);
    const timeAr = timestring.split(':');
    const hour = parseInt(timeAr[0]);
    const min = parseInt(timeAr[1]);
    const sek = parseInt(timeAr[2]);
    const date = new Date(year, month, day, hour, min, sek, 0);
    return date;
}
}
