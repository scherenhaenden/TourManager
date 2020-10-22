import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { ShowVenuesComponent } from './views/venues/show-venues/show-venues.component';
import { VenueInformationComponent } from './views/venues/venue-information/venue-information.component';

const routes: Routes = [
  { path: '', pathMatch: 'full', redirectTo: '/venues' },
  { path: 'venues', component: ShowVenuesComponent  },  
  { path: 'venues/summary', component: VenueInformationComponent  },
  { path: 'venues/summary/:id', component: VenueInformationComponent  },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
