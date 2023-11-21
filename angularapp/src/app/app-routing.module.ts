import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { ListteamComponent } from './listteam/listteam.component';

const routes: Routes = [
  {path:"listteam",component:ListteamComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
``