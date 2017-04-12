import { MakeService } from './../../services/make.service';
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

  constructor(private makeService: MakeService) { }

  ngOnInit() {
    this.makeService.getMakes().subscribe(makes => 
      this.makes = makes);
  }

  onMakeChange(){
    //console.log("VEHICLE", this.vechile);
    var selectedMake = this.makes.find(m=> m.id == this.vechile.make);
    this.models = selectedMake ? selectedMake.models : [];
  }

}
