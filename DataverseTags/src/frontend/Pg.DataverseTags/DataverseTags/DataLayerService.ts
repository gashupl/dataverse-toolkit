
export interface IDataLayerService {
    getActiveTags(onSuccess: any, onError: any): void;
}

//TODO: https://www.dynamicsforcrm.com/building-a-react-app-using-powerapps-component-framework/
export class DataLayerService implements IDataLayerService {

    private webApi: ComponentFramework.WebApi

    constructor(webApi: ComponentFramework.WebApi) {
        this.webApi = webApi;
    }

    getActiveTags(onSuccess: any, onError: any): void {

        this.webApi.retrieveMultipleRecords("pg_tag", "?$filter=statecode eq 0")
            .then(function (records) {
                onSuccess(records);
                //return ['cars', 'finance', 'healthcare', 'utilities', 'public']; 
            })
            .catch(function (error: string) {
                onError(error)
            });
    }

}
