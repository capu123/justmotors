import { FeatureService } from './../../services/feature.service';
import { MotorService } from './../../services/make.service';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-motor-form',
  templateUrl: './motor-form.component.html',
  styleUrls: ['./motor-form.component.css']
})
export class MotorFormComponent implements OnInit {
  makes: any[];
  models: any[];
  vechile: any = {};
  features: any[];

  constructor(
    private motorService: MotorService) { }

  ngOnInit() {
    this.motorService.getMakes().subscribe(makes => 
      this.makes = makes);

    this.motorService.getFeatures().subscribe(features =>
      this.features = features);
  }

  onMakeChange(){
    //console.log("VEHICLE", this.vechile);
    var selectedMake = this.makes.find(m=> m.id == this.vechile.make);
    this.models = selectedMake ? selectedMake.models : [];
  }


}
