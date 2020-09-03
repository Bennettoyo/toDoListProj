import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-tasks',
  templateUrl: './tasks.component.html',
  styleUrls: ['./tasks.component.css']
})
export class TasksComponent implements OnInit {

  public sectionHeader = "Vehicles I want"
  public arrayOfVehicles = ["Bike", "Car", "Boat", "Cycle",]

  constructor() { }

  ngOnInit(): void {
  }

}
