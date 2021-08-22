import { Component } from '@angular/core';
import { IDeviceInfoModel } from '../../models/interfaces/iDeviceInfoModel';
import { DeviceInfoApiService } from '../../services/device-api.service';


@Component({
  selector: 'app-device-detector',
  templateUrl: './device-detector.component.html'
})
export class DeviceDetectorComponent {
  public _deviceInfo: IDeviceInfoModel;
  public _loading = false;

  constructor(
    private _deviceInfoApiService: DeviceInfoApiService) { }

  public getUserDevice() {
    this._loading = true;
    this._deviceInfoApiService.getDeviceInfo().subscribe(result => {
      this._deviceInfo = result;
      this._loading = false;
    }, error => console.error(error));
  }
}
