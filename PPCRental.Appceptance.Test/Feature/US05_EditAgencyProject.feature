Feature: Back-end Test
		In order to manage all project of agencies
		As a sale
		I want to edit angecy's projects
	
Background: Edit agency's Project
	Given The following projects
		| Name										| Agency's Name                                | Status	    |
		| Can ho Enterprise City					| Ly Thi Huyen Chau							   | Da duyet   |
		| Biet thu Saroma Sala Dai Quang Minh       | Ly Thi Huyen Chau                            | Cho duyet  |

	And I login into with sale's account
		| Information                    | Value                                                   |
		| Email							 | hoanganh27897@gmail.com                                 |
		| Password						 | 8258518												   |
	Scenario: Edit Agency Project
		When I edit the project with name 'Can ho Enterprise City'
		Then The project details should show
		| Information                    | Value														|
		| Property Name					 | Can ho Enterprise City										|
		| Avatar						 | DA05-01.JPG													|
		| Images						 | DA05-02.JPG													|
		| Property Type					 | Villa														|
		| Content						 | Can biet thu hoang gia nam o goc duong Dinh Tien Hoang ...   |
		| Street						 | Dinh Tien Hoang											    |
		| Ward							 | Phuong DaKao													|
		| District						 | Quan 1														|
		| Price							 | 2000000														|
		| Unit Price					 | USD															|
		| Area							 | 100															|
		| Bed Room						 | 2															|
		| Bath Room						 | 2															|
		| Parking Place					 | 1															|
		| User							 | Ly Thi Huyen Chau											|
		| Status						 | Da duyet														|
		| Note							 | 																|
		| Sale							 | Hoang Anh													|
		And I will edit the information I want to edit and press edit button
