import { Component } from '@angular/core';
import CustomStore from 'devextreme/data/custom_store';
import { LinksApiService } from 'src/app/modules/api/links-api.service';

@Component({
  templateUrl: 'links.component.html',
  styleUrls: [ './links.component.scss' ],
})

export class LinksComponent {
  store: CustomStore;

  constructor(api: LinksApiService) {
    this.store = new CustomStore({
      load: function(loadOptions: any) {

        return api.getAll()
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

  configureCell(e: any) {
    e.cellElement.style.cursor = 'pointer';
  }
}
