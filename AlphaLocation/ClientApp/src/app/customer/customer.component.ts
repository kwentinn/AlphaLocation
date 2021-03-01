import { Component, OnInit } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { Customer } from './models/customer.model';
import { CreateCustomerDialogComponent } from './dialogs/create-customer-dialog/create-customer-dialog.component';
import { CustomerService } from './services/customer.service';

@Component({
  selector: 'app-customer',
  templateUrl: './customer.component.html',
  styleUrls: ['./customer.component.css']
})
export class CustomerComponent implements OnInit {
  customers: Customer[];
  dialogRef: any;

  constructor(
    private readonly customerService: CustomerService,
    private readonly matDialog: MatDialog) { }

  ngOnInit() {
    this.customerService.GetCustomers()
      .subscribe(
        (customers) => this.customers = customers,
        (error) => console.error(error)
      );
  }
  public openCreateCustomerDialog(): void {
    this.dialogRef = this.matDialog.open(CreateCustomerDialogComponent);
  }
}
