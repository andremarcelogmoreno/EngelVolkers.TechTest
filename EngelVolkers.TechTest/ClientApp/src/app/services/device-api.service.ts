import { Inject, Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { IDeviceInfoModel } from '../models/interfaces/iDeviceInfoModel';

@Injectable({
  providedIn: 'root'
})
export class DeviceInfoApiService {
   private _http: HttpClient;
  private _baseUrl: string;

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this._http = http;
    this._baseUrl = baseUrl;
  }

  public getDeviceInfo(): Observable<IDeviceInfoModel> {
    return this._http.get<IDeviceInfoModel>(this._baseUrl + 'deviceInfo');
  }
}
