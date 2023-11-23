import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { ListteamComponent } from './listteam/listteam.component';
import { ListplayerComponent } from './listplayer/listplayer.component';
import { HomeComponent } from './home/home.component';
import { CreateteamComponent } from './createteam/createteam.component';
import { DetailsteamComponent } from './detailsteam/detailsteam.component';
import { CreateplayerComponent } from './create/createplayer.component';

const routes: Routes = [
  {path:"",redirectTo:"home",pathMatch:'full'},
  {path:"listteam",component:ListteamComponent},
  {path:"listplayer",component:ListplayerComponent},
  {path:"home",component:HomeComponent},
  {path:"createteam",component:CreateteamComponent},
  {path:"detailsteam",component:DetailsteamComponent},
  {path:"createplayer",component:CreateplayerComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
