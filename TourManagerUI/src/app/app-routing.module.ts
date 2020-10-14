import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { ShowVenuesComponent } from './views/venues/show-venues/show-venues.component';

const routes: Routes = [
  { path: '', pathMatch: 'full', redirectTo: '/home' },
  { path: 'home', component: ShowVenuesComponent  },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
