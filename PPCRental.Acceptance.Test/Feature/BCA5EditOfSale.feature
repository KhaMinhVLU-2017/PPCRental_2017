Feature: BCA5EditOfSale
	Allow Sales Edit Project
	Background: I Have Data Project
	Given Data of Projects
	 | PropertyName				 | Avatar        | Images        | Content																																							  | Status_Name | UserID | Duong | Phuong | Quan   | Loạiduan   | TienTe  | Gia   | Dientich  | Phongngu  | Phongtam  |
	 | Căn hộ Enterprise City	 | Sunrise01.JPG | Sunrise02.JPG | Nhà đẹp khu dân cư yên tĩnh, có nhiều tiện ích, gần trung tâm quận 7, gần các trung tâm thương mại khu vui chơi giải trí như Vivo City, Crescent Mall, Lotte Mart. | Đã duyệt    | 6      |Cao Lỗ | P.4    | Q.8	   | House      | USD     | 10000 | 1000m2    | 2         | 3         |
	 | PIS Top Apartment         | Sunrise01.JPG | Sunrise02.JPG | Nhà đẹp khu dân cư yên tĩnh, có nhiều tiện ích, gần trung tâm quận 7, gần các trung tâm thương mại khu vui chơi giải trí như Vivo City, Crescent Mall, Lotte Mart. | Đã duyệt    | 6      |Cao Lỗ | P.4    | Q.8    | House      | USD     | 10000 | 1000m2    | 2         | 3         |
	 | Bigroom with Riverview    | Sunrise01.JPG | Sunrise02.JPG | Nhà đẹp khu dân cư yên tĩnh, có nhiều tiện ích, gần trung tâm quận 7, gần các trung tâm thương mại khu vui chơi giải trí như Vivo City, Crescent Mall, Lotte Mart. | Đã duyệt    | 6      |Cao Lỗ | P.4    | Q.8    | House      | USD     | 10000 | 1000m2    | 2         | 3         |
	 | Phú Mỹ Hưng Quận 7        | Sunrise01.JPG | Sunrise02.JPG | Nhà đẹp khu dân cư yên tĩnh, có nhiều tiện ích, gần trung tâm quận 7, gần các trung tâm thương mại khu vui chơi giải trí như Vivo City, Crescent Mall, Lotte Mart. | Đã duyệt    | 6      |Cao Lỗ | P.4    | Q.8    | House      | USD     | 10000 | 1000m2    | 2         | 3         |
	 | Scala Quận 9              | Sunrise01.JPG | Sunrise02.JPG | Nhà đẹp khu dân cư yên tĩnh, có nhiều tiện ích, gần trung tâm quận 7, gần các trung tâm thương mại khu vui chơi giải trí như Vivo City, Crescent Mall, Lotte Mart. | Đã duyệt    | 6      |Cao Lỗ | P.4    | Q.8    | House      | USD     | 10000 | 1000m2    | 2         | 3         |
	 | Căn hộ Enterprise City 25 | Sunrise01.JPG | Sunrise02.JPG | Nhà đẹp khu dân cư yên tĩnh, có nhiều tiện ích, gần trung tâm quận 7, gần các trung tâm thương mại khu vui chơi giải trí như Vivo City, Crescent Mall, Lotte Mart. | Đã duyệt    | 6      |Cao Lỗ | P.4    | Q.8    | House      | USD     | 10000 | 1000m2    | 2         | 3         |


Scenario: Sale can Edit Project anyone Agency
	Given Sale at a HomePage
	When Sale login with account is user:'root' and pass:'toor' 
	And Sales Edit Project 'Căn hộ Enterprise City' 
	Then Result screen project 
	 | PropertyName						 | Avatar        | Images        | Content																																							  | Status_Name | UserID | Duong | Phuong | Quan   | Loại du an | Tien Te | Gia   | Dien tich | Phong ngu | Phong tam |
	 | JudasFate Căn hộ Enterprise City	 | Sunrise01.JPG | Sunrise02.JPG | Nhà đẹp khu dân cư yên tĩnh, có nhiều tiện ích, gần trung tâm quận 7, gần các trung tâm thương mại khu vui chơi giải trí như Vivo City, Crescent Mall, Lotte Mart. | Đã duyệt    | 6      |Cao Lỗ | P.4    | Quận 8 | House      | USD     | 10000 | 1000m2    | 2         | 3         |
