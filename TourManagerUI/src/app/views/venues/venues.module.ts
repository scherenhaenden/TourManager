import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ShowVenuesComponent } from './show-venues/show-venues.component';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';



@NgModule({
  declarations: [ShowVenuesComponent],
  imports: [
    CommonModule,
    NgbModule
  ]
})
export class VenuesModule { }