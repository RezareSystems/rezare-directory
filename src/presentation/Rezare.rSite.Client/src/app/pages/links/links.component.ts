import { Component } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import CustomStore from 'devextreme/data/custom_store';

@Component({
  templateUrl: 'links.component.html',
  styleUrls: [ './links.component.scss' ]
})

export class LinksComponent {
  store: CustomStore;

  links = [
    {
      uri: "https://www.google.co.nz",
      name: "Google",
      description: "Search engine"
    }
  ];

  constructor(httpClient: HttpClient) {
    this.store = new CustomStore({
      load: function(loadOptions: any) {
        const httpOptions = {
          headers: new HttpHeaders({
            'Access-Control-Allow-Origin': 'http://localhost:4200'
          })
        };

        return httpClient.get('https://localhost:44378/api/links', httpOptions)
          .toPromise()
          .then((data: any) => {
            return {
              data: data
            }
          })
          .catch(error => { throw 'Data Loading Error' });
      }
    });
  }

  openLink (e:any) {
    if (!e.data) {
      return;
    }

    window.open(e.data.uri, '_blank');
  }
}
