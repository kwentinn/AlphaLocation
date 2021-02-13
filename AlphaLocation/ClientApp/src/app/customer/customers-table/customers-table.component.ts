import { Component, Input, OnInit } from '@angular/core';
import { Customer } from './customer.model';

@Component({
  selector: 'app-customers-table',
  templateUrl: './customers-table.component.html',
  styleUrls: ['./customers-table.component.css']
})
export class CustomersTableComponent implements OnInit {


  displayedColumns: string[] = ['gender', 'firstname', 'lastname'];

  @Input() customers: Customer[];

  constructor() { }

  ngOnInit() {
  }

}
