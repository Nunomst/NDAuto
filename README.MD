Academic Project in C#


The NDAuto is a car rental company that aims to develop an application for managing its vehicle fleet, which includes cars, motorcycles, vans, and trucks. The application will be responsible for various tasks related to vehicle management and reservation tracking.

The application consists of the following classes:

1. Vehicle: The base class representing a generic vehicle. All other vehicle classes derive from this class.
2. Car: A subclass of Vehicle that includes additional attributes such as the number of doors (3 or 5) and the type of transmission (manual or automatic).
3. Motorcycle: A subclass of Vehicle that includes an attribute for engine displacement (50cc, 125cc, or 300cc).
4. Van: A subclass of Vehicle that includes attributes for the number of axles (2 or 3) and the maximum number of passengers.
5. Truck: A subclass of Vehicle that includes an attribute for the maximum supported weight (in kg).

All vehicles have a state associated with them, which can be one of the following: "available," "rented," "reserved," or "under maintenance." 
If a vehicle is in the "rented" or "under maintenance" state, there is a scheduled date for it to become "available" again.

The application also includes a Company class that maintains a list of vehicles. It provides a user interface with the following options:

1. Insert a new vehicle of any type.
2. Change the state of a vehicle.
3. View available vehicles for rent, filtered by vehicle type and considering the current date.
4. View vehicles under maintenance.
5. Calculate the price of a reservation based on the start and end dates and the selected vehicle.
6. Export vehicle information to a CSV file.

Additionally, the application features a reservation system. It allows users to calculate the total cost of rentals between two dates, considering all rented vehicles. The application provides a simulated date feature, allowing users to advance the system date by one day. This ensures that all vehicles are regularly checked for rental or maintenance end dates. If a date is reached, an alarm is triggered.
