import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { LoginComponent } from './login/login.component';
import { AdminComponent } from './admin/admin.component';

import { RegistrationComponent } from './registration/registration.component';
import { HomeComponent } from './home/home.component';
import { OrganizerComponent } from './organizer/organizer.component';
import { ErrorComponent } from './error/error.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { MenuComponent } from './menu/menu.component';
import { RouterModule } from '@angular/router';
import { ListteamComponent } from './listteam/listteam.component';
import { ListplayerComponent } from './listplayer/listplayer.component';
import { CreateplayerComponent } from './createplayer/createplayer.component';
import { CreateteamComponent } from './createteam/createteam.component';
import {  HttpClientModule } from '@angular/common/http';
import { DetailsteamComponent } from './detailsteam/detailsteam.component';

@NgModule({
  declarations: [
    AppComponent,
    LoginComponent,
    AdminComponent,

    RegistrationComponent,
    HomeComponent,
    OrganizerComponent,
    ErrorComponent,
    MenuComponent,
    ListteamComponent,
    ListplayerComponent,
    CreateplayerComponent,
    CreateteamComponent,
    DetailsteamComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    ReactiveFormsModule,
    FormsModule,
    RouterModule,
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
