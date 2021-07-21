
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Component, Inject } from '@angular/core';

interface Order {
  branch: string;
  entityId: string;
  itemId: string;
  name: string;
  createdDate: string;
}
const httpOptions = {
  headers: new HttpHeaders({
    'Access-Control-Allow-Origin': '*',
    'Content-Type': 'application/json',
    'Access-Control-Allow-Methods': 'GET, POST, PATCH, PUT, DELETE, OPTIONS',
    'Accept': 'application/json',
  }),
  withCredentials: true,
};

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})


export class HomeComponent {

  public OrderList: any;

  public Result: Order[];

  public http: HttpClient;

  ordermanagementurl: string = "https://localhost:44316/api/orders";

  ListOrders() {
    this.http.get<any>(this.ordermanagementurl, httpOptions).subscribe(result => {
      this.OrderList = result;
    }, error => console.error(error));
  }


  public async initNewCall() {
    //this.AddTempRecord();
    this.ListOrders();
  }

  constructor(private _http: HttpClient) {
    this.http = _http;
    this.initNewCall();
  }

  AddTempRecord() {
    var data = {
      "branch": "Cairo",
      "name": "Chicken",
      "entityId": "cd9246de-913d-4e7d-8be0-d0fec9e6deb8",
      "itemId": null,
      "createdDate": "2021-07-21T00:00:00Z"
    };
    this.http.post<Order>(this.ordermanagementurl, data, httpOptions).subscribe(result => {
      this.OrderList = result;
    }, error => console.error(error));
  }

  append(name) {
    var data = {
      "branch": "Cairo",
      "name": name,
      "entityId": "cd9246de-913d-4e7d-8be0-d0fec9e6deb8",
      "itemId": null,
      "createdDate": "2021-07-21T00:00:00Z"
    };
    this.http.post<Order>(this.ordermanagementurl, data, httpOptions).subscribe(result => {
      this.OrderList = result;
    }, error => console.error(error));
  }

}
