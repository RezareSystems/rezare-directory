import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';

import { AppComponent } from './app.component';
import { SideNavOuterToolbarModule, SideNavInnerToolbarModule, SingleCardModule } from './layouts';
import { FooterModule, LoginFormModule } from './shared/components';
import { AuthService, ScreenService, AppInfoService } from './shared/services';
import { AppRoutingModule } from './app-routing.module';
import { DxDataGridModule } from 'devextreme-angular';
import { ApiModule } from './modules/api/api.module';

@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    BrowserModule,
    SideNavOuterToolbarModule,
    SideNavInnerToolbarModule,
    SingleCardModule,
    FooterModule,
    LoginFormModule,
    AppRoutingModule,
    DxDataGridModule,
    HttpClientModule,
    ApiModule
  ],
  providers: [
    AuthService, 
    ScreenService, 
    AppInfoService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
