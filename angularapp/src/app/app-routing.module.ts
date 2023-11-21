import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { ListteamComponent } from './listteam/listteam.component';
import { ListplayerComponent } from './listplayer/listplayer.component';
import { HomeComponent } from './home/home.component';
import { CreateteamComponent } from './createteam/createteam.component';

const routes: Routes = [
  {path:"listteam",component:ListteamComponent},
  {path:"listplayer",component:ListplayerComponent},
  {path:"home",component:HomeComponent},
  {path:"createteam",component:CreateteamComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
``