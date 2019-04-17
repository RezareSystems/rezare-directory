import { NgModule } from '@angular/core';
import { ApiUrlGeneratorService } from './api-url-generator.service';
import { HttpClientConfigurationService } from './http-client-configuration.service';
import { LinksApiService } from './links-api.service';

@NgModule({
  providers: [
    ApiUrlGeneratorService,
    HttpClientConfigurationService,
    LinksApiService
  ]
})
export class ApiModule { }
