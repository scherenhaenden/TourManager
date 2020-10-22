import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { ContactsComponent } from './views/contacts/contacts/contacts.component';
import { SummaryComponent } from './views/contacts/summary/summary.component';
import { ShowVenuesComponent } from './views/venues/show-venues/show-venues.component';
import { VenueInformationComponent } from './views/venues/venue-information/venue-information.component';

const routes: Routes = [
  { path: '', pathMatch: 'full', redirectTo: '/venues' },
  { path: 'venues', component: ShowVenuesComponent  },
  { path: 'venues/summary', component: VenueInformationComponent  },
  { path: 'venues/summary/:id', component: VenueInformationComponent  },
  { path: 'contacts', component: ContactsComponent  },
  { path: 'contacts/summary', component: SummaryComponent  },
  { path: 'contacts/summary/:id', component: SummaryComponent  },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
