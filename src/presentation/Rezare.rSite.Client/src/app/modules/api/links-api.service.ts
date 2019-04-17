import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { ApiUrlGeneratorService } from './api-url-generator.service';
import { HttpClientConfigurationService } from './http-client-configuration.service';

@Injectable()
export class LinksApiService {  
  constructor(
    private httpClient: HttpClient,
    private urlGenerator: ApiUrlGeneratorService,
    private clientConfig: HttpClientConfigurationService
  ) { }

  getAll() : Promise<any> {
    var url = this.urlGenerator.generate('links');
    var httpOptions = this.clientConfig.getHttpOptions();

    return new Promise<any>((resolve, reject) => {
      this.httpClient.get(url, httpOptions)
        .toPromise()
        .then((data: any) => {
          resolve(data)
        })
        .catch(error => reject(error));
    });
  }
}