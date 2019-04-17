import { Injectable } from '@angular/core';
import { environment } from '../../../environments/environment';

@Injectable()
export class ApiUrlGeneratorService {
  constructor() { }

  generate(relativeUrl:string) : string {
    return environment.apiUrl + relativeUrl;
  }
}
