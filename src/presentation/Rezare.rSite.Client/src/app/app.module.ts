import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';

import { AppComponent } from './app.component';
import { SideNavOuterToolbarModule, SideNavInnerToolbarModule, SingleCardModule } from './layouts';
import { FooterModule, LoginFormModule } from './shared/components';
import { AuthService, ScreenService, AppInfoService } from './shared/services';
import { AppRoutingModule } from './app-routing.module';
import { DxDataGridModule } from 'devextreme-angular';
import { HttpClientConfigurationService } from './shared/services/http-client-configuration.service';
import { ApiUrlGeneratorService } from './shared/services/api-url-generator.service';
import { LinksApiService } from './shared/services/links-api.service';

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
    HttpClientModule
  ],
  providers: [
    AuthService, 
    ScreenService, 
    AppInfoService, 
    ApiUrlGeneratorService,
    HttpClientConfigurationService,
    LinksApiService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
