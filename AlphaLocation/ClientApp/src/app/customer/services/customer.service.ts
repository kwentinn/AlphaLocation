import { HttpClient } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Customer } from '../models/customer.model';

@Injectable()
export class CustomerService {

    constructor(
        private readonly http: HttpClient,
        @Inject('BASE_URL') private readonly baseUrl: string,
    ) { }

    public GetCustomers(): Observable<Customer[]> {
        return this.http.get<Customer[]>(this.baseUrl + 'api/customer');
    }

    public CreateCustomer(customer: Customer): Observable<void> {
        return this.http.post<void>(this.baseUrl + 'api/customer', customer);
    }
}
