import { Injectable } from '@angular/core';
import { VenuesModels } from '../models/venues/venues-model';
import { GenericApiService } from './generic-api-service';

@Injectable()
export class VenuesService {

    constructor(private genericApiService: GenericApiService) {

    }

    public async addNewVenue(venuewsModels: VenuesModels): Promise<any> {

        const url = './apipublic/venues/addvenue/';

        this.genericApiService.GenericPost(url, venuewsModels).toPromise();
    }

    public async showvenues<T>(): Promise<T> {

        const url = './apipublic/venues/showvenues/';

        return this.genericApiService.GenericPost(url, null).toPromise();
    }
}
