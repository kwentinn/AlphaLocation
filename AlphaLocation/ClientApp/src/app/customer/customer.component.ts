import { Component, OnInit } from '@angular/core';
import { Customer } from './customers-table/customer.model';
import { CustomerService } from './services/customer.service';

@Component({
  selector: 'app-customer',
  templateUrl: './customer.component.html',
  styleUrls: ['./customer.component.css']
})
export class CustomerComponent implements OnInit {
  customers: Customer[];

  constructor(private readonly customerService: CustomerService) { }

  ngOnInit() {
    this.customerService.GetCustomers()
      .subscribe(
        (customers) => this.customers = customers,
        (error) => console.error(error)
      );
  }

}
