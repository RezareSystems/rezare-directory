import { Injectable } from '@angular/core';
import { HttpHeaders } from '@angular/common/http';
import { environment } from '../../../environments/environment';

@Injectable()
export class HttpClientConfigurationService {

  constructor() { }

  getHttpOptions() : any {
    if (!environment.cors.enable) {
      return {
        headers: new HttpHeaders()
      };
    }

    return {
      headers: new HttpHeaders({
        'Access-Control-Allow-Origin': environment.cors.origin
      })
    };
  }
}
