## MilkywayOnlineStore
### Project description

This is simple database for small and middle online stores. It's good support for logistic field of each store. 
Main goal of this database is easy, fast and intuitive operation of orders in online store.

Database allows for registering clients, adding products and categorise them, managing orders (include couriers list) and also discounts.

### Database structure
###### *(I will be use english names - originally in database is polish language)*

#### Tables

| Name | Description |
| :---- | :----------- |
|Categories |
| Brands |
| Products |
| Clients |
| ReservationStatus (dictionary) |
| OrderdsStatus (dictionary) |
| Couriers |
| DeliveryMethod |
| Orders |
| ProductsReservation |
| Discounts |

#### Views

| Name | Description |
| :----- | :----------- |
| v_CurrentOrders |
| v_ProductDetails |

#### Functions

| Name | Description |
| :-------- | :----------- |
| CategoryProductsCounter |
| ReservationsClientCounter |
| OrdersClientCounter |

#### Procedures

| Name | Description |
| :-------- | :----------- |
| AddClient |
| AddCategory |


